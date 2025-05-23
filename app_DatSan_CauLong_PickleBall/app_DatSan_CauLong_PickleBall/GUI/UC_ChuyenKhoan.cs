﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using Newtonsoft.Json;
using RestSharp;

namespace GUI
{
    public partial class UC_ChuyenKhoan : UserControl
    {
        public UC_ChuyenKhoan()
        {
            InitializeComponent();
            this.Load += UC_ChuyenKhoan_Load;
            
        }

        

        private void btn_TaoQR_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSTK.Text) ||
                    string.IsNullOrWhiteSpace(txtTenTaiKhoan.Text) ||
                    string.IsNullOrWhiteSpace(txtSoTien.Text) ||
                    cb_nganhang.EditValue == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var apiRequest = new ApiRequest
                {
                    acqId = Convert.ToInt32(cb_nganhang.EditValue.ToString()),
                    accountNo = long.Parse(txtSTK.Text.Trim()),
                    accountName = txtTenTaiKhoan.Text.Trim(),
                    amount = Convert.ToInt32(txtSoTien.Text.Trim()),
                    addInfo = txtNoiDung.Text.Trim(), // textbox ghi chú (nếu có)
                    format = "text",
                    template = cb_template.Text
                };

                var jsonRequest = JsonConvert.SerializeObject(apiRequest);

                var client = new RestClient();
                var request = new RestRequest("https://api.vietqr.io/v2/generate",Method.Post);
                request.AddHeader("Accept", "application/json");
                request.AddParameter("application/json", jsonRequest, RestSharp.ParameterType.RequestBody);

                var response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    MessageBox.Show("Lỗi khi gọi API VietQR: " + response.ErrorMessage, "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var dataResult = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
                if (dataResult?.data?.qrDataURL == null)
                {
                    MessageBox.Show("Không thể tạo QR. Kiểm tra lại dữ liệu đầu vào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
                guna2PictureBox1.Image = image;
                guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_ChuyenKhoan_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                cb_nganhang.Properties.DataSource = listBankData.data;   // list banks
                cb_nganhang.Properties.DisplayMember = "custom_Name";
                cb_nganhang.Properties.ValueMember = "bin";
                cb_nganhang.EditValue = listBankData.data.FirstOrDefault().bin;
                cb_template.SelectedIndex = 0;
            }
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);

            return image;
        }
    }
}

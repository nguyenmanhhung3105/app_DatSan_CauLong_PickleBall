using System;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class UC_QuanLyDatSan : UserControl
    {
        public UC_QuanLyDatSan()
        {
            InitializeComponent();
        }

        private void UC_QuanLyDatSan_Load(object sender, EventArgs e)
        {
            // Thêm lựa chọn vào combobox trạng thái
            cb_TrangThai.Items.AddRange(new string[] { "Tất cả", "Chưa thanh toán", "Đã thanh toán" });
            cb_TrangThai.SelectedIndex = 0;

            // Gọi hàm hiển thị dữ liệu
            FillDatagridviewForMonth();

            // Gắn sự kiện khi chọn ngày thay đổi
            dTP_NgayDat.ValueChanged += dTP_NgayDat_ValueChanged;
            cb_TrangThai.SelectedIndexChanged += cb_TrangThai_SelectedIndexChanged;

            //Lọc theo tháng
            dTP_ThangDat.Format = DateTimePickerFormat.Custom;
            dTP_ThangDat.CustomFormat = "MM/yyyy";  // Hiển thị tháng và năm
            dTP_ThangDat.ShowUpDown = true;  // Hiển thị kiểu lên/xuống

            //Lọc theo quý
            cb_Quy.Items.AddRange(new string[] {
                "Quý 1 (Tháng 1 - 3)",
                "Quý 2 (Tháng 4 - 6)",
                "Quý 3 (Tháng 7 - 9)",
                "Quý 4 (Tháng 10 - 12)"
            });
            cb_Quy.SelectedIndex = 0;

            // Năm (hiện tại ± 5 năm)
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear - 5; year <= currentYear + 5; year++)
            {
                cb_Nam.Items.Add(year.ToString());
            }
            cb_Nam.SelectedItem = currentYear.ToString();

            // Chọn quý mặc định (ví dụ quý hiện tại)
            int currentQuarter = (DateTime.Now.Month - 1) / 3;
            cb_Quy.SelectedIndex = currentQuarter;

            //Hiển thị loại lọ
            lb_HienThiLoaiLoc.Text = "Lọc theo quý: Quý " + (cb_Quy.SelectedIndex + 1) + " - Năm " + cb_Nam.SelectedItem.ToString();
        }


        private int view = 1; // 1 = quý, 2 = tháng, 3 = ngày
        private void ReloadGridView()
        {
            if (view == 1)
                FillDatagridviewForQuarter();
            else if (view == 2)
                FillDatagridviewForMonth();
            else
                FillDatagridviewForDay();
        }


        private void AddDeleteButtonColumn()
        {
            // Kiểm tra nếu cột "Xóa" chưa tồn tại
            if (!dGV_PhieuDatSan.Columns.Contains("Xóa"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "Xóa";
                deleteColumn.HeaderText = "Xóa";
                deleteColumn.Text = "Xóa";
                deleteColumn.UseColumnTextForButtonValue = true;  // Hiển thị chữ "Xóa" trên nút
                deleteColumn.FlatStyle = FlatStyle.Flat;  // Tùy chỉnh giao diện
                dGV_PhieuDatSan.Columns.Add(deleteColumn);  // Thêm cột vào DataGridView
            }
        }

        private void FillDatagridviewForQuarter()
        {
            if (dGV_PhieuDatSan.Columns.Contains("Xóa"))
                dGV_PhieuDatSan.Columns.Remove("Xóa");

            // Lấy năm và quý mặc định là năm và quý hiện tại nếu chưa chọn
            int year = DateTime.Now.Year;
            int quarter = (DateTime.Now.Month - 1) / 3 + 1;

            // Nếu người dùng có chọn năm và quý, thì dùng giá trị đó
            if (cb_Nam.SelectedItem != null)
            {
                year = int.Parse(cb_Nam.SelectedItem.ToString());
            }

            if (cb_Quy.SelectedIndex != -1)
            {
                quarter = cb_Quy.SelectedIndex + 1;
            }

            DateTime startDate, endDate;

            switch (quarter)
            {
                case 1:
                    startDate = new DateTime(year, 1, 1);
                    endDate = new DateTime(year, 3, 31);
                    break;
                case 2:
                    startDate = new DateTime(year, 4, 1);
                    endDate = new DateTime(year, 6, 30);
                    break;
                case 3:
                    startDate = new DateTime(year, 7, 1);
                    endDate = new DateTime(year, 9, 30);
                    break;
                default:
                    startDate = new DateTime(year, 10, 1);
                    endDate = new DateTime(year, 12, 31);
                    break;
            }

            // Gọi từ BLL
            DataTable dt = PhieuDatSan_BLL.xemAllLichSuDatSanByMonth(startDate, endDate);

            var filteredData = dt.AsEnumerable();
            string tinhTrangThanhToan = cb_TrangThai.Text;

            if (tinhTrangThanhToan != "Tất cả")
            {
                filteredData = filteredData
                    .Where(row => row.Field<string>("Trạng thái") == tinhTrangThanhToan);
            }

            if (filteredData.Any())
            {
                dGV_PhieuDatSan.DataSource = filteredData.CopyToDataTable();
                AddDeleteButtonColumn(); // Thêm nút xoá
            }
            else
            {
                dGV_PhieuDatSan.DataSource = null;
            }
        }



        private void FillDatagridviewForMonth()
        {
            if (dGV_PhieuDatSan.Columns.Contains("Xóa"))
                dGV_PhieuDatSan.Columns.Remove("Xóa");
            // Lấy dữ liệu theo tháng
            DateTime startOfMonth = new DateTime(dTP_ThangDat.Value.Year, dTP_ThangDat.Value.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1); // Ngày cuối tháng

            // Lấy dữ liệu từ BLL theo khoảng thời gian trong tháng
            DataTable dt = PhieuDatSan_BLL.xemAllLichSuDatSanByMonth(startOfMonth, endOfMonth);

            // Lọc theo trạng thái thanh toán
            var filteredData = dt.AsEnumerable();
            string tinhTrangThanhToan = cb_TrangThai.Text;

            if (tinhTrangThanhToan != "Tất cả")
            {
                filteredData = filteredData
                    .Where(row => row.Field<string>("Trạng thái") == tinhTrangThanhToan);
            }

            if (filteredData.Any())
            {
                dGV_PhieuDatSan.DataSource = filteredData.CopyToDataTable();
                AddDeleteButtonColumn();  // Thêm cột "Xóa"
            }
            else
            {
                dGV_PhieuDatSan.DataSource = null;
            }
        }

        private void FillDatagridviewForDay()
        {
            if (dGV_PhieuDatSan.Columns.Contains("Xóa"))
                dGV_PhieuDatSan.Columns.Remove("Xóa");
            // Lấy dữ liệu từ BLL theo ngày được chọn
            DataTable dt = PhieuDatSan_BLL.xemAllLichSuDatSanByDate(dTP_NgayDat.Value);

            var filteredData = dt.AsEnumerable();
            string tinhTrangThanhToan = cb_TrangThai.Text;

            if (tinhTrangThanhToan != "Tất cả")
            {
                filteredData = filteredData
                    .Where(row => row.Field<string>("Trạng thái") == tinhTrangThanhToan);
            }

            if (filteredData.Any())
            {
                dGV_PhieuDatSan.DataSource = filteredData.CopyToDataTable();
                AddDeleteButtonColumn();  // Thêm cột "Xóa"
            }
            else
            {
                dGV_PhieuDatSan.DataSource = null;
            }
        }

        private void dGV_PhieuDatSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dGV_PhieuDatSan.Columns[e.ColumnIndex].Name == "Xóa")
            {
                // Xác nhận người dùng
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Lấy mã phiếu từ dòng được chọn
                    string maPhieu = dGV_PhieuDatSan.Rows[e.RowIndex].Cells["Mã phiếu"].Value.ToString();

                    try
                    {
                        // Gọi hàm xóa từ BLL
                        PhieuDatSan_BLL.deletePhieuDatSanByMaPDS(maPhieu);

                        // Load lại bảng sau khi xóa
                        ReloadGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cb_Quy_SelectedIndexChanged(object sender, EventArgs e)
        {
            view = 1;

            if (cb_Nam.SelectedItem != null)
            {
                lb_HienThiLoaiLoc.Text = "Lọc theo quý: Quý " + (cb_Quy.SelectedIndex + 1) + " - Năm " + cb_Nam.SelectedItem.ToString();
            }
            else
            {
                lb_HienThiLoaiLoc.Text = "Lọc theo quý: Quý " + (cb_Quy.SelectedIndex + 1);
            }

            FillDatagridviewForQuarter();
        }

        private void cb_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            view = 1;

            if (cb_Quy.SelectedIndex != -1 && cb_Nam.SelectedItem != null)
            {
                lb_HienThiLoaiLoc.Text = "Lọc theo quý: Quý " + (cb_Quy.SelectedIndex + 1) + " - Năm " + cb_Nam.SelectedItem.ToString();
            }
            else if (cb_Quy.SelectedIndex != -1)
            {
                lb_HienThiLoaiLoc.Text = "Lọc theo quý: Quý " + (cb_Quy.SelectedIndex + 1);
            }
            else
            {
                lb_HienThiLoaiLoc.Text = "Lọc theo quý";
            }

            FillDatagridviewForQuarter();
        }


        private void dTP_ThangDat_ValueChanged(object sender, EventArgs e)
        {
            view = 2;
            lb_HienThiLoaiLoc.Text = "Lọc theo tháng: " + dTP_ThangDat.Value.ToString("MM/yyyy");
            FillDatagridviewForMonth();
        }

        private void dTP_NgayDat_ValueChanged(object sender, EventArgs e)
        {
            view = 3;
            lb_HienThiLoaiLoc.Text = "Lọc theo ngày: " + dTP_NgayDat.Value.ToString("dd/MM/yyyy");
            FillDatagridviewForDay();
        }


        private void cb_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadGridView();
        }

        private void dGV_PhieuDatSan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải nhấn vào cell (chứ không phải header)
            if (e.RowIndex >= 0) // Nếu là cell (hành động nhấn vào ô dữ liệu, không phải header)
            {
                if (dGV_PhieuDatSan.Columns[e.ColumnIndex].Name != "Trạng thái")
                {
                    // Hiển thị thông báo
                    MessageBox.Show("Không thể sửa cột này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Hủy sự kiện chỉnh sửa nếu là cột khác
                    dGV_PhieuDatSan.CurrentCell = null;  // Hủy chọn ô để không vào chế độ chỉnh sửa
                }
            }
        }


        private void dGV_PhieuDatSan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu thay đổi trong cột "Trạng thái"
            if (dGV_PhieuDatSan.Columns[e.ColumnIndex].Name == "Trạng thái")
            {
                var row = dGV_PhieuDatSan.Rows[e.RowIndex];
                string newValue = row.Cells[e.ColumnIndex].Value?.ToString();

                // Nếu giá trị mới giống với giá trị cũ, không cần làm gì
                string oldValue = row.Cells[e.ColumnIndex].Tag?.ToString();
                if (newValue == oldValue) return;

                // Kiểm tra giá trị mới có phải là "Chưa thanh toán" hoặc "Đã thanh toán"
                if (newValue != "Chưa thanh toán" && newValue != "Đã thanh toán")
                {
                    MessageBox.Show("Trạng thái chỉ có thể là 'Chưa thanh toán' hoặc 'Đã thanh toán'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ReloadGridView();
                }
                else
                {
                    try
                    {
                        // Lấy mã phiếu để update
                        string maPhieu = row.Cells["Mã phiếu"].Value?.ToString();

                        if (!string.IsNullOrEmpty(maPhieu))
                        {
                            // Gọi hàm cập nhật xuống database
                            PhieuDatSan_BLL.upDateTinhTrangPhieuDatSan(maPhieu, newValue);
                            MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReloadGridView();
                    }
                }
            }
        }

        
    }
}

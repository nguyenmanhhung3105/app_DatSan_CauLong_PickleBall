using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class UC_QuanLyTaiKhoan: UserControl
    {
        public UC_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void UC_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {


            txt_Search.PlaceholderText = "Tìm kiếm...";
            LoadTaiKhoanKhachHang();
        }

        private void AddDeleteButtonColumn()
        {
            // Kiểm tra nếu cột "Xóa" chưa tồn tại
            if (!dGV_TaiKhoan.Columns.Contains("Xóa"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "Xóa";
                deleteColumn.HeaderText = "Xóa";
                deleteColumn.Text = "Xóa";
                deleteColumn.UseColumnTextForButtonValue = true;  // Hiển thị chữ "Xóa" trên nút
                deleteColumn.FlatStyle = FlatStyle.Flat;  // Tùy chỉnh giao diện
                dGV_TaiKhoan.Columns.Add(deleteColumn);  // Thêm cột vào DataGridView
            }
        }

        private void LoadTaiKhoanKhachHang()
        {
            DataTable dtKH = KhachHangBLL.SelectAllKhachHang();
            if (dtKH != null)
            {
                dGV_TaiKhoan.DataSource = dtKH;
                AddDeleteButtonColumn();
            }
        }

        private void dGV_TaiKhoan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nếu là cell (hành động nhấn vào ô dữ liệu, không phải header)
            {
                MessageBox.Show("Không thể sửa cột này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Hủy sự kiện chỉnh sửa nếu là cột khác
                dGV_TaiKhoan.CurrentCell = null;  // Hủy chọn ô để không vào chế độ chỉnh sửa
            }
        }

        private void dGV_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dGV_TaiKhoan.Columns[e.ColumnIndex].Name == "Xóa")
            {
                // Xác nhận người dùng
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Lấy mã phiếu từ dòng được chọn
                    string maKhachHang = dGV_TaiKhoan.Rows[e.RowIndex].Cells["Mã khách hàng"].Value.ToString();

                    try
                    {
                        // Gọi hàm xóa từ BLL
                        KhachHangBLL.DeleteKhachHangByMaKhachHang(maKhachHang);

                        // Load lại bảng sau khi xóa
                        LoadTaiKhoanKhachHang();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

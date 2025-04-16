using System;
using System.Data;
using System.Linq;
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

            //Tháng đặt
            dTP_ThangDat.Format = DateTimePickerFormat.Custom;
            dTP_ThangDat.CustomFormat = "MM/yyyy";  // Hiển thị tháng và năm
            dTP_ThangDat.ShowUpDown = true;  // Hiển thị kiểu lên/xuống


        }

        private bool isViewingByMonth = true;
        private void ReloadGridView()
        {
            if (isViewingByMonth)
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
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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



        private void dTP_ThangDat_ValueChanged(object sender, EventArgs e)
        {
            isViewingByMonth = true;
            FillDatagridviewForMonth();
        }

        private void dTP_NgayDat_ValueChanged(object sender, EventArgs e)
        {
            isViewingByMonth = false;
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

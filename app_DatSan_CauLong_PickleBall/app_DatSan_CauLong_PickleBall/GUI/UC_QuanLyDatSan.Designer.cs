namespace GUI
{
    partial class UC_QuanLyDatSan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_LocSan = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cb_Nam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_Quy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_QuyDat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dTP_ThangDat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lb_ThangDat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cb_TrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dTP_NgayDat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lb_trangthai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_NgayDat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dGV_PhieuDatSan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lb_HienThiLoaiLoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_QuanLyDatSan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gb_LocSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_PhieuDatSan)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_LocSan
            // 
            this.gb_LocSan.Controls.Add(this.cb_Nam);
            this.gb_LocSan.Controls.Add(this.cb_Quy);
            this.gb_LocSan.Controls.Add(this.lb_QuyDat);
            this.gb_LocSan.Controls.Add(this.dTP_ThangDat);
            this.gb_LocSan.Controls.Add(this.lb_ThangDat);
            this.gb_LocSan.Controls.Add(this.cb_TrangThai);
            this.gb_LocSan.Controls.Add(this.dTP_NgayDat);
            this.gb_LocSan.Controls.Add(this.lb_trangthai);
            this.gb_LocSan.Controls.Add(this.lb_NgayDat);
            this.gb_LocSan.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.gb_LocSan.FillColor = System.Drawing.SystemColors.Window;
            this.gb_LocSan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_LocSan.ForeColor = System.Drawing.Color.Black;
            this.gb_LocSan.Location = new System.Drawing.Point(21, 52);
            this.gb_LocSan.Margin = new System.Windows.Forms.Padding(2);
            this.gb_LocSan.Name = "gb_LocSan";
            this.gb_LocSan.Size = new System.Drawing.Size(1152, 150);
            this.gb_LocSan.TabIndex = 0;
            this.gb_LocSan.Text = "Lọc Sân";
            this.gb_LocSan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gb_LocSan.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // cb_Nam
            // 
            this.cb_Nam.BackColor = System.Drawing.Color.Transparent;
            this.cb_Nam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Nam.FillColor = System.Drawing.Color.LimeGreen;
            this.cb_Nam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Nam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Nam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Nam.ItemHeight = 30;
            this.cb_Nam.Location = new System.Drawing.Point(408, 54);
            this.cb_Nam.Name = "cb_Nam";
            this.cb_Nam.Size = new System.Drawing.Size(80, 36);
            this.cb_Nam.TabIndex = 8;
            this.cb_Nam.SelectedIndexChanged += new System.EventHandler(this.cb_Nam_SelectedIndexChanged);
            // 
            // cb_Quy
            // 
            this.cb_Quy.BackColor = System.Drawing.Color.Transparent;
            this.cb_Quy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Quy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Quy.FillColor = System.Drawing.Color.LimeGreen;
            this.cb_Quy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Quy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Quy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Quy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Quy.ItemHeight = 30;
            this.cb_Quy.Location = new System.Drawing.Point(221, 54);
            this.cb_Quy.Name = "cb_Quy";
            this.cb_Quy.Size = new System.Drawing.Size(181, 36);
            this.cb_Quy.TabIndex = 7;
            this.cb_Quy.SelectedIndexChanged += new System.EventHandler(this.cb_Quy_SelectedIndexChanged);
            // 
            // lb_QuyDat
            // 
            this.lb_QuyDat.BackColor = System.Drawing.Color.Transparent;
            this.lb_QuyDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuyDat.Location = new System.Drawing.Point(85, 60);
            this.lb_QuyDat.Name = "lb_QuyDat";
            this.lb_QuyDat.Size = new System.Drawing.Size(92, 23);
            this.lb_QuyDat.TabIndex = 6;
            this.lb_QuyDat.Text = "Lọc theo quý";
            // 
            // dTP_ThangDat
            // 
            this.dTP_ThangDat.Checked = true;
            this.dTP_ThangDat.FillColor = System.Drawing.Color.Chartreuse;
            this.dTP_ThangDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dTP_ThangDat.ForeColor = System.Drawing.Color.Black;
            this.dTP_ThangDat.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dTP_ThangDat.Location = new System.Drawing.Point(839, 54);
            this.dTP_ThangDat.Margin = new System.Windows.Forms.Padding(2);
            this.dTP_ThangDat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dTP_ThangDat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dTP_ThangDat.Name = "dTP_ThangDat";
            this.dTP_ThangDat.Size = new System.Drawing.Size(267, 29);
            this.dTP_ThangDat.TabIndex = 5;
            this.dTP_ThangDat.Value = new System.DateTime(2025, 4, 16, 15, 43, 19, 396);
            this.dTP_ThangDat.ValueChanged += new System.EventHandler(this.dTP_ThangDat_ValueChanged);
            // 
            // lb_ThangDat
            // 
            this.lb_ThangDat.BackColor = System.Drawing.Color.Transparent;
            this.lb_ThangDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThangDat.Location = new System.Drawing.Point(655, 60);
            this.lb_ThangDat.Margin = new System.Windows.Forms.Padding(2);
            this.lb_ThangDat.Name = "lb_ThangDat";
            this.lb_ThangDat.Size = new System.Drawing.Size(106, 23);
            this.lb_ThangDat.TabIndex = 4;
            this.lb_ThangDat.Text = "Lọc theo tháng";
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cb_TrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TrangThai.FillColor = System.Drawing.Color.LimeGreen;
            this.cb_TrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_TrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_TrangThai.ItemHeight = 30;
            this.cb_TrangThai.Location = new System.Drawing.Point(839, 103);
            this.cb_TrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(267, 36);
            this.cb_TrangThai.TabIndex = 3;
            this.cb_TrangThai.SelectedIndexChanged += new System.EventHandler(this.cb_TrangThai_SelectedIndexChanged);
            // 
            // dTP_NgayDat
            // 
            this.dTP_NgayDat.Checked = true;
            this.dTP_NgayDat.FillColor = System.Drawing.Color.Chartreuse;
            this.dTP_NgayDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dTP_NgayDat.ForeColor = System.Drawing.Color.Black;
            this.dTP_NgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dTP_NgayDat.Location = new System.Drawing.Point(221, 109);
            this.dTP_NgayDat.Margin = new System.Windows.Forms.Padding(2);
            this.dTP_NgayDat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dTP_NgayDat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dTP_NgayDat.Name = "dTP_NgayDat";
            this.dTP_NgayDat.Size = new System.Drawing.Size(267, 29);
            this.dTP_NgayDat.TabIndex = 2;
            this.dTP_NgayDat.Value = new System.DateTime(2025, 4, 16, 15, 43, 19, 396);
            this.dTP_NgayDat.ValueChanged += new System.EventHandler(this.dTP_NgayDat_ValueChanged);
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.BackColor = System.Drawing.Color.Transparent;
            this.lb_trangthai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trangthai.Location = new System.Drawing.Point(655, 109);
            this.lb_trangthai.Margin = new System.Windows.Forms.Padding(2);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(152, 23);
            this.lb_trangthai.TabIndex = 1;
            this.lb_trangthai.Text = "Trạng thái thanh toán";
            // 
            // lb_NgayDat
            // 
            this.lb_NgayDat.BackColor = System.Drawing.Color.Transparent;
            this.lb_NgayDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayDat.Location = new System.Drawing.Point(85, 116);
            this.lb_NgayDat.Margin = new System.Windows.Forms.Padding(2);
            this.lb_NgayDat.Name = "lb_NgayDat";
            this.lb_NgayDat.Size = new System.Drawing.Size(100, 23);
            this.lb_NgayDat.TabIndex = 0;
            this.lb_NgayDat.Text = "Lọc theo ngày";
            // 
            // dGV_PhieuDatSan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGV_PhieuDatSan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_PhieuDatSan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_PhieuDatSan.ColumnHeadersHeight = 50;
            this.dGV_PhieuDatSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_PhieuDatSan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_PhieuDatSan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGV_PhieuDatSan.Location = new System.Drawing.Point(21, 240);
            this.dGV_PhieuDatSan.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_PhieuDatSan.Name = "dGV_PhieuDatSan";
            this.dGV_PhieuDatSan.RowHeadersVisible = false;
            this.dGV_PhieuDatSan.RowHeadersWidth = 51;
            this.dGV_PhieuDatSan.RowTemplate.Height = 24;
            this.dGV_PhieuDatSan.Size = new System.Drawing.Size(1152, 349);
            this.dGV_PhieuDatSan.TabIndex = 1;
            this.dGV_PhieuDatSan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGV_PhieuDatSan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGV_PhieuDatSan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGV_PhieuDatSan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGV_PhieuDatSan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGV_PhieuDatSan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGV_PhieuDatSan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGV_PhieuDatSan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGV_PhieuDatSan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGV_PhieuDatSan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGV_PhieuDatSan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGV_PhieuDatSan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dGV_PhieuDatSan.ThemeStyle.HeaderStyle.Height = 50;
            this.dGV_PhieuDatSan.ThemeStyle.ReadOnly = false;
            this.dGV_PhieuDatSan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGV_PhieuDatSan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGV_PhieuDatSan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGV_PhieuDatSan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGV_PhieuDatSan.ThemeStyle.RowsStyle.Height = 24;
            this.dGV_PhieuDatSan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGV_PhieuDatSan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGV_PhieuDatSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_PhieuDatSan_CellClick);
            this.dGV_PhieuDatSan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_PhieuDatSan_CellDoubleClick);
            this.dGV_PhieuDatSan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_PhieuDatSan_CellValueChanged);
            // 
            // lb_HienThiLoaiLoc
            // 
            this.lb_HienThiLoaiLoc.BackColor = System.Drawing.Color.Transparent;
            this.lb_HienThiLoaiLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HienThiLoaiLoc.Location = new System.Drawing.Point(485, 207);
            this.lb_HienThiLoaiLoc.Name = "lb_HienThiLoaiLoc";
            this.lb_HienThiLoaiLoc.Size = new System.Drawing.Size(131, 26);
            this.lb_HienThiLoaiLoc.TabIndex = 2;
            this.lb_HienThiLoaiLoc.Text = "Hiển thị loại lọc";
            // 
            // lb_QuanLyDatSan
            // 
            this.lb_QuanLyDatSan.BackColor = System.Drawing.Color.Transparent;
            this.lb_QuanLyDatSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuanLyDatSan.Location = new System.Drawing.Point(485, 3);
            this.lb_QuanLyDatSan.Name = "lb_QuanLyDatSan";
            this.lb_QuanLyDatSan.Size = new System.Drawing.Size(229, 39);
            this.lb_QuanLyDatSan.TabIndex = 3;
            this.lb_QuanLyDatSan.Text = "Quản lý đặt sân";
            // 
            // UC_QuanLyDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_QuanLyDatSan);
            this.Controls.Add(this.lb_HienThiLoaiLoc);
            this.Controls.Add(this.dGV_PhieuDatSan);
            this.Controls.Add(this.gb_LocSan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_QuanLyDatSan";
            this.Size = new System.Drawing.Size(1200, 609);
            this.Load += new System.EventHandler(this.UC_QuanLyDatSan_Load);
            this.gb_LocSan.ResumeLayout(false);
            this.gb_LocSan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_PhieuDatSan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gb_LocSan;
        private Guna.UI2.WinForms.Guna2DateTimePicker dTP_NgayDat;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_trangthai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_NgayDat;
        private Guna.UI2.WinForms.Guna2DataGridView dGV_PhieuDatSan;
        private Guna.UI2.WinForms.Guna2ComboBox cb_TrangThai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dTP_ThangDat;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ThangDat;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_QuyDat;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Nam;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Quy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_HienThiLoaiLoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_QuanLyDatSan;
    }
}

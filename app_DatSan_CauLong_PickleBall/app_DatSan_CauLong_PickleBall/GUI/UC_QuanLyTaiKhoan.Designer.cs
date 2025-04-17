namespace GUI
{
    partial class UC_QuanLyTaiKhoan
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
            this.dGV_TaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lb_HienThiTaiKhoan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_QuanLyTaiKhoan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bt_TK_khachhang = new Guna.UI2.WinForms.Guna2Button();
            this.bt_TK_quanly = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_HienThiTatCa = new Guna.UI2.WinForms.Guna2Button();
            this.gb_LocSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_LocSan
            // 
            this.gb_LocSan.Controls.Add(this.bt_HienThiTatCa);
            this.gb_LocSan.Controls.Add(this.txt_Search);
            this.gb_LocSan.Controls.Add(this.bt_TK_quanly);
            this.gb_LocSan.Controls.Add(this.bt_TK_khachhang);
            this.gb_LocSan.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.gb_LocSan.FillColor = System.Drawing.SystemColors.Window;
            this.gb_LocSan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_LocSan.ForeColor = System.Drawing.Color.Black;
            this.gb_LocSan.Location = new System.Drawing.Point(21, 52);
            this.gb_LocSan.Margin = new System.Windows.Forms.Padding(2);
            this.gb_LocSan.Name = "gb_LocSan";
            this.gb_LocSan.Size = new System.Drawing.Size(1152, 150);
            this.gb_LocSan.TabIndex = 1;
            this.gb_LocSan.Text = "Lọc tài khoản";
            this.gb_LocSan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gb_LocSan.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // dGV_TaiKhoan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGV_TaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_TaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_TaiKhoan.ColumnHeadersHeight = 50;
            this.dGV_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_TaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_TaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGV_TaiKhoan.Location = new System.Drawing.Point(21, 238);
            this.dGV_TaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_TaiKhoan.Name = "dGV_TaiKhoan";
            this.dGV_TaiKhoan.RowHeadersVisible = false;
            this.dGV_TaiKhoan.RowHeadersWidth = 51;
            this.dGV_TaiKhoan.RowTemplate.Height = 24;
            this.dGV_TaiKhoan.Size = new System.Drawing.Size(1152, 349);
            this.dGV_TaiKhoan.TabIndex = 9;
            this.dGV_TaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGV_TaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGV_TaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGV_TaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGV_TaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGV_TaiKhoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGV_TaiKhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGV_TaiKhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGV_TaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGV_TaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGV_TaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGV_TaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dGV_TaiKhoan.ThemeStyle.HeaderStyle.Height = 50;
            this.dGV_TaiKhoan.ThemeStyle.ReadOnly = false;
            this.dGV_TaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGV_TaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGV_TaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGV_TaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGV_TaiKhoan.ThemeStyle.RowsStyle.Height = 24;
            this.dGV_TaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGV_TaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGV_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_TaiKhoan_CellClick);
            this.dGV_TaiKhoan.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_TaiKhoan_CellContentDoubleClick);
            // 
            // lb_HienThiTaiKhoan
            // 
            this.lb_HienThiTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lb_HienThiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HienThiTaiKhoan.Location = new System.Drawing.Point(527, 207);
            this.lb_HienThiTaiKhoan.Name = "lb_HienThiTaiKhoan";
            this.lb_HienThiTaiKhoan.Size = new System.Drawing.Size(147, 26);
            this.lb_HienThiTaiKhoan.TabIndex = 10;
            this.lb_HienThiTaiKhoan.Text = "Hiển thị tài khoản";
            // 
            // lb_QuanLyTaiKhoan
            // 
            this.lb_QuanLyTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lb_QuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuanLyTaiKhoan.Location = new System.Drawing.Point(486, 8);
            this.lb_QuanLyTaiKhoan.Name = "lb_QuanLyTaiKhoan";
            this.lb_QuanLyTaiKhoan.Size = new System.Drawing.Size(253, 39);
            this.lb_QuanLyTaiKhoan.TabIndex = 11;
            this.lb_QuanLyTaiKhoan.Text = "Quản lý tài khoản";
            // 
            // bt_TK_khachhang
            // 
            this.bt_TK_khachhang.BorderRadius = 23;
            this.bt_TK_khachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_TK_khachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_TK_khachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_TK_khachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_TK_khachhang.FillColor = System.Drawing.Color.LimeGreen;
            this.bt_TK_khachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_TK_khachhang.ForeColor = System.Drawing.Color.White;
            this.bt_TK_khachhang.Location = new System.Drawing.Point(64, 68);
            this.bt_TK_khachhang.Name = "bt_TK_khachhang";
            this.bt_TK_khachhang.Size = new System.Drawing.Size(157, 49);
            this.bt_TK_khachhang.TabIndex = 0;
            this.bt_TK_khachhang.Text = "Tài khoản khách hàng";
            // 
            // bt_TK_quanly
            // 
            this.bt_TK_quanly.BorderRadius = 23;
            this.bt_TK_quanly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_TK_quanly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_TK_quanly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_TK_quanly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_TK_quanly.FillColor = System.Drawing.Color.LimeGreen;
            this.bt_TK_quanly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_TK_quanly.ForeColor = System.Drawing.Color.White;
            this.bt_TK_quanly.Location = new System.Drawing.Point(928, 68);
            this.bt_TK_quanly.Name = "bt_TK_quanly";
            this.bt_TK_quanly.Size = new System.Drawing.Size(157, 49);
            this.bt_TK_quanly.TabIndex = 1;
            this.bt_TK_quanly.Text = "Tài khoản nhân viên";
            // 
            // txt_Search
            // 
            this.txt_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_Search.BorderRadius = 20;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Location = new System.Drawing.Point(422, 43);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_Search.PlaceholderText = "";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(313, 38);
            this.txt_Search.TabIndex = 12;
            // 
            // bt_HienThiTatCa
            // 
            this.bt_HienThiTatCa.BorderRadius = 8;
            this.bt_HienThiTatCa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_HienThiTatCa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_HienThiTatCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_HienThiTatCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_HienThiTatCa.FillColor = System.Drawing.Color.LimeGreen;
            this.bt_HienThiTatCa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_HienThiTatCa.ForeColor = System.Drawing.Color.White;
            this.bt_HienThiTatCa.Location = new System.Drawing.Point(520, 99);
            this.bt_HienThiTatCa.Name = "bt_HienThiTatCa";
            this.bt_HienThiTatCa.Size = new System.Drawing.Size(114, 30);
            this.bt_HienThiTatCa.TabIndex = 13;
            this.bt_HienThiTatCa.Text = "Hiển thị tất cả";
            // 
            // UC_QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_QuanLyTaiKhoan);
            this.Controls.Add(this.lb_HienThiTaiKhoan);
            this.Controls.Add(this.dGV_TaiKhoan);
            this.Controls.Add(this.gb_LocSan);
            this.Name = "UC_QuanLyTaiKhoan";
            this.Size = new System.Drawing.Size(1200, 609);
            this.Load += new System.EventHandler(this.UC_QuanLyTaiKhoan_Load);
            this.gb_LocSan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gb_LocSan;
        private Guna.UI2.WinForms.Guna2DataGridView dGV_TaiKhoan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_HienThiTaiKhoan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_QuanLyTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button bt_TK_quanly;
        private Guna.UI2.WinForms.Guna2Button bt_TK_khachhang;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2Button bt_HienThiTatCa;
    }
}

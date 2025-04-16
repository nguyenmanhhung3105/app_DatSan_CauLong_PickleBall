namespace GUI
{
    partial class UC_ChuyenKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ChuyenKhoan));
            this.pn_DatLich = new Guna.UI2.WinForms.Guna2Panel();
            this.cb_nganhang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_TaoQR = new Guna.UI2.WinForms.Guna2Button();
            this.cb_template = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_GioDat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_TenSan = new System.Windows.Forms.Label();
            this.lbl_LoaiSan = new System.Windows.Forms.Label();
            this.lbl_NgayDat = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pn_DatLich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_nganhang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_DatLich
            // 
            this.pn_DatLich.BackColor = System.Drawing.Color.Transparent;
            this.pn_DatLich.BorderRadius = 20;
            this.pn_DatLich.Controls.Add(this.cb_nganhang);
            this.pn_DatLich.Controls.Add(this.btn_TaoQR);
            this.pn_DatLich.Controls.Add(this.cb_template);
            this.pn_DatLich.Controls.Add(this.txtTenTaiKhoan);
            this.pn_DatLich.Controls.Add(this.txtNoiDung);
            this.pn_DatLich.Controls.Add(this.label3);
            this.pn_DatLich.Controls.Add(this.label2);
            this.pn_DatLich.Controls.Add(this.txtSoTien);
            this.pn_DatLich.Controls.Add(this.lbl_GioDat);
            this.pn_DatLich.Controls.Add(this.label5);
            this.pn_DatLich.Controls.Add(this.txtSTK);
            this.pn_DatLich.Controls.Add(this.lbl_TenSan);
            this.pn_DatLich.Controls.Add(this.lbl_LoaiSan);
            this.pn_DatLich.Controls.Add(this.lbl_NgayDat);
            this.pn_DatLich.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_DatLich.Location = new System.Drawing.Point(1069, 141);
            this.pn_DatLich.Name = "pn_DatLich";
            this.pn_DatLich.Size = new System.Drawing.Size(427, 503);
            this.pn_DatLich.TabIndex = 40;
            // 
            // cb_nganhang
            // 
            this.cb_nganhang.Location = new System.Drawing.Point(147, 63);
            this.cb_nganhang.Name = "cb_nganhang";
            this.cb_nganhang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_nganhang.Properties.NullText = "";
            this.cb_nganhang.Properties.PopupView = this.gridLookUpEdit1View;
            this.cb_nganhang.Size = new System.Drawing.Size(265, 22);
            this.cb_nganhang.TabIndex = 42;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ngân hàng";
            this.gridColumn1.FieldName = "custom_Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.ShowUnboundExpressionMenu = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // btn_TaoQR
            // 
            this.btn_TaoQR.AutoRoundedCorners = true;
            this.btn_TaoQR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoQR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoQR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TaoQR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TaoQR.FillColor = System.Drawing.Color.Lime;
            this.btn_TaoQR.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoQR.ForeColor = System.Drawing.Color.White;
            this.btn_TaoQR.Location = new System.Drawing.Point(136, 420);
            this.btn_TaoQR.Name = "btn_TaoQR";
            this.btn_TaoQR.Size = new System.Drawing.Size(180, 45);
            this.btn_TaoQR.TabIndex = 57;
            this.btn_TaoQR.Text = "Tạo mã QR code";
            this.btn_TaoQR.Click += new System.EventHandler(this.btn_TaoQR_Click);
            // 
            // cb_template
            // 
            this.cb_template.BackColor = System.Drawing.Color.Transparent;
            this.cb_template.BorderRadius = 10;
            this.cb_template.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_template.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_template.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_template.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_template.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_template.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_template.ItemHeight = 30;
            this.cb_template.Items.AddRange(new object[] {
            "Compact",
            "Compact2",
            "qr_print",
            "qr_only",
            "print"});
            this.cb_template.Location = new System.Drawing.Point(147, 273);
            this.cb_template.Name = "cb_template";
            this.cb_template.Size = new System.Drawing.Size(265, 36);
            this.cb_template.TabIndex = 56;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTenTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtTenTaiKhoan.BorderRadius = 10;
            this.txtTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.DefaultText = "Nguyen Hai Dang";
            this.txtTenTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(147, 158);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.PlaceholderText = "";
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(265, 39);
            this.txtTenTaiKhoan.TabIndex = 55;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.Color.Transparent;
            this.txtNoiDung.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtNoiDung.BorderRadius = 10;
            this.txtNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDung.DefaultText = "Thanh toán tiền sân";
            this.txtNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Location = new System.Drawing.Point(147, 326);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PlaceholderText = "";
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.Size = new System.Drawing.Size(265, 39);
            this.txtNoiDung.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 91);
            this.label3.TabIndex = 39;
            this.label3.Text = "Thông tin thêm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "Templates";
            // 
            // txtSoTien
            // 
            this.txtSoTien.BackColor = System.Drawing.Color.Transparent;
            this.txtSoTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtSoTien.BorderRadius = 10;
            this.txtSoTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTien.DefaultText = "100000";
            this.txtSoTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTien.Location = new System.Drawing.Point(147, 214);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.PlaceholderText = "";
            this.txtSoTien.SelectedText = "";
            this.txtSoTien.Size = new System.Drawing.Size(265, 39);
            this.txtSoTien.TabIndex = 35;
            // 
            // lbl_GioDat
            // 
            this.lbl_GioDat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GioDat.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioDat.ForeColor = System.Drawing.Color.Black;
            this.lbl_GioDat.Location = new System.Drawing.Point(9, 141);
            this.lbl_GioDat.Name = "lbl_GioDat";
            this.lbl_GioDat.Size = new System.Drawing.Size(99, 69);
            this.lbl_GioDat.TabIndex = 19;
            this.lbl_GioDat.Text = "Tên tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(142, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 30);
            this.label5.TabIndex = 34;
            this.label5.Text = "Phiếu Đặt Sân";
            // 
            // txtSTK
            // 
            this.txtSTK.BackColor = System.Drawing.Color.Transparent;
            this.txtSTK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtSTK.BorderRadius = 10;
            this.txtSTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSTK.DefaultText = "1041163405";
            this.txtSTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSTK.Location = new System.Drawing.Point(147, 102);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.PlaceholderText = "";
            this.txtSTK.SelectedText = "";
            this.txtSTK.Size = new System.Drawing.Size(265, 39);
            this.txtSTK.TabIndex = 27;
            // 
            // lbl_TenSan
            // 
            this.lbl_TenSan.AutoSize = true;
            this.lbl_TenSan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TenSan.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSan.ForeColor = System.Drawing.Color.Black;
            this.lbl_TenSan.Location = new System.Drawing.Point(9, 55);
            this.lbl_TenSan.Name = "lbl_TenSan";
            this.lbl_TenSan.Size = new System.Drawing.Size(127, 30);
            this.lbl_TenSan.TabIndex = 26;
            this.lbl_TenSan.Text = "Ngân hàng";
            // 
            // lbl_LoaiSan
            // 
            this.lbl_LoaiSan.AutoSize = true;
            this.lbl_LoaiSan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LoaiSan.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoaiSan.ForeColor = System.Drawing.Color.Black;
            this.lbl_LoaiSan.Location = new System.Drawing.Point(9, 111);
            this.lbl_LoaiSan.Name = "lbl_LoaiSan";
            this.lbl_LoaiSan.Size = new System.Drawing.Size(140, 30);
            this.lbl_LoaiSan.TabIndex = 17;
            this.lbl_LoaiSan.Text = "Số tài khoản";
            // 
            // lbl_NgayDat
            // 
            this.lbl_NgayDat.AutoSize = true;
            this.lbl_NgayDat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NgayDat.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayDat.ForeColor = System.Drawing.Color.Black;
            this.lbl_NgayDat.Location = new System.Drawing.Point(9, 223);
            this.lbl_NgayDat.Name = "lbl_NgayDat";
            this.lbl_NgayDat.Size = new System.Drawing.Size(84, 30);
            this.lbl_NgayDat.TabIndex = 18;
            this.lbl_NgayDat.Text = "Số tiền";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(257, 167);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(593, 456);
            this.guna2PictureBox1.TabIndex = 41;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UC_ChuyenKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.pn_DatLich);
            this.DoubleBuffered = true;
            this.Name = "UC_ChuyenKhoan";
            this.Size = new System.Drawing.Size(1600, 750);
            this.Load += new System.EventHandler(this.UC_ChuyenKhoan_Load);
            this.pn_DatLich.ResumeLayout(false);
            this.pn_DatLich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_nganhang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pn_DatLich;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTien;
        private System.Windows.Forms.Label lbl_GioDat;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSTK;
        private System.Windows.Forms.Label lbl_TenSan;
        private System.Windows.Forms.Label lbl_LoaiSan;
        private System.Windows.Forms.Label lbl_NgayDat;
        private Guna.UI2.WinForms.Guna2ComboBox cb_template;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btn_TaoQR;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private DevExpress.XtraEditors.GridLookUpEdit cb_nganhang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}

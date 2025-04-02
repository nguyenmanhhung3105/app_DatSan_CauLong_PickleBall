namespace GUI
{
    partial class FormRegister
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pt_Hide = new System.Windows.Forms.PictureBox();
            this.pt_MiniMaxmize = new System.Windows.Forms.PictureBox();
            this.pt_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_DangKy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lb_ThongBao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Dangnhap = new System.Windows.Forms.LinkLabel();
            this.btn_Showpassword2 = new Guna.UI2.WinForms.Guna2Button();
            this.tb_XacnhanMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_XacnhanMK = new System.Windows.Forms.Label();
            this.btn_ShowPassWord1 = new Guna.UI2.WinForms.Guna2Button();
            this.tb_MK = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Hoten = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_DangKy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.pn_OTPDK = new Guna.UI2.WinForms.Guna2Panel();
            this.ptb_1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_MiniMaxmize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pn_OTPDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pt_Hide);
            this.panel1.Controls.Add(this.pt_MiniMaxmize);
            this.panel1.Controls.Add(this.pt_Close);
            this.panel1.Location = new System.Drawing.Point(1777, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 34);
            this.panel1.TabIndex = 5;
            // 
            // pt_Hide
            // 
            this.pt_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_Hide.Image = global::GUI.Properties.Resources.minimize_sign;
            this.pt_Hide.Location = new System.Drawing.Point(9, 4);
            this.pt_Hide.Margin = new System.Windows.Forms.Padding(4);
            this.pt_Hide.Name = "pt_Hide";
            this.pt_Hide.Size = new System.Drawing.Size(33, 27);
            this.pt_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_Hide.TabIndex = 11;
            this.pt_Hide.TabStop = false;
            this.pt_Hide.Click += new System.EventHandler(this.pt_Hide_Click);
            // 
            // pt_MiniMaxmize
            // 
            this.pt_MiniMaxmize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_MiniMaxmize.Image = global::GUI.Properties.Resources.rounded_rectangle;
            this.pt_MiniMaxmize.Location = new System.Drawing.Point(51, 4);
            this.pt_MiniMaxmize.Margin = new System.Windows.Forms.Padding(4);
            this.pt_MiniMaxmize.Name = "pt_MiniMaxmize";
            this.pt_MiniMaxmize.Size = new System.Drawing.Size(57, 27);
            this.pt_MiniMaxmize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_MiniMaxmize.TabIndex = 10;
            this.pt_MiniMaxmize.TabStop = false;
            this.pt_MiniMaxmize.Click += new System.EventHandler(this.pt_MiniMaxmize_Click_1);
            // 
            // pt_Close
            // 
            this.pt_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_Close.Image = global::GUI.Properties.Resources.close;
            this.pt_Close.Location = new System.Drawing.Point(116, 4);
            this.pt_Close.Margin = new System.Windows.Forms.Padding(4);
            this.pt_Close.Name = "pt_Close";
            this.pt_Close.Size = new System.Drawing.Size(25, 27);
            this.pt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_Close.TabIndex = 9;
            this.pt_Close.TabStop = false;
            this.pt_Close.Click += new System.EventHandler(this.pt_Close_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::GUI.Properties.Resources.logoNhom;
            this.pictureBox8.Location = new System.Drawing.Point(949, 50);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(247, 188);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::GUI.Properties.Resources.logoPM;
            this.pictureBox9.Location = new System.Drawing.Point(667, 50);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(223, 188);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.pn_OTPDK);
            this.guna2Panel1.Controls.Add(this.btn_DangKy);
            this.guna2Panel1.Controls.Add(this.lb_ThongBao);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.lb_Dangnhap);
            this.guna2Panel1.Controls.Add(this.btn_Showpassword2);
            this.guna2Panel1.Controls.Add(this.tb_XacnhanMK);
            this.guna2Panel1.Controls.Add(this.lb_XacnhanMK);
            this.guna2Panel1.Controls.Add(this.btn_ShowPassWord1);
            this.guna2Panel1.Controls.Add(this.tb_MK);
            this.guna2Panel1.Controls.Add(this.tb_SDT);
            this.guna2Panel1.Controls.Add(this.lb_SDT);
            this.guna2Panel1.Controls.Add(this.pictureBox6);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.tb_Email);
            this.guna2Panel1.Controls.Add(this.tb_Hoten);
            this.guna2Panel1.Controls.Add(this.lb_DangKy);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.lb_Ten);
            this.guna2Panel1.Controls.Add(this.lb_Email);
            this.guna2Panel1.Controls.Add(this.lb_MatKhau);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Location = new System.Drawing.Point(277, 254);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 30;
            this.guna2Panel1.ShadowDecoration.Depth = 5;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 15, 15, 5);
            this.guna2Panel1.Size = new System.Drawing.Size(1371, 629);
            this.guna2Panel1.TabIndex = 17;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BorderRadius = 20;
            this.btn_DangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangKy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DangKy.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_DangKy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_DangKy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_DangKy.ForeColor = System.Drawing.Color.White;
            this.btn_DangKy.Location = new System.Drawing.Point(805, 516);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(443, 48);
            this.btn_DangKy.TabIndex = 37;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseTransparentBackground = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // lb_ThongBao
            // 
            this.lb_ThongBao.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongBao.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao.Location = new System.Drawing.Point(676, 452);
            this.lb_ThongBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ThongBao.Name = "lb_ThongBao";
            this.lb_ThongBao.Size = new System.Drawing.Size(638, 61);
            this.lb_ThongBao.TabIndex = 38;
            this.lb_ThongBao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1261, 312);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Dangnhap
            // 
            this.lb_Dangnhap.AutoSize = true;
            this.lb_Dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dangnhap.Location = new System.Drawing.Point(1064, 572);
            this.lb_Dangnhap.Name = "lb_Dangnhap";
            this.lb_Dangnhap.Size = new System.Drawing.Size(108, 25);
            this.lb_Dangnhap.TabIndex = 35;
            this.lb_Dangnhap.TabStop = true;
            this.lb_Dangnhap.Text = "Đăng nhập";
            this.lb_Dangnhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_Dangnhap_LinkClicked);
            // 
            // btn_Showpassword2
            // 
            this.btn_Showpassword2.BackColor = System.Drawing.Color.White;
            this.btn_Showpassword2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Showpassword2.BackgroundImage")));
            this.btn_Showpassword2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Showpassword2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Showpassword2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Showpassword2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Showpassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Showpassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Showpassword2.FillColor = System.Drawing.Color.Transparent;
            this.btn_Showpassword2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Showpassword2.ForeColor = System.Drawing.Color.White;
            this.btn_Showpassword2.Location = new System.Drawing.Point(1249, 399);
            this.btn_Showpassword2.Name = "btn_Showpassword2";
            this.btn_Showpassword2.Size = new System.Drawing.Size(44, 37);
            this.btn_Showpassword2.TabIndex = 34;
            this.btn_Showpassword2.Click += new System.EventHandler(this.btn_Showpassword2_Click);
            // 
            // tb_XacnhanMK
            // 
            this.tb_XacnhanMK.Animated = true;
            this.tb_XacnhanMK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_XacnhanMK.BorderRadius = 20;
            this.tb_XacnhanMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_XacnhanMK.DefaultText = "";
            this.tb_XacnhanMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_XacnhanMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_XacnhanMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_XacnhanMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_XacnhanMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_XacnhanMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_XacnhanMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_XacnhanMK.Location = new System.Drawing.Point(1027, 393);
            this.tb_XacnhanMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_XacnhanMK.Name = "tb_XacnhanMK";
            this.tb_XacnhanMK.PasswordChar = '*';
            this.tb_XacnhanMK.PlaceholderText = "Xác nhận mật khẩu...";
            this.tb_XacnhanMK.SelectedText = "";
            this.tb_XacnhanMK.Size = new System.Drawing.Size(278, 48);
            this.tb_XacnhanMK.TabIndex = 32;
            // 
            // lb_XacnhanMK
            // 
            this.lb_XacnhanMK.AutoSize = true;
            this.lb_XacnhanMK.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XacnhanMK.Location = new System.Drawing.Point(1027, 366);
            this.lb_XacnhanMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_XacnhanMK.Name = "lb_XacnhanMK";
            this.lb_XacnhanMK.Size = new System.Drawing.Size(221, 23);
            this.lb_XacnhanMK.TabIndex = 31;
            this.lb_XacnhanMK.Text = "Xác nhận mật khẩu";
            // 
            // btn_ShowPassWord1
            // 
            this.btn_ShowPassWord1.BackColor = System.Drawing.Color.White;
            this.btn_ShowPassWord1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ShowPassWord1.BackgroundImage")));
            this.btn_ShowPassWord1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ShowPassWord1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPassWord1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowPassWord1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowPassWord1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ShowPassWord1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ShowPassWord1.FillColor = System.Drawing.Color.Transparent;
            this.btn_ShowPassWord1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ShowPassWord1.ForeColor = System.Drawing.Color.White;
            this.btn_ShowPassWord1.Location = new System.Drawing.Point(941, 399);
            this.btn_ShowPassWord1.Name = "btn_ShowPassWord1";
            this.btn_ShowPassWord1.Size = new System.Drawing.Size(44, 37);
            this.btn_ShowPassWord1.TabIndex = 30;
            this.btn_ShowPassWord1.Click += new System.EventHandler(this.btn_ShowPassWord1_Click);
            // 
            // tb_MK
            // 
            this.tb_MK.Animated = true;
            this.tb_MK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_MK.BorderRadius = 20;
            this.tb_MK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MK.DefaultText = "";
            this.tb_MK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_MK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_MK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_MK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_MK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_MK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_MK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_MK.Location = new System.Drawing.Point(722, 393);
            this.tb_MK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MK.Name = "tb_MK";
            this.tb_MK.PasswordChar = '*';
            this.tb_MK.PlaceholderText = "Nhập mật khẩu...";
            this.tb_MK.SelectedText = "";
            this.tb_MK.Size = new System.Drawing.Size(276, 48);
            this.tb_MK.TabIndex = 29;
            // 
            // tb_SDT
            // 
            this.tb_SDT.Animated = true;
            this.tb_SDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_SDT.BorderRadius = 20;
            this.tb_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SDT.DefaultText = "";
            this.tb_SDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_SDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_SDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SDT.Location = new System.Drawing.Point(722, 302);
            this.tb_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.PlaceholderText = "Nhập số điện thoại...";
            this.tb_SDT.SelectedText = "";
            this.tb_SDT.Size = new System.Drawing.Size(592, 48);
            this.tb_SDT.TabIndex = 21;
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDT.Location = new System.Drawing.Point(723, 275);
            this.lb_SDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(154, 23);
            this.lb_SDT.TabIndex = 20;
            this.lb_SDT.Text = "Số điện thoại";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Image = global::GUI.Properties.Resources.user1;
            this.pictureBox6.Location = new System.Drawing.Point(1263, 220);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::GUI.Properties.Resources.user1;
            this.pictureBox2.Location = new System.Drawing.Point(1261, 133);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // tb_Email
            // 
            this.tb_Email.Animated = true;
            this.tb_Email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_Email.BorderRadius = 20;
            this.tb_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Email.DefaultText = "";
            this.tb_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Email.Location = new System.Drawing.Point(722, 212);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.PlaceholderText = "Nhập email...";
            this.tb_Email.SelectedText = "";
            this.tb_Email.Size = new System.Drawing.Size(592, 48);
            this.tb_Email.TabIndex = 19;
            // 
            // tb_Hoten
            // 
            this.tb_Hoten.Animated = true;
            this.tb_Hoten.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_Hoten.BorderRadius = 20;
            this.tb_Hoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Hoten.DefaultText = "";
            this.tb_Hoten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Hoten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Hoten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Hoten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Hoten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Hoten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Hoten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Hoten.Location = new System.Drawing.Point(722, 124);
            this.tb_Hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Hoten.Name = "tb_Hoten";
            this.tb_Hoten.PlaceholderText = "Nhập họ tên..";
            this.tb_Hoten.SelectedText = "";
            this.tb_Hoten.Size = new System.Drawing.Size(592, 48);
            this.tb_Hoten.TabIndex = 18;
            // 
            // lb_DangKy
            // 
            this.lb_DangKy.AutoSize = true;
            this.lb_DangKy.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_DangKy.Location = new System.Drawing.Point(523, 31);
            this.lb_DangKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DangKy.Name = "lb_DangKy";
            this.lb_DangKy.Size = new System.Drawing.Size(365, 41);
            this.lb_DangKy.TabIndex = 0;
            this.lb_DangKy.Text = "Đăng ký tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(891, 576);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bạn đã có tài khoản?";
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ten.Location = new System.Drawing.Point(723, 97);
            this.lb_Ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(114, 23);
            this.lb_Ten.TabIndex = 15;
            this.lb_Ten.Text = "Họ và tên";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(723, 185);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(70, 23);
            this.lb_Email.TabIndex = 1;
            this.lb_Email.Text = "Email";
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhau.Location = new System.Drawing.Point(723, 366);
            this.lb_MatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(111, 23);
            this.lb_MatKhau.TabIndex = 2;
            this.lb_MatKhau.Text = "Mật khẩu";
            // 
            // pn_OTPDK
            // 
            this.pn_OTPDK.BorderRadius = 30;
            this.pn_OTPDK.Controls.Add(this.ptb_1);
            this.pn_OTPDK.Location = new System.Drawing.Point(52, 86);
            this.pn_OTPDK.Name = "pn_OTPDK";
            this.pn_OTPDK.Size = new System.Drawing.Size(561, 490);
            this.pn_OTPDK.TabIndex = 39;
            // 
            // ptb_1
            // 
            this.ptb_1.BackColor = System.Drawing.Color.Transparent;
            this.ptb_1.BorderRadius = 20;
            this.ptb_1.Image = ((System.Drawing.Image)(resources.GetObject("ptb_1.Image")));
            this.ptb_1.ImageRotate = 0F;
            this.ptb_1.Location = new System.Drawing.Point(3, 0);
            this.ptb_1.Name = "ptb_1";
            this.ptb_1.Size = new System.Drawing.Size(561, 490);
            this.ptb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_1.TabIndex = 0;
            this.ptb_1.TabStop = false;
            this.ptb_1.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 30;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1370, 629);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 40;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::GUI.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1029);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pt_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_MiniMaxmize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pn_OTPDK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pt_Hide;
        private System.Windows.Forms.PictureBox pt_MiniMaxmize;
        private System.Windows.Forms.PictureBox pt_Close;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lb_DangKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_MatKhau;
        private Guna.UI2.WinForms.Guna2TextBox tb_Hoten;
        private Guna.UI2.WinForms.Guna2TextBox tb_SDT;
        private System.Windows.Forms.Label lb_SDT;
        private Guna.UI2.WinForms.Guna2TextBox tb_Email;
        private Guna.UI2.WinForms.Guna2TextBox tb_XacnhanMK;
        private System.Windows.Forms.Label lb_XacnhanMK;
        private Guna.UI2.WinForms.Guna2Button btn_ShowPassWord1;
        private Guna.UI2.WinForms.Guna2TextBox tb_MK;
        private Guna.UI2.WinForms.Guna2Button btn_Showpassword2;
        private System.Windows.Forms.LinkLabel lb_Dangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_DangKy;
        private System.Windows.Forms.Label lb_ThongBao;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_1;
        private Guna.UI2.WinForms.Guna2Panel pn_OTPDK;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
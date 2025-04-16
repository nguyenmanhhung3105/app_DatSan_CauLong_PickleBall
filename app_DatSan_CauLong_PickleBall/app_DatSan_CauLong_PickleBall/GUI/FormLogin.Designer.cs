using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace GUI
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lb_DangNhap = new System.Windows.Forms.Label();
            this.lb_TaiKhoan = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pt_Hide = new System.Windows.Forms.PictureBox();
            this.pt_MiniMaxmize = new System.Windows.Forms.PictureBox();
            this.pt_Close = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ptb_1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_Loi = new System.Windows.Forms.Label();
            this.lb_Dangky = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LoginGoogle = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ShowPassWord = new Guna.UI2.WinForms.Guna2Button();
            this.btn_DangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.tb_SoDTorEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_QuenMatKhau = new System.Windows.Forms.Label();
            this.tb_MK = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_MiniMaxmize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Close)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_DangNhap
            // 
            this.lb_DangNhap.AutoSize = true;
            this.lb_DangNhap.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.lb_DangNhap.ForeColor = System.Drawing.Color.Green;
            this.lb_DangNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_DangNhap.Location = new System.Drawing.Point(911, 28);
            this.lb_DangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DangNhap.Name = "lb_DangNhap";
            this.lb_DangNhap.Size = new System.Drawing.Size(224, 41);
            this.lb_DangNhap.TabIndex = 0;
            this.lb_DangNhap.Text = "Đăng nhập";
            // 
            // lb_TaiKhoan
            // 
            this.lb_TaiKhoan.AutoSize = true;
            this.lb_TaiKhoan.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_TaiKhoan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_TaiKhoan.Location = new System.Drawing.Point(663, 186);
            this.lb_TaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TaiKhoan.Name = "lb_TaiKhoan";
            this.lb_TaiKhoan.Size = new System.Drawing.Size(287, 23);
            this.lb_TaiKhoan.TabIndex = 1;
            this.lb_TaiKhoan.Text = "Số điện thoại hoặc email:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::GUI.Properties.Resources.user1;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(1259, 222);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::GUI.Properties.Resources.logoNhom;
            this.pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox5.Location = new System.Drawing.Point(938, 30);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(247, 188);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::GUI.Properties.Resources.logoPM;
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(682, 30);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(223, 188);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pt_Hide);
            this.panel1.Controls.Add(this.pt_MiniMaxmize);
            this.panel1.Controls.Add(this.pt_Close);
            this.panel1.Location = new System.Drawing.Point(1766, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 34);
            this.panel1.TabIndex = 4;
            // 
            // pt_Hide
            // 
            this.pt_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_Hide.Image = global::GUI.Properties.Resources.minimize_sign;
            this.pt_Hide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pt_Hide.Location = new System.Drawing.Point(10, 4);
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
            this.pt_MiniMaxmize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pt_MiniMaxmize.Location = new System.Drawing.Point(51, 4);
            this.pt_MiniMaxmize.Margin = new System.Windows.Forms.Padding(4);
            this.pt_MiniMaxmize.Name = "pt_MiniMaxmize";
            this.pt_MiniMaxmize.Size = new System.Drawing.Size(57, 27);
            this.pt_MiniMaxmize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_MiniMaxmize.TabIndex = 10;
            this.pt_MiniMaxmize.TabStop = false;
            this.pt_MiniMaxmize.Click += new System.EventHandler(this.pt_MiniMaxmize_Click);
            // 
            // pt_Close
            // 
            this.pt_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_Close.Image = global::GUI.Properties.Resources.close;
            this.pt_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pt_Close.Location = new System.Drawing.Point(116, 4);
            this.pt_Close.Margin = new System.Windows.Forms.Padding(4);
            this.pt_Close.Name = "pt_Close";
            this.pt_Close.Size = new System.Drawing.Size(25, 27);
            this.pt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_Close.TabIndex = 9;
            this.pt_Close.TabStop = false;
            this.pt_Close.Click += new System.EventHandler(this.pt_Close_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.ptb_1);
            this.guna2Panel1.Controls.Add(this.lbl_Loi);
            this.guna2Panel1.Controls.Add(this.lb_Dangky);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btn_LoginGoogle);
            this.guna2Panel1.Controls.Add(this.btn_ShowPassWord);
            this.guna2Panel1.Controls.Add(this.btn_DangNhap);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.tb_SoDTorEmail);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.lb_QuenMatKhau);
            this.guna2Panel1.Controls.Add(this.tb_MK);
            this.guna2Panel1.Controls.Add(this.lb_DangNhap);
            this.guna2Panel1.Controls.Add(this.lb_TaiKhoan);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Location = new System.Drawing.Point(256, 223);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1371, 654);
            this.guna2Panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "./img/login.gif";
            this.pictureBox1.Location = new System.Drawing.Point(34, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(244)))), ((int)(((byte)(199)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(886, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Bạn chưa có tài khoản?";
            // 
            // ptb_1
            // 
            this.ptb_1.BackColor = System.Drawing.Color.Transparent;
            this.ptb_1.BorderRadius = 30;
            this.ptb_1.FillColor = System.Drawing.Color.Transparent;
            this.ptb_1.Image = ((System.Drawing.Image)(resources.GetObject("ptb_1.Image")));
            this.ptb_1.ImageRotate = 0F;
            this.ptb_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ptb_1.Location = new System.Drawing.Point(0, -1);
            this.ptb_1.Margin = new System.Windows.Forms.Padding(0);
            this.ptb_1.Name = "ptb_1";
            this.ptb_1.Size = new System.Drawing.Size(659, 655);
            this.ptb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_1.TabIndex = 31;
            this.ptb_1.TabStop = false;
            this.ptb_1.UseTransparentBackground = true;
            // 
            // lbl_Loi
            // 
            this.lbl_Loi.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Loi.ForeColor = System.Drawing.Color.Red;
            this.lbl_Loi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Loi.Location = new System.Drawing.Point(667, 378);
            this.lbl_Loi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Loi.Name = "lbl_Loi";
            this.lbl_Loi.Size = new System.Drawing.Size(654, 61);
            this.lbl_Loi.TabIndex = 20;
            this.lbl_Loi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_Dangky
            // 
            this.lb_Dangky.AutoSize = true;
            this.lb_Dangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(244)))), ((int)(((byte)(199)))));
            this.lb_Dangky.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.lb_Dangky.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_Dangky.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_Dangky.Location = new System.Drawing.Point(1114, 613);
            this.lb_Dangky.Name = "lb_Dangky";
            this.lb_Dangky.Size = new System.Drawing.Size(100, 31);
            this.lb_Dangky.TabIndex = 27;
            this.lb_Dangky.TabStop = true;
            this.lb_Dangky.Text = "Đăng ký";
            this.lb_Dangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_Dangky_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(915, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "---Hoặc đăng nhập với---";
            // 
            // btn_LoginGoogle
            // 
            this.btn_LoginGoogle.Animated = true;
            this.btn_LoginGoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_LoginGoogle.BorderRadius = 10;
            this.btn_LoginGoogle.BorderThickness = 2;
            this.btn_LoginGoogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoginGoogle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LoginGoogle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LoginGoogle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LoginGoogle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LoginGoogle.FillColor = System.Drawing.Color.Transparent;
            this.btn_LoginGoogle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_LoginGoogle.ForeColor = System.Drawing.Color.White;
            this.btn_LoginGoogle.Image = ((System.Drawing.Image)(resources.GetObject("btn_LoginGoogle.Image")));
            this.btn_LoginGoogle.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_LoginGoogle.Location = new System.Drawing.Point(935, 530);
            this.btn_LoginGoogle.Name = "btn_LoginGoogle";
            this.btn_LoginGoogle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_LoginGoogle.Size = new System.Drawing.Size(102, 83);
            this.btn_LoginGoogle.TabIndex = 23;
            this.btn_LoginGoogle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_LoginGoogle.UseTransparentBackground = true;
            this.btn_LoginGoogle.Click += new System.EventHandler(this.btn_LoginGoogle_Click);
            // 
            // btn_ShowPassWord
            // 
            this.btn_ShowPassWord.BackColor = System.Drawing.Color.White;
            this.btn_ShowPassWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ShowPassWord.BackgroundImage")));
            this.btn_ShowPassWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ShowPassWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPassWord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowPassWord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ShowPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ShowPassWord.FillColor = System.Drawing.Color.Transparent;
            this.btn_ShowPassWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ShowPassWord.ForeColor = System.Drawing.Color.White;
            this.btn_ShowPassWord.Location = new System.Drawing.Point(1259, 313);
            this.btn_ShowPassWord.Name = "btn_ShowPassWord";
            this.btn_ShowPassWord.Size = new System.Drawing.Size(44, 33);
            this.btn_ShowPassWord.TabIndex = 28;
            this.btn_ShowPassWord.Click += new System.EventHandler(this.btn_ShowPassWord_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BorderRadius = 10;
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DangNhap.FillColor = System.Drawing.Color.Lime;
            this.btn_DangNhap.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.Location = new System.Drawing.Point(869, 442);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(239, 49);
            this.btn_DangNhap.TabIndex = 22;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseTransparentBackground = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // tb_SoDTorEmail
            // 
            this.tb_SoDTorEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_SoDTorEmail.BorderRadius = 20;
            this.tb_SoDTorEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SoDTorEmail.DefaultText = "";
            this.tb_SoDTorEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_SoDTorEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_SoDTorEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SoDTorEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SoDTorEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SoDTorEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_SoDTorEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SoDTorEmail.Location = new System.Drawing.Point(667, 213);
            this.tb_SoDTorEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_SoDTorEmail.Name = "tb_SoDTorEmail";
            this.tb_SoDTorEmail.PlaceholderText = "Nhập số điện thoại hoặc email...";
            this.tb_SoDTorEmail.SelectedText = "";
            this.tb_SoDTorEmail.Size = new System.Drawing.Size(654, 48);
            this.tb_SoDTorEmail.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(663, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mật khẩu";
            // 
            // lb_QuenMatKhau
            // 
            this.lb_QuenMatKhau.AutoSize = true;
            this.lb_QuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_QuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lb_QuenMatKhau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_QuenMatKhau.Location = new System.Drawing.Point(1190, 358);
            this.lb_QuenMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_QuenMatKhau.Name = "lb_QuenMatKhau";
            this.lb_QuenMatKhau.Size = new System.Drawing.Size(131, 20);
            this.lb_QuenMatKhau.TabIndex = 3;
            this.lb_QuenMatKhau.Text = "Quên mật khẩu?";
            this.lb_QuenMatKhau.Click += new System.EventHandler(this.lb_QuenMatKhau_Click);
            // 
            // tb_MK
            // 
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
            this.tb_MK.Location = new System.Drawing.Point(667, 306);
            this.tb_MK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MK.Name = "tb_MK";
            this.tb_MK.PasswordChar = '*';
            this.tb_MK.PlaceholderText = "Nhập mật khẩu...";
            this.tb_MK.SelectedText = "";
            this.tb_MK.Size = new System.Drawing.Size(654, 48);
            this.tb_MK.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(789, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(472, 173);
            this.label4.TabIndex = 30;
            this.label4.Text = "Đặt sân Cầu Lông, Pickle ball gì chưa người đẹp! Mình hẹn nhau pickleball nhé!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 30;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1371, 655);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 32;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.WaitOnLoad = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::GUI.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1029);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pt_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_MiniMaxmize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Close)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lb_DangNhap;
        private System.Windows.Forms.Label lb_TaiKhoan;
        private System.Windows.Forms.PictureBox pt_Close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pt_Hide;
        private System.Windows.Forms.PictureBox pt_MiniMaxmize;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lb_QuenMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox tb_MK;
        private Guna.UI2.WinForms.Guna2TextBox tb_SoDTorEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Loi;
        private Guna.UI2.WinForms.Guna2Button btn_DangNhap;
        private Guna.UI2.WinForms.Guna2Button btn_LoginGoogle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lb_Dangky;
        private Guna.UI2.WinForms.Guna2Button btn_ShowPassWord;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

        #endregion

 }



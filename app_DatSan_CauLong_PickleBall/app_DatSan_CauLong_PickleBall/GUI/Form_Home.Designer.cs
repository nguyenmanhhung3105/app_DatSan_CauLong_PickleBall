using System.Windows.Forms;

namespace GUI
{
    partial class Form_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public class DoubleBufferedFlowLayoutPanel : FlowLayoutPanel
        {
            public DoubleBufferedFlowLayoutPanel()
            {
                this.DoubleBuffered = true;
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pt_Hide = new System.Windows.Forms.PictureBox();
            this.pt_MiniMaxmize = new System.Windows.Forms.PictureBox();
            this.pt_Close = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.p_Ai = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpk_Ngay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_Ten_TK = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Search = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Home = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_DatSan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Danhgia = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Account = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pb_Menu = new System.Windows.Forms.PictureBox();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.sidebar = new GUI.Form_Home.DoubleBufferedFlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_MiniMaxmize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Close)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_Ai)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Menu)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pt_Hide);
            this.panel1.Controls.Add(this.pt_MiniMaxmize);
            this.panel1.Controls.Add(this.pt_Close);
            this.panel1.Location = new System.Drawing.Point(1413, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.panel1.Size = new System.Drawing.Size(116, 27);
            this.panel1.TabIndex = 5;
            // 
            // pt_Hide
            // 
            this.pt_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_Hide.Image = global::GUI.Properties.Resources.minimize_sign;
            this.pt_Hide.Location = new System.Drawing.Point(7, 3);
            this.pt_Hide.Name = "pt_Hide";
            this.pt_Hide.Size = new System.Drawing.Size(26, 22);
            this.pt_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_Hide.TabIndex = 11;
            this.pt_Hide.TabStop = false;
            // 
            // pt_MiniMaxmize
            // 
            this.pt_MiniMaxmize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_MiniMaxmize.Image = global::GUI.Properties.Resources.rounded_rectangle;
            this.pt_MiniMaxmize.Location = new System.Drawing.Point(41, 3);
            this.pt_MiniMaxmize.Name = "pt_MiniMaxmize";
            this.pt_MiniMaxmize.Size = new System.Drawing.Size(46, 22);
            this.pt_MiniMaxmize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_MiniMaxmize.TabIndex = 10;
            this.pt_MiniMaxmize.TabStop = false;
            // 
            // pt_Close
            // 
            this.pt_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_Close.Image = global::GUI.Properties.Resources.close;
            this.pt_Close.Location = new System.Drawing.Point(93, 3);
            this.pt_Close.Name = "pt_Close";
            this.pt_Close.Size = new System.Drawing.Size(20, 22);
            this.pt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_Close.TabIndex = 9;
            this.pt_Close.TabStop = false;
            this.pt_Close.Click += new System.EventHandler(this.pt_Close_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.p_Ai);
            this.guna2Panel1.Controls.Add(this.guna2GradientPanel1);
            this.guna2Panel1.Controls.Add(this.dtpk_Ngay);
            this.guna2Panel1.Controls.Add(this.txt_Ten_TK);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.pnLogo);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1537, 158);
            this.guna2Panel1.TabIndex = 6;
            // 
            // p_Ai
            // 
            this.p_Ai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p_Ai.FillColor = System.Drawing.Color.Transparent;
            this.p_Ai.Image = ((System.Drawing.Image)(resources.GetObject("p_Ai.Image")));
            this.p_Ai.ImageRotate = 0F;
            this.p_Ai.Location = new System.Drawing.Point(1413, 30);
            this.p_Ai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.p_Ai.Name = "p_Ai";
            this.p_Ai.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.p_Ai.Size = new System.Drawing.Size(106, 104);
            this.p_Ai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_Ai.TabIndex = 26;
            this.p_Ai.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(1230, 29);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(164, 96);
            this.guna2GradientPanel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kim cương";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hạng:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(86, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "10,000";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm:";
            // 
            // dtpk_Ngay
            // 
            this.dtpk_Ngay.BackColor = System.Drawing.Color.Transparent;
            this.dtpk_Ngay.BorderRadius = 10;
            this.dtpk_Ngay.BorderThickness = 2;
            this.dtpk_Ngay.Checked = true;
            this.dtpk_Ngay.FillColor = System.Drawing.Color.White;
            this.dtpk_Ngay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpk_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpk_Ngay.Location = new System.Drawing.Point(326, 38);
            this.dtpk_Ngay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpk_Ngay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpk_Ngay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpk_Ngay.Name = "dtpk_Ngay";
            this.dtpk_Ngay.ShadowDecoration.BorderRadius = 10;
            this.dtpk_Ngay.ShadowDecoration.Depth = 5;
            this.dtpk_Ngay.ShadowDecoration.Enabled = true;
            this.dtpk_Ngay.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.dtpk_Ngay.Size = new System.Drawing.Size(183, 29);
            this.dtpk_Ngay.TabIndex = 24;
            this.dtpk_Ngay.UseTransparentBackground = true;
            this.dtpk_Ngay.Value = new System.DateTime(2025, 3, 13, 2, 54, 20, 125);
            // 
            // txt_Ten_TK
            // 
            this.txt_Ten_TK.BackColor = System.Drawing.Color.Transparent;
            this.txt_Ten_TK.BorderColor = System.Drawing.Color.White;
            this.txt_Ten_TK.BorderRadius = 10;
            this.txt_Ten_TK.BorderThickness = 2;
            this.txt_Ten_TK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Ten_TK.DefaultText = "Nguyễn Hải Đăng";
            this.txt_Ten_TK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Ten_TK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Ten_TK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Ten_TK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Ten_TK.FillColor = System.Drawing.Color.Transparent;
            this.txt_Ten_TK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Ten_TK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Ten_TK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Ten_TK.Location = new System.Drawing.Point(326, 88);
            this.txt_Ten_TK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Ten_TK.Name = "txt_Ten_TK";
            this.txt_Ten_TK.PlaceholderText = "";
            this.txt_Ten_TK.ReadOnly = true;
            this.txt_Ten_TK.SelectedText = "";
            this.txt_Ten_TK.ShadowDecoration.BorderRadius = 10;
            this.txt_Ten_TK.ShadowDecoration.Depth = 5;
            this.txt_Ten_TK.ShadowDecoration.Enabled = true;
            this.txt_Ten_TK.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.txt_Ten_TK.Size = new System.Drawing.Size(183, 38);
            this.txt_Ten_TK.TabIndex = 22;
            this.txt_Ten_TK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(170, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Xin chào:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(170, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ngày:";
            // 
            // pnLogo
            // 
            this.pnLogo.BackgroundImage = global::GUI.Properties.Resources.logoPM;
            this.pnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(168, 158);
            this.pnLogo.TabIndex = 16;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btn_Search);
            this.guna2Panel2.Controls.Add(this.txt_Search);
            this.guna2Panel2.Location = new System.Drawing.Point(542, 38);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(705, 80);
            this.guna2Panel2.TabIndex = 25;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.Transparent;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Search.Location = new System.Drawing.Point(616, -2);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.Depth = 10;
            this.btn_Search.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Search.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1);
            this.btn_Search.Size = new System.Drawing.Size(86, 82);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.UseTransparentBackground = true;
            this.btn_Search.MouseEnter += new System.EventHandler(this.btn_Search_MouseEnter);
            this.btn_Search.MouseLeave += new System.EventHandler(this.btn_Search_MouseLeave);
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
            this.txt_Search.Location = new System.Drawing.Point(25, 22);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_Search.PlaceholderText = "";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(649, 38);
            this.txt_Search.TabIndex = 11;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Home.BackgroundImage")));
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Home.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_Home.BorderRadius = 10;
            this.btn_Home.BorderThickness = 2;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Home.FillColor = System.Drawing.Color.Transparent;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Home.ForeColor = System.Drawing.Color.LawnGreen;
            this.btn_Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Home.Location = new System.Drawing.Point(1, 2);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(166, 81);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "  Trang chủ";
            this.btn_Home.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.guna2PictureBox2);
            this.panel4.Controls.Add(this.btn_DatSan);
            this.panel4.Location = new System.Drawing.Point(0, 246);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 83);
            this.panel4.TabIndex = 24;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(10, 21);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(42, 46);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // btn_DatSan
            // 
            this.btn_DatSan.BackColor = System.Drawing.Color.Transparent;
            this.btn_DatSan.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_DatSan.BorderRadius = 20;
            this.btn_DatSan.BorderThickness = 2;
            this.btn_DatSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DatSan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DatSan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DatSan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DatSan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DatSan.FillColor = System.Drawing.Color.Transparent;
            this.btn_DatSan.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_DatSan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DatSan.Location = new System.Drawing.Point(2, 2);
            this.btn_DatSan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DatSan.Name = "btn_DatSan";
            this.btn_DatSan.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DatSan.Size = new System.Drawing.Size(164, 81);
            this.btn_DatSan.TabIndex = 0;
            this.btn_DatSan.Text = "Đặt sân";
            this.btn_DatSan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Danhgia
            // 
            this.btn_Danhgia.BackColor = System.Drawing.Color.Transparent;
            this.btn_Danhgia.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_Danhgia.BorderRadius = 20;
            this.btn_Danhgia.BorderThickness = 2;
            this.btn_Danhgia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Danhgia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Danhgia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Danhgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Danhgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Danhgia.FillColor = System.Drawing.Color.Transparent;
            this.btn_Danhgia.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Danhgia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Danhgia.Location = new System.Drawing.Point(2, 0);
            this.btn_Danhgia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Danhgia.Name = "btn_Danhgia";
            this.btn_Danhgia.Size = new System.Drawing.Size(161, 83);
            this.btn_Danhgia.TabIndex = 0;
            this.btn_Danhgia.Text = "Đánh giá";
            this.btn_Danhgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Account
            // 
            this.btn_Account.BackColor = System.Drawing.Color.Transparent;
            this.btn_Account.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_Account.BorderRadius = 20;
            this.btn_Account.BorderThickness = 2;
            this.btn_Account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Account.FillColor = System.Drawing.Color.Transparent;
            this.btn_Account.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Account.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Account.Location = new System.Drawing.Point(1, 0);
            this.btn_Account.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(165, 83);
            this.btn_Account.TabIndex = 0;
            this.btn_Account.Text = "Tài khoản";
            this.btn_Account.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.pb_Menu);
            this.panel6.Controls.Add(this.lbl_Menu);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(166, 83);
            this.panel6.TabIndex = 24;
            // 
            // pb_Menu
            // 
            this.pb_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Menu.Image = ((System.Drawing.Image)(resources.GetObject("pb_Menu.Image")));
            this.pb_Menu.Location = new System.Drawing.Point(0, 26);
            this.pb_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_Menu.Name = "pb_Menu";
            this.pb_Menu.Size = new System.Drawing.Size(49, 40);
            this.pb_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Menu.TabIndex = 0;
            this.pb_Menu.TabStop = false;
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Menu.Location = new System.Drawing.Point(62, 30);
            this.lbl_Menu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(72, 30);
            this.lbl_Menu.TabIndex = 0;
            this.lbl_Menu.Text = "Menu";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Transparent;
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Location = new System.Drawing.Point(0, 177);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.MaximumSize = new System.Drawing.Size(209, 692);
            this.sidebar.MinimumSize = new System.Drawing.Size(60, 692);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(168, 692);
            this.sidebar.TabIndex = 26;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(166, 83);
            this.panel8.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.guna2PictureBox1);
            this.panel7.Controls.Add(this.btn_Home);
            this.panel7.Location = new System.Drawing.Point(0, 123);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(166, 83);
            this.panel7.TabIndex = 26;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, 22);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(42, 46);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.guna2PictureBox3);
            this.panel2.Controls.Add(this.btn_Danhgia);
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 83);
            this.panel2.TabIndex = 25;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(10, 21);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(42, 46);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 3;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.guna2PictureBox4);
            this.panel9.Controls.Add(this.btn_Account);
            this.panel9.Location = new System.Drawing.Point(0, 492);
            this.panel9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(166, 83);
            this.panel9.TabIndex = 26;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(7, 20);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(42, 46);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 4;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            // 
            // pn_Main
            // 
            this.pn_Main.AllowDrop = true;
            this.pn_Main.AutoSize = true;
            this.pn_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_Main.Location = new System.Drawing.Point(213, 177);
            this.pn_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(1280, 600);
            this.pn_Main.TabIndex = 27;
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1539, 844);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Home_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form_Home_Scroll);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pt_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_MiniMaxmize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Close)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_Ai)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Menu)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pt_Hide;
        private System.Windows.Forms.PictureBox pt_MiniMaxmize;
        private System.Windows.Forms.PictureBox pt_Close;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Ten_TK;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpk_Ngay;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox p_Ai;
        private Guna.UI2.WinForms.Guna2Button btn_Home;
        private Guna.UI2.WinForms.Guna2Button btn_Danhgia;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btn_DatSan;
        private Guna.UI2.WinForms.Guna2Button btn_Account;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pb_Menu;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Panel pn_Main;
        private DoubleBufferedFlowLayoutPanel sidebar;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Panel panel2;
        private Panel panel8;
        private Panel panel7;
        private Panel panel9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
    }
}

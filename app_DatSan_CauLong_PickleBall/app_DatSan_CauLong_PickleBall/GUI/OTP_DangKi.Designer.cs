namespace GUI
{
    partial class OTP_DangKi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTP_DangKi));
            this.pn_OTP = new System.Windows.Forms.Panel();
            this.tb_OTP2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_OTP4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_OTP1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_OTP3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.lb_CauHoi = new System.Windows.Forms.Label();
            this.btn_OTPAgain = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Error = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_XacnhanOTP = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pn_OTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_OTP
            // 
            this.pn_OTP.Controls.Add(this.tb_OTP2);
            this.pn_OTP.Controls.Add(this.tb_OTP4);
            this.pn_OTP.Controls.Add(this.tb_OTP1);
            this.pn_OTP.Controls.Add(this.tb_OTP3);
            this.pn_OTP.Location = new System.Drawing.Point(61, 169);
            this.pn_OTP.Name = "pn_OTP";
            this.pn_OTP.Size = new System.Drawing.Size(448, 94);
            this.pn_OTP.TabIndex = 43;
            // 
            // tb_OTP2
            // 
            this.tb_OTP2.BorderRadius = 10;
            this.tb_OTP2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_OTP2.DefaultText = "";
            this.tb_OTP2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_OTP2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_OTP2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_OTP2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_OTP2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_OTP2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_OTP2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_OTP2.Location = new System.Drawing.Point(143, 13);
            this.tb_OTP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_OTP2.Name = "tb_OTP2";
            this.tb_OTP2.PlaceholderText = "";
            this.tb_OTP2.SelectedText = "";
            this.tb_OTP2.Size = new System.Drawing.Size(72, 77);
            this.tb_OTP2.TabIndex = 1;
            this.tb_OTP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_OTP4
            // 
            this.tb_OTP4.BorderRadius = 10;
            this.tb_OTP4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_OTP4.DefaultText = "";
            this.tb_OTP4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_OTP4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_OTP4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_OTP4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_OTP4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_OTP4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_OTP4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_OTP4.Location = new System.Drawing.Point(335, 13);
            this.tb_OTP4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_OTP4.Name = "tb_OTP4";
            this.tb_OTP4.PlaceholderText = "";
            this.tb_OTP4.SelectedText = "";
            this.tb_OTP4.Size = new System.Drawing.Size(72, 77);
            this.tb_OTP4.TabIndex = 3;
            this.tb_OTP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_OTP1
            // 
            this.tb_OTP1.BorderRadius = 10;
            this.tb_OTP1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_OTP1.DefaultText = "";
            this.tb_OTP1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_OTP1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_OTP1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_OTP1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_OTP1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_OTP1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_OTP1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_OTP1.Location = new System.Drawing.Point(44, 13);
            this.tb_OTP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_OTP1.Name = "tb_OTP1";
            this.tb_OTP1.PlaceholderText = "";
            this.tb_OTP1.SelectedText = "";
            this.tb_OTP1.Size = new System.Drawing.Size(72, 77);
            this.tb_OTP1.TabIndex = 0;
            this.tb_OTP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_OTP3
            // 
            this.tb_OTP3.BorderRadius = 10;
            this.tb_OTP3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_OTP3.DefaultText = "";
            this.tb_OTP3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_OTP3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_OTP3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_OTP3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_OTP3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_OTP3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_OTP3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_OTP3.Location = new System.Drawing.Point(242, 13);
            this.tb_OTP3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_OTP3.Name = "tb_OTP3";
            this.tb_OTP3.PlaceholderText = "";
            this.tb_OTP3.SelectedText = "";
            this.tb_OTP3.Size = new System.Drawing.Size(72, 77);
            this.tb_OTP3.TabIndex = 2;
            this.tb_OTP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.Location = new System.Drawing.Point(248, 263);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(71, 29);
            this.lblCountDown.TabIndex = 44;
            this.lblCountDown.Text = "05:00";
            this.lblCountDown.Visible = false;
            // 
            // lb_CauHoi
            // 
            this.lb_CauHoi.AutoSize = true;
            this.lb_CauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CauHoi.Location = new System.Drawing.Point(-7, 459);
            this.lb_CauHoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CauHoi.Name = "lb_CauHoi";
            this.lb_CauHoi.Size = new System.Drawing.Size(283, 25);
            this.lb_CauHoi.TabIndex = 46;
            this.lb_CauHoi.Text = "Bạn chưa nhận được mã code?";
            // 
            // btn_OTPAgain
            // 
            this.btn_OTPAgain.BorderRadius = 10;
            this.btn_OTPAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OTPAgain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_OTPAgain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_OTPAgain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_OTPAgain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_OTPAgain.Enabled = false;
            this.btn_OTPAgain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_OTPAgain.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OTPAgain.ForeColor = System.Drawing.Color.White;
            this.btn_OTPAgain.Location = new System.Drawing.Point(317, 444);
            this.btn_OTPAgain.Name = "btn_OTPAgain";
            this.btn_OTPAgain.Size = new System.Drawing.Size(238, 51);
            this.btn_OTPAgain.TabIndex = 47;
            this.btn_OTPAgain.Text = "Gửi lại mã OTP";
            this.btn_OTPAgain.Click += new System.EventHandler(this.btn_OTPAgain_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 169);
            this.label1.TabIndex = 48;
            this.label1.Text = "Đã gửi OTP qua email, vui lòng kiểm tra và nhập vào bên dưới";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_Error
            // 
            this.lb_Error.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Error.ForeColor = System.Drawing.Color.Red;
            this.lb_Error.Location = new System.Drawing.Point(33, 266);
            this.lb_Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Error.Name = "lb_Error";
            this.lb_Error.Size = new System.Drawing.Size(532, 91);
            this.lb_Error.TabIndex = 49;
            this.lb_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_XacnhanOTP
            // 
            this.btn_XacnhanOTP.BorderRadius = 10;
            this.btn_XacnhanOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XacnhanOTP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XacnhanOTP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XacnhanOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XacnhanOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XacnhanOTP.Enabled = false;
            this.btn_XacnhanOTP.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_XacnhanOTP.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacnhanOTP.ForeColor = System.Drawing.Color.White;
            this.btn_XacnhanOTP.Location = new System.Drawing.Point(125, 360);
            this.btn_XacnhanOTP.Name = "btn_XacnhanOTP";
            this.btn_XacnhanOTP.Size = new System.Drawing.Size(333, 51);
            this.btn_XacnhanOTP.TabIndex = 50;
            this.btn_XacnhanOTP.Text = "Xác nhận OTP";
            this.btn_XacnhanOTP.Click += new System.EventHandler(this.btn_XacnhanOTP_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageRotate = 0F;
            this.btn_close.Location = new System.Drawing.Point(0, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_close.Size = new System.Drawing.Size(64, 64);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 51;
            this.btn_close.TabStop = false;
            this.btn_close.UseTransparentBackground = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // OTP_DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_XacnhanOTP);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.lb_Error);
            this.Controls.Add(this.pn_OTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OTPAgain);
            this.Controls.Add(this.lb_CauHoi);
            this.Name = "OTP_DangKi";
            this.Size = new System.Drawing.Size(579, 517);
            this.pn_OTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_OTP;
        private Guna.UI2.WinForms.Guna2TextBox tb_OTP2;
        private Guna.UI2.WinForms.Guna2TextBox tb_OTP4;
        private Guna.UI2.WinForms.Guna2TextBox tb_OTP1;
        private Guna.UI2.WinForms.Guna2TextBox tb_OTP3;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label lb_CauHoi;
        private Guna.UI2.WinForms.Guna2Button btn_OTPAgain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Error;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btn_XacnhanOTP;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn_close;
    }
}

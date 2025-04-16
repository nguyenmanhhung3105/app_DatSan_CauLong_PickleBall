namespace GUI
{
    partial class GiaSan_SanBiDat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaSan_SanBiDat));
            this.btn_XemGiaSan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_XemSanBiDat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Back = new Guna.UI2.WinForms.Guna2Button();
            this.pdt_NgayDat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dt_Dung_Cu_Thue = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Dung_Cu_Thue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XemGiaSan
            // 
            this.btn_XemGiaSan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XemGiaSan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XemGiaSan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XemGiaSan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XemGiaSan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_XemGiaSan.ForeColor = System.Drawing.Color.White;
            this.btn_XemGiaSan.Location = new System.Drawing.Point(530, 60);
            this.btn_XemGiaSan.Name = "btn_XemGiaSan";
            this.btn_XemGiaSan.Size = new System.Drawing.Size(180, 45);
            this.btn_XemGiaSan.TabIndex = 0;
            this.btn_XemGiaSan.Text = "Xem giá sân";
            this.btn_XemGiaSan.Click += new System.EventHandler(this.btn_XemGiaSan_Click);
            // 
            // btn_XemSanBiDat
            // 
            this.btn_XemSanBiDat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XemSanBiDat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XemSanBiDat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XemSanBiDat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XemSanBiDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_XemSanBiDat.ForeColor = System.Drawing.Color.White;
            this.btn_XemSanBiDat.Location = new System.Drawing.Point(891, 60);
            this.btn_XemSanBiDat.Name = "btn_XemSanBiDat";
            this.btn_XemSanBiDat.Size = new System.Drawing.Size(180, 45);
            this.btn_XemSanBiDat.TabIndex = 1;
            this.btn_XemSanBiDat.Text = "Xem sân bị đặt";
            this.btn_XemSanBiDat.Click += new System.EventHandler(this.btn_XemSanBiDat_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Animated = true;
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BorderRadius = 10;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Back.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(58, 34);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.ShadowDecoration.Depth = 15;
            this.btn_Back.ShadowDecoration.Enabled = true;
            this.btn_Back.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.btn_Back.Size = new System.Drawing.Size(302, 97);
            this.btn_Back.TabIndex = 42;
            this.btn_Back.Text = "Trở lại Đặt lịch";
            this.btn_Back.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Back.UseTransparentBackground = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pdt_NgayDat
            // 
            this.pdt_NgayDat.BackColor = System.Drawing.Color.Transparent;
            this.pdt_NgayDat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pdt_NgayDat.BorderRadius = 10;
            this.pdt_NgayDat.BorderThickness = 1;
            this.pdt_NgayDat.Checked = true;
            this.pdt_NgayDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdt_NgayDat.FillColor = System.Drawing.Color.White;
            this.pdt_NgayDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pdt_NgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.pdt_NgayDat.Location = new System.Drawing.Point(1158, 69);
            this.pdt_NgayDat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.pdt_NgayDat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.pdt_NgayDat.Name = "pdt_NgayDat";
            this.pdt_NgayDat.Size = new System.Drawing.Size(265, 36);
            this.pdt_NgayDat.TabIndex = 45;
            this.pdt_NgayDat.Value = new System.DateTime(2025, 3, 16, 0, 56, 39, 902);
            this.pdt_NgayDat.ValueChanged += new System.EventHandler(this.pdt_NgayDat_ValueChanged);
            // 
            // dt_Dung_Cu_Thue
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dt_Dung_Cu_Thue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_Dung_Cu_Thue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_Dung_Cu_Thue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_Dung_Cu_Thue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_Dung_Cu_Thue.ColumnHeadersHeight = 50;
            this.dt_Dung_Cu_Thue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_Dung_Cu_Thue.DefaultCellStyle = dataGridViewCellStyle3;
            this.dt_Dung_Cu_Thue.GridColor = System.Drawing.Color.Black;
            this.dt_Dung_Cu_Thue.Location = new System.Drawing.Point(3, 170);
            this.dt_Dung_Cu_Thue.Name = "dt_Dung_Cu_Thue";
            this.dt_Dung_Cu_Thue.ReadOnly = true;
            this.dt_Dung_Cu_Thue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_Dung_Cu_Thue.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_Dung_Cu_Thue.RowHeadersVisible = false;
            this.dt_Dung_Cu_Thue.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dt_Dung_Cu_Thue.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dt_Dung_Cu_Thue.RowTemplate.Height = 24;
            this.dt_Dung_Cu_Thue.Size = new System.Drawing.Size(1594, 500);
            this.dt_Dung_Cu_Thue.TabIndex = 46;
            this.dt_Dung_Cu_Thue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dt_Dung_Cu_Thue.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dt_Dung_Cu_Thue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dt_Dung_Cu_Thue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dt_Dung_Cu_Thue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dt_Dung_Cu_Thue.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dt_Dung_Cu_Thue.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dt_Dung_Cu_Thue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dt_Dung_Cu_Thue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dt_Dung_Cu_Thue.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Dung_Cu_Thue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dt_Dung_Cu_Thue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dt_Dung_Cu_Thue.ThemeStyle.HeaderStyle.Height = 50;
            this.dt_Dung_Cu_Thue.ThemeStyle.ReadOnly = true;
            this.dt_Dung_Cu_Thue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dt_Dung_Cu_Thue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dt_Dung_Cu_Thue.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Dung_Cu_Thue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dt_Dung_Cu_Thue.ThemeStyle.RowsStyle.Height = 24;
            this.dt_Dung_Cu_Thue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dt_Dung_Cu_Thue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(58, 34);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(89, 97);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 43;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // GiaSan_SanBiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dt_Dung_Cu_Thue);
            this.Controls.Add(this.pdt_NgayDat);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_XemSanBiDat);
            this.Controls.Add(this.btn_XemGiaSan);
            this.Name = "GiaSan_SanBiDat";
            this.Size = new System.Drawing.Size(1600, 750);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Dung_Cu_Thue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_XemGiaSan;
        private Guna.UI2.WinForms.Guna2Button btn_XemSanBiDat;
        private Guna.UI2.WinForms.Guna2Button btn_Back;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker pdt_NgayDat;
        private Guna.UI2.WinForms.Guna2DataGridView dt_Dung_Cu_Thue;
    }
}

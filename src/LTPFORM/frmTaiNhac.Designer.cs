namespace WindowsFormsApp1
{
    partial class frmTaiNhac
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLink = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenVideo = new System.Windows.Forms.Label();
            this.btnLink = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnTaiXuong = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTai = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chknhac = new Guna.UI2.WinForms.Guna2CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtTenFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUrl = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtDowloadFilm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnTaiXuong.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẢI NHẠC TỪ YOUTUBE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập link ";
            // 
            // txtLink
            // 
            this.txtLink.Animated = true;
            this.txtLink.AutoRoundedCorners = true;
            this.txtLink.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtLink.BorderRadius = 17;
            this.txtLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLink.DefaultText = "";
            this.txtLink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLink.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLink.ForeColor = System.Drawing.Color.Black;
            this.txtLink.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLink.Location = new System.Drawing.Point(133, 54);
            this.txtLink.Name = "txtLink";
            this.txtLink.PlaceholderText = "Link copy từ youtube hạn ché link blit.lyv.v";
            this.txtLink.SelectedText = "";
            this.txtLink.Size = new System.Drawing.Size(297, 36);
            this.txtLink.TabIndex = 2;
            // 
            // lblTenVideo
            // 
            this.lblTenVideo.AutoSize = true;
            this.lblTenVideo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenVideo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTenVideo.Location = new System.Drawing.Point(12, 98);
            this.lblTenVideo.Name = "lblTenVideo";
            this.lblTenVideo.Size = new System.Drawing.Size(143, 17);
            this.lblTenVideo.TabIndex = 3;
            this.lblTenVideo.Text = "(*) Tên video kiểm tra";
            // 
            // btnLink
            // 
            this.btnLink.Animated = true;
            this.btnLink.BorderRadius = 8;
            this.btnLink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLink.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btnLink.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.btnLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.ForeColor = System.Drawing.Color.White;
            this.btnLink.Location = new System.Drawing.Point(452, 54);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(180, 36);
            this.btnLink.TabIndex = 4;
            this.btnLink.Text = "Kiểm tra";
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // pnTaiXuong
            // 
            this.pnTaiXuong.Controls.Add(this.txtDowloadFilm);
            this.pnTaiXuong.Controls.Add(this.btnTai);
            this.pnTaiXuong.Controls.Add(this.chknhac);
            this.pnTaiXuong.Controls.Add(this.progressBar1);
            this.pnTaiXuong.Controls.Add(this.txtTenFile);
            this.pnTaiXuong.Controls.Add(this.label4);
            this.pnTaiXuong.Controls.Add(this.btnUrl);
            this.pnTaiXuong.Controls.Add(this.txtUrl);
            this.pnTaiXuong.Controls.Add(this.label3);
            this.pnTaiXuong.Enabled = false;
            this.pnTaiXuong.Location = new System.Drawing.Point(12, 169);
            this.pnTaiXuong.Name = "pnTaiXuong";
            this.pnTaiXuong.Size = new System.Drawing.Size(636, 272);
            this.pnTaiXuong.TabIndex = 7;
            // 
            // btnTai
            // 
            this.btnTai.Animated = true;
            this.btnTai.BorderRadius = 8;
            this.btnTai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btnTai.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.btnTai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTai.ForeColor = System.Drawing.Color.White;
            this.btnTai.Location = new System.Drawing.Point(79, 171);
            this.btnTai.Name = "btnTai";
            this.btnTai.Size = new System.Drawing.Size(180, 36);
            this.btnTai.TabIndex = 13;
            this.btnTai.Text = "Tải ngay";
            this.btnTai.Click += new System.EventHandler(this.btnTai_Click);
            // 
            // chknhac
            // 
            this.chknhac.AutoSize = true;
            this.chknhac.BackColor = System.Drawing.SystemColors.Window;
            this.chknhac.Checked = true;
            this.chknhac.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chknhac.CheckedState.BorderRadius = 0;
            this.chknhac.CheckedState.BorderThickness = 0;
            this.chknhac.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chknhac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chknhac.Enabled = false;
            this.chknhac.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.chknhac.Location = new System.Drawing.Point(119, 107);
            this.chknhac.Name = "chknhac";
            this.chknhac.Size = new System.Drawing.Size(140, 29);
            this.chknhac.TabIndex = 12;
            this.chknhac.Text = "File âm nhạc";
            this.chknhac.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chknhac.UncheckedState.BorderRadius = 0;
            this.chknhac.UncheckedState.BorderThickness = 0;
            this.chknhac.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chknhac.UseVisualStyleBackColor = false;
            this.chknhac.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 142);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(575, 23);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // txtTenFile
            // 
            this.txtTenFile.Animated = true;
            this.txtTenFile.AutoRoundedCorners = true;
            this.txtTenFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTenFile.BorderRadius = 17;
            this.txtTenFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenFile.DefaultText = "";
            this.txtTenFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenFile.ForeColor = System.Drawing.Color.Black;
            this.txtTenFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenFile.Location = new System.Drawing.Point(120, 65);
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.PlaceholderText = "Tắt Unikey và tránh thêm tiền tố Mp3 Mp4";
            this.txtTenFile.SelectedText = "";
            this.txtTenFile.Size = new System.Drawing.Size(297, 36);
            this.txtTenFile.TabIndex = 10;
            this.txtTenFile.TextChanged += new System.EventHandler(this.txtTenFile_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên Lưu Trữ";
            // 
            // btnUrl
            // 
            this.btnUrl.Animated = true;
            this.btnUrl.BorderRadius = 8;
            this.btnUrl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUrl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUrl.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btnUrl.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.btnUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrl.ForeColor = System.Drawing.Color.White;
            this.btnUrl.Location = new System.Drawing.Point(439, 11);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(180, 36);
            this.btnUrl.TabIndex = 8;
            this.btnUrl.Text = "Chọn đường dẫn";
            this.btnUrl.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Animated = true;
            this.txtUrl.AutoRoundedCorners = true;
            this.txtUrl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtUrl.BorderRadius = 17;
            this.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.DefaultText = "";
            this.txtUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrl.ForeColor = System.Drawing.Color.Black;
            this.txtUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrl.Location = new System.Drawing.Point(120, 11);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PlaceholderText = "Nhớ kiểm tra đường dẫn muốn lưu";
            this.txtUrl.SelectedText = "";
            this.txtUrl.Size = new System.Drawing.Size(297, 36);
            this.txtUrl.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập link ";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BorderRadius = 8;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(12, 131);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(202, 32);
            this.guna2GradientButton1.TabIndex = 9;
            this.guna2GradientButton1.Text = "Chuyển đổi sang MP3 file";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // txtDowloadFilm
            // 
            this.txtDowloadFilm.Animated = true;
            this.txtDowloadFilm.BorderRadius = 8;
            this.txtDowloadFilm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDowloadFilm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtDowloadFilm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtDowloadFilm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtDowloadFilm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtDowloadFilm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.txtDowloadFilm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.txtDowloadFilm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtDowloadFilm.ForeColor = System.Drawing.Color.White;
            this.txtDowloadFilm.Location = new System.Drawing.Point(326, 171);
            this.txtDowloadFilm.Name = "txtDowloadFilm";
            this.txtDowloadFilm.Size = new System.Drawing.Size(180, 36);
            this.txtDowloadFilm.TabIndex = 14;
            this.txtDowloadFilm.Text = "Tải phim";
            this.txtDowloadFilm.Click += new System.EventHandler(this.txtDowloadFilm_Click);
            // 
            // frmTaiNhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 453);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.pnTaiXuong);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.lblTenVideo);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaiNhac";
            this.Text = "frmTaiNhac";
            this.Load += new System.EventHandler(this.frmTaiNhac_Load);
            this.pnTaiXuong.ResumeLayout(false);
            this.pnTaiXuong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtLink;
        private System.Windows.Forms.Label lblTenVideo;
        private Guna.UI2.WinForms.Guna2GradientButton btnLink;
        private Guna.UI2.WinForms.Guna2Panel pnTaiXuong;
        private Guna.UI2.WinForms.Guna2TextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnUrl;
        private Guna.UI2.WinForms.Guna2CheckBox chknhac;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenFile;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton btnTai;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton txtDowloadFilm;
    }
}
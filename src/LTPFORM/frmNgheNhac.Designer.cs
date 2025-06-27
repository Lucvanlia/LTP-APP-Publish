namespace WindowsFormsApp1
{
    partial class frmNgheNhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNgheNhac));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pntop = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnYoutube = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnWin = new Guna.UI2.WinForms.Guna2Button();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pntop
            // 
            this.pntop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pntop.Controls.Add(this.guna2PictureBox1);
            this.pntop.Controls.Add(this.guna2GradientPanel1);
            this.pntop.Controls.Add(this.guna2HtmlLabel1);
            this.pntop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.pntop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.pntop.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.pntop.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.pntop.Location = new System.Drawing.Point(0, 0);
            this.pntop.Name = "pntop";
            this.pntop.Size = new System.Drawing.Size(800, 64);
            this.pntop.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(736, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(52, 45);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 66);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(100, 383);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(90, 27);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "LTT - APP";
            // 
            // btnYoutube
            // 
            this.btnYoutube.Animated = true;
            this.btnYoutube.BackColor = System.Drawing.Color.Transparent;
            this.btnYoutube.BorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnYoutube.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnYoutube.CustomImages.CheckedImage = global::WindowsFormsApp1.Properties.Resources.icons8_youtube_48;
            this.btnYoutube.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnYoutube.CustomImages.ImageSize = new System.Drawing.Size(48, 48);
            this.btnYoutube.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYoutube.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYoutube.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYoutube.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYoutube.FillColor = System.Drawing.Color.Transparent;
            this.btnYoutube.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYoutube.ForeColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnYoutube.Location = new System.Drawing.Point(25, 4);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(69, 61);
            this.btnYoutube.TabIndex = 2;
            this.btnYoutube.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnWin);
            this.guna2Panel1.Controls.Add(this.btnYoutube);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 66);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(123, 383);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnWin
            // 
            this.btnWin.Animated = true;
            this.btnWin.BackColor = System.Drawing.Color.Transparent;
            this.btnWin.BorderColor = System.Drawing.Color.Transparent;
            this.btnWin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnWin.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnWin.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnWin.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnWin.CustomImages.CheckedImage = global::WindowsFormsApp1.Properties.Resources.icons8_windows_os_48;
            this.btnWin.CustomImages.HoveredImage = global::WindowsFormsApp1.Properties.Resources.icons8_windows_os_48;
            this.btnWin.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnWin.CustomImages.ImageSize = new System.Drawing.Size(48, 48);
            this.btnWin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWin.FillColor = System.Drawing.Color.Transparent;
            this.btnWin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWin.ForeColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnWin.Location = new System.Drawing.Point(25, 95);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(69, 61);
            this.btnWin.TabIndex = 3;
            this.btnWin.UseTransparentBackground = true;
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(129, 66);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(671, 383);
            this.pnMain.TabIndex = 4;
            // 
            // frmNgheNhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pntop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmNgheNhac";
            this.Text = "v";
            this.pntop.ResumeLayout(false);
            this.pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnYoutube;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pntop;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnWin;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
    }
}
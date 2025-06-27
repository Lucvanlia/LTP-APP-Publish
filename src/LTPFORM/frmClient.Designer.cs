namespace WindowsFormsApp1
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnYoutube = new Guna.UI2.WinForms.Guna2Button();
            this.btnWin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.timerCheckInternet = new System.Windows.Forms.Timer(this.components);
            this.picIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ComboBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnYoutube);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnWin);
            resources.ApplyResources(this.guna2CustomGradientPanel1, "guna2CustomGradientPanel1");
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Enabled = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.guna2ComboBox1, "guna2ComboBox1");
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.Items.AddRange(new object[] {
            resources.GetString("guna2ComboBox1.Items"),
            resources.GetString("guna2ComboBox1.Items1")});
            this.guna2ComboBox1.Name = "guna2ComboBox1";
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
            this.btnYoutube.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnYoutube.CustomImages.ImageSize = new System.Drawing.Size(48, 48);
            this.btnYoutube.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYoutube.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYoutube.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYoutube.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYoutube.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnYoutube, "btnYoutube");
            this.btnYoutube.ForeColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnYoutube.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.UseTransparentBackground = true;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
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
            this.btnWin.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnWin.CustomImages.ImageSize = new System.Drawing.Size(48, 48);
            this.btnWin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWin.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnWin, "btnWin");
            this.btnWin.ForeColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnWin.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnWin.Name = "btnWin";
            this.btnWin.UseTransparentBackground = true;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.picIcon);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblTrangThai);
            this.guna2CustomGradientPanel2.Controls.Add(this.label1);
            resources.ApplyResources(this.guna2CustomGradientPanel2, "guna2CustomGradientPanel2");
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.BorderRadius = 1;
            this.guna2CustomGradientPanel2.ShadowDecoration.Depth = 55;
            this.guna2CustomGradientPanel2.ShadowDecoration.Enabled = true;
            // 
            // lblTrangThai
            // 
            resources.ApplyResources(this.lblTrangThai, "lblTrangThai");
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.ForeColor = System.Drawing.Color.White;
            this.lblTrangThai.Name = "lblTrangThai";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnMain
            // 
            resources.ApplyResources(this.pnMain, "pnMain");
            this.pnMain.Name = "pnMain";
            // 
            // timerCheckInternet
            // 
            this.timerCheckInternet.Interval = 10000;
            this.timerCheckInternet.Tick += new System.EventHandler(this.timerCheckInternet_Tick_1);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picIcon, "picIcon");
            this.picIcon.ImageRotate = 0F;
            this.picIcon.InitialImage = global::WindowsFormsApp1.Properties.Resources.icon_success;
            this.picIcon.Name = "picIcon";
            this.picIcon.TabStop = false;
            this.picIcon.UseTransparentBackground = true;
            // 
            // frmClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "frmClient";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btnYoutube;
        private Guna.UI2.WinForms.Guna2Button btnWin;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private System.Windows.Forms.Label lblTrangThai;
        private Guna.UI2.WinForms.Guna2PictureBox picIcon;
        private System.Windows.Forms.Timer timerCheckInternet;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label2;
    }
}
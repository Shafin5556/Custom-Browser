namespace DIU_Browser
{
    partial class frmBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Back_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.ForwardButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.RefreshButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.HomeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardButton)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(-2, 74);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1194, 548);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click_1);
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.Transparent;
            this.Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("Back_Button.Image")));
            this.Back_Button.ImageActive = null;
            this.Back_Button.Location = new System.Drawing.Point(15, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(25, 25);
            this.Back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back_Button.TabIndex = 1;
            this.Back_Button.TabStop = false;
            this.Back_Button.Zoom = 10;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.Transparent;
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.ImageActive = null;
            this.ForwardButton.InitialImage = null;
            this.ForwardButton.Location = new System.Drawing.Point(65, 12);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(25, 25);
            this.ForwardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ForwardButton.TabIndex = 2;
            this.ForwardButton.TabStop = false;
            this.ForwardButton.Zoom = 10;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel2);
            this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-2, -1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1194, 74);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel4.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.bunifuImageButton6);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(1132, 15);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(53, 50);
            this.bunifuGradientPanel4.TabIndex = 5;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.InitialImage = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(14, 13);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 4;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel3.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.SearchBar);
            this.bunifuGradientPanel3.Controls.Add(this.SearchButton);
            this.bunifuGradientPanel3.Controls.Add(this.RefreshButton);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(180, 15);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(945, 50);
            this.bunifuGradientPanel3.TabIndex = 5;
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBar.BackgroundImage")));
            this.SearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBar.DefaultText = "";
            this.SearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.DisabledState.Parent = this.SearchBar;
            this.SearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.FocusedState.Parent = this.SearchBar;
            this.SearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.HoverState.Parent = this.SearchBar;
            this.SearchBar.Location = new System.Drawing.Point(63, 9);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.PasswordChar = '\0';
            this.SearchBar.PlaceholderText = "";
            this.SearchBar.SelectedText = "";
            this.SearchBar.ShadowDecoration.Parent = this.SearchBar;
            this.SearchBar.Size = new System.Drawing.Size(827, 30);
            this.SearchBar.TabIndex = 4;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            this.SearchBar.Enter += new System.EventHandler(this.SearchBar_Enter);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageActive = null;
            this.SearchButton.InitialImage = null;
            this.SearchButton.Location = new System.Drawing.Point(905, 11);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(25, 25);
            this.SearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchButton.TabIndex = 5;
            this.SearchButton.TabStop = false;
            this.SearchButton.Zoom = 10;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageActive = null;
            this.RefreshButton.InitialImage = null;
            this.RefreshButton.Location = new System.Drawing.Point(17, 11);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(25, 25);
            this.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Zoom = 10;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.HomeButton);
            this.bunifuGradientPanel2.Controls.Add(this.Back_Button);
            this.bunifuGradientPanel2.Controls.Add(this.ForwardButton);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(10, 14);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(160, 50);
            this.bunifuGradientPanel2.TabIndex = 4;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageActive = null;
            this.HomeButton.InitialImage = null;
            this.HomeButton.Location = new System.Drawing.Point(116, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(25, 25);
            this.HomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeButton.TabIndex = 3;
            this.HomeButton.TabStop = false;
            this.HomeButton.Zoom = 10;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.bunifuGradientPanel2;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.bunifuGradientPanel3;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this.bunifuGradientPanel4;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 25;
            this.bunifuElipse4.TargetControl = this.SearchBar;
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 622);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.webView21);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DIU BROWSER";
            this.Load += new System.EventHandler(this.frmBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardButton)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Bunifu.Framework.UI.BunifuImageButton Back_Button;
        private Bunifu.Framework.UI.BunifuImageButton ForwardButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton HomeButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuImageButton RefreshButton;
        private Bunifu.Framework.UI.BunifuImageButton SearchButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
    }
}
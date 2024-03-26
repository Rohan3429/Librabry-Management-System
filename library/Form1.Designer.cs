namespace library
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.wrongPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(371, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(43, 36);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(148, 126);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(156, 149);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // Username
            // 
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username.HintForeColor = System.Drawing.Color.Empty;
            this.Username.HintText = "Username";
            this.Username.isPassword = false;
            this.Username.LineFocusedColor = System.Drawing.Color.Black;
            this.Username.LineIdleColor = System.Drawing.Color.Black;
            this.Username.LineMouseHoverColor = System.Drawing.Color.Black;
            this.Username.LineThickness = 3;
            this.Username.Location = new System.Drawing.Point(76, 313);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(287, 44);
            this.Username.TabIndex = 6;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.HintForeColor = System.Drawing.Color.Empty;
            this.Password.HintText = "Password";
            this.Password.isPassword = false;
            this.Password.LineFocusedColor = System.Drawing.Color.Black;
            this.Password.LineIdleColor = System.Drawing.Color.Black;
            this.Password.LineMouseHoverColor = System.Drawing.Color.Black;
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(76, 390);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(287, 44);
            this.Password.TabIndex = 7;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.OnValueChanged += new System.EventHandler(this.Password_OnValueChanged);
            // 
            // Login
            // 
            this.Login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login.BorderRadius = 0;
            this.Login.ButtonText = "Login";
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.DisabledColor = System.Drawing.Color.Gray;
            this.Login.Iconcolor = System.Drawing.Color.Transparent;
            this.Login.Iconimage = null;
            this.Login.Iconimage_right = null;
            this.Login.Iconimage_right_Selected = null;
            this.Login.Iconimage_Selected = null;
            this.Login.IconMarginLeft = 0;
            this.Login.IconMarginRight = 0;
            this.Login.IconRightVisible = true;
            this.Login.IconRightZoom = 0D;
            this.Login.IconVisible = true;
            this.Login.IconZoom = 90D;
            this.Login.IsTab = false;
            this.Login.Location = new System.Drawing.Point(76, 488);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login.Name = "Login";
            this.Login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.Login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.Login.OnHoverTextColor = System.Drawing.Color.White;
            this.Login.selected = false;
            this.Login.Size = new System.Drawing.Size(287, 59);
            this.Login.TabIndex = 8;
            this.Login.Text = "Login";
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login.Textcolor = System.Drawing.Color.White;
            this.Login.TextFont = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // wrongPassword
            // 
            this.wrongPassword.AutoSize = true;
            this.wrongPassword.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongPassword.ForeColor = System.Drawing.Color.Red;
            this.wrongPassword.Location = new System.Drawing.Point(82, 449);
            this.wrongPassword.Name = "wrongPassword";
            this.wrongPassword.Size = new System.Drawing.Size(298, 20);
            this.wrongPassword.TabIndex = 9;
            this.wrongPassword.Text = "Please Enter Right username and Password";
            this.wrongPassword.UseWaitCursor = true;
            this.wrongPassword.Visible = false;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 573);
            this.Controls.Add(this.wrongPassword);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private Bunifu.Framework.UI.BunifuFlatButton Login;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label wrongPassword;
    }
}


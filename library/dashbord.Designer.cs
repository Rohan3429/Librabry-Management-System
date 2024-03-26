namespace library
{
    partial class dashbord1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReturnButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.issuedbook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Booksbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.studentbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dashboardBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.returnbook1 = new library.returnbook();
            this.issudbook1 = new library.issudbook();
            this.dasbord1 = new library.dasbord();
            this.student1 = new library.student();
            this.bookadding1 = new library.bookadding();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 72);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::library.Properties.Resources.logo;
            this.pictureBox6.Location = new System.Drawing.Point(18, -12);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 84);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.ReturnButton);
            this.panel2.Controls.Add(this.issuedbook);
            this.panel2.Controls.Add(this.Booksbtn);
            this.panel2.Controls.Add(this.studentbtn);
            this.panel2.Controls.Add(this.dashboardBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 505);
            this.panel2.TabIndex = 1;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnButton.BorderRadius = 0;
            this.ReturnButton.ButtonText = "Return Book";
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnButton.DisabledColor = System.Drawing.Color.Gray;
            this.ReturnButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ReturnButton.Iconimage = null;
            this.ReturnButton.Iconimage_right = null;
            this.ReturnButton.Iconimage_right_Selected = null;
            this.ReturnButton.Iconimage_Selected = null;
            this.ReturnButton.IconMarginLeft = 0;
            this.ReturnButton.IconMarginRight = 0;
            this.ReturnButton.IconRightVisible = true;
            this.ReturnButton.IconRightZoom = 0D;
            this.ReturnButton.IconVisible = true;
            this.ReturnButton.IconZoom = 90D;
            this.ReturnButton.IsTab = false;
            this.ReturnButton.Location = new System.Drawing.Point(18, 381);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.ReturnButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ReturnButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ReturnButton.selected = false;
            this.ReturnButton.Size = new System.Drawing.Size(150, 38);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Return Book";
            this.ReturnButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReturnButton.Textcolor = System.Drawing.Color.White;
            this.ReturnButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // issuedbook
            // 
            this.issuedbook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.issuedbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.issuedbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.issuedbook.BorderRadius = 0;
            this.issuedbook.ButtonText = "Issued Book";
            this.issuedbook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issuedbook.DisabledColor = System.Drawing.Color.Gray;
            this.issuedbook.Iconcolor = System.Drawing.Color.Transparent;
            this.issuedbook.Iconimage = null;
            this.issuedbook.Iconimage_right = null;
            this.issuedbook.Iconimage_right_Selected = null;
            this.issuedbook.Iconimage_Selected = null;
            this.issuedbook.IconMarginLeft = 0;
            this.issuedbook.IconMarginRight = 0;
            this.issuedbook.IconRightVisible = true;
            this.issuedbook.IconRightZoom = 0D;
            this.issuedbook.IconVisible = true;
            this.issuedbook.IconZoom = 90D;
            this.issuedbook.IsTab = false;
            this.issuedbook.Location = new System.Drawing.Point(18, 336);
            this.issuedbook.Name = "issuedbook";
            this.issuedbook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.issuedbook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.issuedbook.OnHoverTextColor = System.Drawing.Color.White;
            this.issuedbook.selected = false;
            this.issuedbook.Size = new System.Drawing.Size(150, 38);
            this.issuedbook.TabIndex = 4;
            this.issuedbook.Text = "Issued Book";
            this.issuedbook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.issuedbook.Textcolor = System.Drawing.Color.White;
            this.issuedbook.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedbook.Click += new System.EventHandler(this.issuedbook_Click);
            // 
            // Booksbtn
            // 
            this.Booksbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Booksbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.Booksbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Booksbtn.BorderRadius = 0;
            this.Booksbtn.ButtonText = "Books";
            this.Booksbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Booksbtn.DisabledColor = System.Drawing.Color.Gray;
            this.Booksbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Booksbtn.Iconimage = null;
            this.Booksbtn.Iconimage_right = null;
            this.Booksbtn.Iconimage_right_Selected = null;
            this.Booksbtn.Iconimage_Selected = null;
            this.Booksbtn.IconMarginLeft = 0;
            this.Booksbtn.IconMarginRight = 0;
            this.Booksbtn.IconRightVisible = true;
            this.Booksbtn.IconRightZoom = 0D;
            this.Booksbtn.IconVisible = true;
            this.Booksbtn.IconZoom = 90D;
            this.Booksbtn.IsTab = false;
            this.Booksbtn.Location = new System.Drawing.Point(18, 292);
            this.Booksbtn.Name = "Booksbtn";
            this.Booksbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.Booksbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Booksbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Booksbtn.selected = false;
            this.Booksbtn.Size = new System.Drawing.Size(150, 38);
            this.Booksbtn.TabIndex = 3;
            this.Booksbtn.Text = "Books";
            this.Booksbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Booksbtn.Textcolor = System.Drawing.Color.White;
            this.Booksbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booksbtn.Click += new System.EventHandler(this.Booksbtn_Click);
            // 
            // studentbtn
            // 
            this.studentbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.studentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.studentbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.studentbtn.BorderRadius = 0;
            this.studentbtn.ButtonText = "Student";
            this.studentbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentbtn.DisabledColor = System.Drawing.Color.Gray;
            this.studentbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.studentbtn.Iconimage = null;
            this.studentbtn.Iconimage_right = null;
            this.studentbtn.Iconimage_right_Selected = null;
            this.studentbtn.Iconimage_Selected = null;
            this.studentbtn.IconMarginLeft = 0;
            this.studentbtn.IconMarginRight = 0;
            this.studentbtn.IconRightVisible = true;
            this.studentbtn.IconRightZoom = 0D;
            this.studentbtn.IconVisible = true;
            this.studentbtn.IconZoom = 90D;
            this.studentbtn.IsTab = false;
            this.studentbtn.Location = new System.Drawing.Point(18, 247);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.studentbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.studentbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.studentbtn.selected = false;
            this.studentbtn.Size = new System.Drawing.Size(150, 38);
            this.studentbtn.TabIndex = 2;
            this.studentbtn.Text = "Student";
            this.studentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studentbtn.Textcolor = System.Drawing.Color.White;
            this.studentbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentbtn.Click += new System.EventHandler(this.studentbtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardBtn.BorderRadius = 0;
            this.dashboardBtn.ButtonText = "Dashboard";
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.DisabledColor = System.Drawing.Color.Gray;
            this.dashboardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboardBtn.Iconimage = null;
            this.dashboardBtn.Iconimage_right = null;
            this.dashboardBtn.Iconimage_right_Selected = null;
            this.dashboardBtn.Iconimage_Selected = null;
            this.dashboardBtn.IconMarginLeft = 0;
            this.dashboardBtn.IconMarginRight = 0;
            this.dashboardBtn.IconRightVisible = true;
            this.dashboardBtn.IconRightZoom = 0D;
            this.dashboardBtn.IconVisible = true;
            this.dashboardBtn.IconZoom = 90D;
            this.dashboardBtn.IsTab = false;
            this.dashboardBtn.Location = new System.Drawing.Point(18, 203);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.dashboardBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dashboardBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.dashboardBtn.selected = false;
            this.dashboardBtn.Size = new System.Drawing.Size(150, 38);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dashboardBtn.Textcolor = System.Drawing.Color.White;
            this.dashboardBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::library.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(28, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.panel3.Controls.Add(this.returnbook1);
            this.panel3.Controls.Add(this.issudbook1);
            this.panel3.Controls.Add(this.dasbord1);
            this.panel3.Controls.Add(this.student1);
            this.panel3.Controls.Add(this.bookadding1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(189, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 505);
            this.panel3.TabIndex = 2;
            // 
            // returnbook1
            // 
            this.returnbook1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.returnbook1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnbook1.Location = new System.Drawing.Point(0, 0);
            this.returnbook1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnbook1.Name = "returnbook1";
            this.returnbook1.Size = new System.Drawing.Size(682, 505);
            this.returnbook1.TabIndex = 8;
            this.returnbook1.Load += new System.EventHandler(this.returnbook1_Load);
            // 
            // issudbook1
            // 
            this.issudbook1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.issudbook1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issudbook1.Location = new System.Drawing.Point(0, 0);
            this.issudbook1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issudbook1.Name = "issudbook1";
            this.issudbook1.Size = new System.Drawing.Size(682, 505);
            this.issudbook1.TabIndex = 7;
            // 
            // dasbord1
            // 
            this.dasbord1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.dasbord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dasbord1.Location = new System.Drawing.Point(0, 0);
            this.dasbord1.Margin = new System.Windows.Forms.Padding(2);
            this.dasbord1.Name = "dasbord1";
            this.dasbord1.Size = new System.Drawing.Size(682, 505);
            this.dasbord1.TabIndex = 6;
            // 
            // student1
            // 
            this.student1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student1.Location = new System.Drawing.Point(0, 0);
            this.student1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.student1.Name = "student1";
            this.student1.Size = new System.Drawing.Size(682, 505);
            this.student1.TabIndex = 4;
            // 
            // bookadding1
            // 
            this.bookadding1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.bookadding1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookadding1.Location = new System.Drawing.Point(0, 0);
            this.bookadding1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookadding1.Name = "bookadding1";
            this.bookadding1.Size = new System.Drawing.Size(682, 505);
            this.bookadding1.TabIndex = 5;
            // 
            // dashbord1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "dashbord1";
            this.Text = "`";
            this.Load += new System.EventHandler(this.dashbord1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton dashboardBtn;
        private Bunifu.Framework.UI.BunifuFlatButton issuedbook;
        private Bunifu.Framework.UI.BunifuFlatButton Booksbtn;
        private Bunifu.Framework.UI.BunifuFlatButton studentbtn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private student student1;
        private bookadding bookadding1;
        private dasbord dasbord1;
        private issudbook issudbook1;
        private returnbook returnbook1;
        private Bunifu.Framework.UI.BunifuFlatButton ReturnButton;
    }
}
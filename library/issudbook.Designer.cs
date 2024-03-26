namespace library
{
    partial class issudbook
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
            this.label3 = new System.Windows.Forms.Label();
            this.enrollmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.issueBookButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(241, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enrollment no :-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // enrollmentNumberTextBox
            // 
            this.enrollmentNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.enrollmentNumberTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmentNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.enrollmentNumberTextBox.Location = new System.Drawing.Point(424, 197);
            this.enrollmentNumberTextBox.Name = "enrollmentNumberTextBox";
            this.enrollmentNumberTextBox.Size = new System.Drawing.Size(267, 30);
            this.enrollmentNumberTextBox.TabIndex = 6;
            this.enrollmentNumberTextBox.TextChanged += new System.EventHandler(this.enrollmentNumberTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(241, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Book no :-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookNumberTextBox
            // 
            this.bookNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.bookNumberTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.bookNumberTextBox.Location = new System.Drawing.Point(424, 284);
            this.bookNumberTextBox.Name = "bookNumberTextBox";
            this.bookNumberTextBox.Size = new System.Drawing.Size(267, 30);
            this.bookNumberTextBox.TabIndex = 8;
            this.bookNumberTextBox.TextChanged += new System.EventHandler(this.bookNumberTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(363, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Issue Book";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // issueBookButton
            // 
            this.issueBookButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.issueBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.issueBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.issueBookButton.BorderRadius = 0;
            this.issueBookButton.ButtonText = "issue Book";
            this.issueBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueBookButton.DisabledColor = System.Drawing.Color.Gray;
            this.issueBookButton.Iconcolor = System.Drawing.Color.Transparent;
            this.issueBookButton.Iconimage = null;
            this.issueBookButton.Iconimage_right = null;
            this.issueBookButton.Iconimage_right_Selected = null;
            this.issueBookButton.Iconimage_Selected = null;
            this.issueBookButton.IconMarginLeft = 0;
            this.issueBookButton.IconMarginRight = 0;
            this.issueBookButton.IconRightVisible = true;
            this.issueBookButton.IconRightZoom = 0D;
            this.issueBookButton.IconVisible = true;
            this.issueBookButton.IconZoom = 90D;
            this.issueBookButton.IsTab = false;
            this.issueBookButton.Location = new System.Drawing.Point(359, 407);
            this.issueBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.issueBookButton.Name = "issueBookButton";
            this.issueBookButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.issueBookButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.issueBookButton.OnHoverTextColor = System.Drawing.Color.White;
            this.issueBookButton.selected = false;
            this.issueBookButton.Size = new System.Drawing.Size(229, 46);
            this.issueBookButton.TabIndex = 11;
            this.issueBookButton.Text = "issue Book";
            this.issueBookButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.issueBookButton.Textcolor = System.Drawing.Color.White;
            this.issueBookButton.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBookButton.Click += new System.EventHandler(this.issueBookButton_Click);
            // 
            // issudbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.issueBookButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enrollmentNumberTextBox);
            this.Name = "issudbook";
            this.Size = new System.Drawing.Size(998, 553);
            this.Load += new System.EventHandler(this.issudbook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enrollmentNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookNumberTextBox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton issueBookButton;
    }
}

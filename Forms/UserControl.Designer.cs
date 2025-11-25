namespace EdiWare
{
    partial class UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl));
            this.pnlWindow = new System.Windows.Forms.Panel();
            this.btnWindowControl = new System.Windows.Forms.Button();
            this.btnIconStatus = new System.Windows.Forms.Button();
            this.btnCrossMark = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.pbxEduware = new System.Windows.Forms.PictureBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnStudent = new System.Windows.Forms.RadioButton();
            this.rbtnEducator = new System.Windows.Forms.RadioButton();
            this.rbtnAuthorized = new System.Windows.Forms.RadioButton();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.llblAboutUs = new System.Windows.Forms.LinkLabel();
            this.pbxVisible = new System.Windows.Forms.PictureBox();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            this.llblForgot = new System.Windows.Forms.LinkLabel();
            this.pnlWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEduware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWindow
            // 
            this.pnlWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.pnlWindow.Controls.Add(this.btnWindowControl);
            this.pnlWindow.Controls.Add(this.btnIconStatus);
            this.pnlWindow.Controls.Add(this.btnCrossMark);
            this.pnlWindow.Controls.Add(this.pictureBox2);
            this.pnlWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindow.Location = new System.Drawing.Point(0, 0);
            this.pnlWindow.Name = "pnlWindow";
            this.pnlWindow.Size = new System.Drawing.Size(1206, 40);
            this.pnlWindow.TabIndex = 0;
            this.pnlWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlWindow_MouseDown);
            // 
            // btnWindowControl
            // 
            this.btnWindowControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnWindowControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowControl.BackgroundImage")));
            this.btnWindowControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWindowControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWindowControl.FlatAppearance.BorderSize = 0;
            this.btnWindowControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnWindowControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowControl.Location = new System.Drawing.Point(1126, 0);
            this.btnWindowControl.Name = "btnWindowControl";
            this.btnWindowControl.Size = new System.Drawing.Size(40, 40);
            this.btnWindowControl.TabIndex = 6;
            this.btnWindowControl.UseVisualStyleBackColor = false;
            this.btnWindowControl.Click += new System.EventHandler(this.btnWindowControl_Click);
            // 
            // btnIconStatus
            // 
            this.btnIconStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIconStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIconStatus.BackgroundImage")));
            this.btnIconStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIconStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIconStatus.FlatAppearance.BorderSize = 0;
            this.btnIconStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnIconStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconStatus.Location = new System.Drawing.Point(1086, 0);
            this.btnIconStatus.Name = "btnIconStatus";
            this.btnIconStatus.Size = new System.Drawing.Size(40, 40);
            this.btnIconStatus.TabIndex = 5;
            this.btnIconStatus.UseVisualStyleBackColor = true;
            this.btnIconStatus.Click += new System.EventHandler(this.btnIconStatus_Click);
            // 
            // btnCrossMark
            // 
            this.btnCrossMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrossMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrossMark.BackgroundImage")));
            this.btnCrossMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrossMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrossMark.FlatAppearance.BorderSize = 0;
            this.btnCrossMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCrossMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrossMark.Location = new System.Drawing.Point(1166, 0);
            this.btnCrossMark.Name = "btnCrossMark";
            this.btnCrossMark.Size = new System.Drawing.Size(40, 40);
            this.btnCrossMark.TabIndex = 4;
            this.btnCrossMark.UseVisualStyleBackColor = true;
            this.btnCrossMark.Click += new System.EventHandler(this.btnCrossMark_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1083, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.panelInformation.Controls.Add(this.pbxEduware);
            this.panelInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInformation.Location = new System.Drawing.Point(0, 40);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(272, 753);
            this.panelInformation.TabIndex = 1;
            // 
            // pbxEduware
            // 
            this.pbxEduware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEduware.Image = ((System.Drawing.Image)(resources.GetObject("pbxEduware.Image")));
            this.pbxEduware.Location = new System.Drawing.Point(48, 24);
            this.pbxEduware.Name = "pbxEduware";
            this.pbxEduware.Size = new System.Drawing.Size(175, 175);
            this.pbxEduware.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEduware.TabIndex = 0;
            this.pbxEduware.TabStop = false;
            this.pbxEduware.Click += new System.EventHandler(this.pbxEduware_Click);
            // 
            // pnlUsername
            // 
            this.pnlUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUsername.BackColor = System.Drawing.Color.Silver;
            this.pnlUsername.Location = new System.Drawing.Point(514, 437);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(400, 4);
            this.pnlUsername.TabIndex = 2;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUsername.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUsername.Location = new System.Drawing.Point(95, 333);
            this.tbxUsername.MaxLength = 16;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(343, 29);
            this.tbxUsername.TabIndex = 4;
            this.tbxUsername.Text = "Username";
            this.tbxUsername.Enter += new System.EventHandler(this.tbxUsername_Enter);
            this.tbxUsername.Leave += new System.EventHandler(this.tbxUsername_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(514, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Location = new System.Drawing.Point(567, 508);
            this.tbxPassword.MaxLength = 16;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(301, 29);
            this.tbxPassword.TabIndex = 5;
            this.tbxPassword.Text = "Password";
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(514, 502);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(41, 523);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 57);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(514, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 4);
            this.panel1.TabIndex = 3;
            // 
            // rbtnStudent
            // 
            this.rbtnStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnStudent.AutoSize = true;
            this.rbtnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.rbtnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnStudent.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnStudent.Location = new System.Drawing.Point(514, 316);
            this.rbtnStudent.Name = "rbtnStudent";
            this.rbtnStudent.Size = new System.Drawing.Size(100, 29);
            this.rbtnStudent.TabIndex = 1;
            this.rbtnStudent.TabStop = true;
            this.rbtnStudent.Text = "Student";
            this.rbtnStudent.UseVisualStyleBackColor = false;
            // 
            // rbtnEducator
            // 
            this.rbtnEducator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnEducator.AutoSize = true;
            this.rbtnEducator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.rbtnEducator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnEducator.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnEducator.Location = new System.Drawing.Point(647, 316);
            this.rbtnEducator.Name = "rbtnEducator";
            this.rbtnEducator.Size = new System.Drawing.Size(112, 29);
            this.rbtnEducator.TabIndex = 2;
            this.rbtnEducator.TabStop = true;
            this.rbtnEducator.Text = "Educator";
            this.rbtnEducator.UseVisualStyleBackColor = false;
            // 
            // rbtnAuthorized
            // 
            this.rbtnAuthorized.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnAuthorized.AutoSize = true;
            this.rbtnAuthorized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.rbtnAuthorized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAuthorized.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnAuthorized.Location = new System.Drawing.Point(782, 316);
            this.rbtnAuthorized.Name = "rbtnAuthorized";
            this.rbtnAuthorized.Size = new System.Drawing.Size(132, 29);
            this.rbtnAuthorized.TabIndex = 3;
            this.rbtnAuthorized.TabStop = true;
            this.rbtnAuthorized.Text = "Authorized";
            this.rbtnAuthorized.UseVisualStyleBackColor = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.pnlLogin.Controls.Add(this.llblAboutUs);
            this.pnlLogin.Controls.Add(this.pbxVisible);
            this.pnlLogin.Controls.Add(this.pbxLogin);
            this.pnlLogin.Controls.Add(this.llblForgot);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.tbxUsername);
            this.pnlLogin.Location = new System.Drawing.Point(473, 64);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(469, 707);
            this.pnlLogin.TabIndex = 13;
            // 
            // llblAboutUs
            // 
            this.llblAboutUs.ActiveLinkColor = System.Drawing.Color.Blue;
            this.llblAboutUs.AutoSize = true;
            this.llblAboutUs.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llblAboutUs.LinkColor = System.Drawing.Color.Black;
            this.llblAboutUs.Location = new System.Drawing.Point(191, 650);
            this.llblAboutUs.Name = "llblAboutUs";
            this.llblAboutUs.Size = new System.Drawing.Size(95, 25);
            this.llblAboutUs.TabIndex = 11;
            this.llblAboutUs.TabStop = true;
            this.llblAboutUs.Text = "About Us";
            this.llblAboutUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAboutUs_LinkClicked);
            // 
            // pbxVisible
            // 
            this.pbxVisible.Image = ((System.Drawing.Image)(resources.GetObject("pbxVisible.Image")));
            this.pbxVisible.Location = new System.Drawing.Point(405, 438);
            this.pbxVisible.Name = "pbxVisible";
            this.pbxVisible.Size = new System.Drawing.Size(36, 38);
            this.pbxVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVisible.TabIndex = 10;
            this.pbxVisible.TabStop = false;
            this.pbxVisible.Click += new System.EventHandler(this.pbxVisible_Click);
            // 
            // pbxLogin
            // 
            this.pbxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogin.Image")));
            this.pbxLogin.Location = new System.Drawing.Point(132, 21);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(200, 200);
            this.pbxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogin.TabIndex = 9;
            this.pbxLogin.TabStop = false;
            // 
            // llblForgot
            // 
            this.llblForgot.ActiveLinkColor = System.Drawing.Color.Blue;
            this.llblForgot.AutoSize = true;
            this.llblForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblForgot.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llblForgot.LinkColor = System.Drawing.Color.Black;
            this.llblForgot.Location = new System.Drawing.Point(77, 602);
            this.llblForgot.Name = "llblForgot";
            this.llblForgot.Size = new System.Drawing.Size(328, 28);
            this.llblForgot.TabIndex = 7;
            this.llblForgot.TabStop = true;
            this.llblForgot.Text = "Forgot Username / Password ?";
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1206, 793);
            this.Controls.Add(this.rbtnAuthorized);
            this.Controls.Add(this.rbtnEducator);
            this.Controls.Add(this.rbtnStudent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.pnlWindow);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEduware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWindow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Button btnCrossMark;
        private System.Windows.Forms.Button btnIconStatus;
        private System.Windows.Forms.Button btnWindowControl;
        private System.Windows.Forms.PictureBox pbxEduware;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnStudent;
        private System.Windows.Forms.RadioButton rbtnEducator;
        private System.Windows.Forms.RadioButton rbtnAuthorized;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.LinkLabel llblForgot;
        private System.Windows.Forms.PictureBox pbxLogin;
        private System.Windows.Forms.PictureBox pbxVisible;
        private System.Windows.Forms.LinkLabel llblAboutUs;
    }
}


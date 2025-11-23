namespace EdiWare
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlWindow = new System.Windows.Forms.Panel();
            this.btnWindowControl = new System.Windows.Forms.Button();
            this.btnIconStatus = new System.Windows.Forms.Button();
            this.btnCrossMark = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pnlWindow.Size = new System.Drawing.Size(1250, 40);
            this.pnlWindow.TabIndex = 0;
            this.pnlWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlWindow_MouseDown);
            // 
            // btnWindowControl
            // 
            this.btnWindowControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowControl.BackgroundImage")));
            this.btnWindowControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWindowControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWindowControl.FlatAppearance.BorderSize = 0;
            this.btnWindowControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnWindowControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowControl.Location = new System.Drawing.Point(1170, 0);
            this.btnWindowControl.Name = "btnWindowControl";
            this.btnWindowControl.Size = new System.Drawing.Size(40, 40);
            this.btnWindowControl.TabIndex = 6;
            this.btnWindowControl.UseVisualStyleBackColor = true;
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
            this.btnIconStatus.Location = new System.Drawing.Point(1130, 0);
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
            this.btnCrossMark.Location = new System.Drawing.Point(1210, 0);
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
            this.pictureBox2.Location = new System.Drawing.Point(1127, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 652);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1250, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWindow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCrossMark;
        private System.Windows.Forms.Button btnIconStatus;
        private System.Windows.Forms.Button btnWindowControl;
    }
}


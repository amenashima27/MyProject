namespace Invoice_Total
{
    partial class frmAboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutMe));
            this.pictureMe = new System.Windows.Forms.PictureBox();
            this.lblDis = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.aboutMeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMe)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureMe
            // 
            this.pictureMe.Image = ((System.Drawing.Image)(resources.GetObject("pictureMe.Image")));
            this.pictureMe.Location = new System.Drawing.Point(576, 51);
            this.pictureMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureMe.Name = "pictureMe";
            this.pictureMe.Size = new System.Drawing.Size(276, 424);
            this.pictureMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMe.TabIndex = 6;
            this.pictureMe.TabStop = false;
            this.pictureMe.Click += new System.EventHandler(this.pictureMe_Click);
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDis.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDis.Location = new System.Drawing.Point(12, 185);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(570, 244);
            this.lblDis.TabIndex = 9;
            this.lblDis.Text = resources.GetString("lblDis.Text");
            this.lblDis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(576, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // aboutMeLbl
            // 
            this.aboutMeLbl.AutoSize = true;
            this.aboutMeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutMeLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.aboutMeLbl.Location = new System.Drawing.Point(41, 51);
            this.aboutMeLbl.Name = "aboutMeLbl";
            this.aboutMeLbl.Size = new System.Drawing.Size(314, 116);
            this.aboutMeLbl.TabIndex = 7;
            this.aboutMeLbl.Text = " Hi , This is Amena.\r\n I am a computer Science \r\n student at York College.\r\n\r\n";
            // 
            // frmAboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 590);
            this.Controls.Add(this.pictureMe);
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.aboutMeLbl);
            this.Name = "frmAboutMe";
            this.Text = "frmAboutMe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureMe;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label aboutMeLbl;
    }
}
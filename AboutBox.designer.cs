namespace UltraCoder
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.version = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.build = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.webpage = new System.Windows.Forms.Button();
            this.compailer = new System.Windows.Forms.Label();
            this.builddate = new System.Windows.Forms.Label();
            this.license = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.version.Location = new System.Drawing.Point(15, 127);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(45, 16);
            this.version.TabIndex = 2;
            this.version.Text = "label1";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.copyright.Location = new System.Drawing.Point(15, 143);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(45, 16);
            this.copyright.TabIndex = 3;
            this.copyright.Text = "label1";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.company.Location = new System.Drawing.Point(15, 159);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(45, 16);
            this.company.TabIndex = 4;
            this.company.Text = "label1";
            // 
            // description
            // 
            this.description.Enabled = false;
            this.description.Location = new System.Drawing.Point(12, 194);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description.Size = new System.Drawing.Size(195, 137);
            this.description.TabIndex = 5;
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.build.Location = new System.Drawing.Point(15, 175);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(45, 16);
            this.build.TabIndex = 6;
            this.build.Text = "label1";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(12, 346);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 7;
            this.ok.Text = "&OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // webpage
            // 
            this.webpage.Location = new System.Drawing.Point(93, 346);
            this.webpage.Name = "webpage";
            this.webpage.Size = new System.Drawing.Size(75, 23);
            this.webpage.TabIndex = 8;
            this.webpage.Text = "&Website";
            this.webpage.UseVisualStyleBackColor = true;
            this.webpage.Visible = false;
            // 
            // compailer
            // 
            this.compailer.AutoSize = true;
            this.compailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.compailer.Location = new System.Drawing.Point(163, 143);
            this.compailer.Name = "compailer";
            this.compailer.Size = new System.Drawing.Size(234, 16);
            this.compailer.TabIndex = 9;
            this.compailer.Text = "Compiler: Microsoft Visual Studio 2013";
            // 
            // builddate
            // 
            this.builddate.AutoSize = true;
            this.builddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.builddate.Location = new System.Drawing.Point(163, 127);
            this.builddate.Name = "builddate";
            this.builddate.Size = new System.Drawing.Size(45, 16);
            this.builddate.TabIndex = 10;
            this.builddate.Text = "label1";
            // 
            // license
            // 
            this.license.Location = new System.Drawing.Point(175, 346);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(75, 23);
            this.license.TabIndex = 11;
            this.license.Text = "&License";
            this.license.UseVisualStyleBackColor = true;
            this.license.Visible = false;
            this.license.Click += new System.EventHandler(this.license_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(257, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // AboutBox
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 385);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.license);
            this.Controls.Add(this.builddate);
            this.Controls.Add(this.compailer);
            this.Controls.Add(this.webpage);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.build);
            this.Controls.Add(this.description);
            this.Controls.Add(this.company);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.version);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label build;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button webpage;
        private System.Windows.Forms.Label compailer;
        private System.Windows.Forms.Label builddate;
        private System.Windows.Forms.Button license;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}

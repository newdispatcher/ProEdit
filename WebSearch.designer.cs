namespace UltraCoder
{
    partial class WebSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebSearch));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.google = new System.Windows.Forms.RadioButton();
            this.bing = new System.Windows.Forms.RadioButton();
            this.wiki = new System.Windows.Forms.RadioButton();
            this.stackoverflow = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 20);
            this.textBox1.TabIndex = 0;
            // 
            // google
            // 
            this.google.AutoSize = true;
            this.google.Checked = true;
            this.google.Location = new System.Drawing.Point(263, 38);
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(59, 17);
            this.google.TabIndex = 1;
            this.google.TabStop = true;
            this.google.Text = "Google";
            this.google.UseVisualStyleBackColor = true;
            // 
            // bing
            // 
            this.bing.AutoSize = true;
            this.bing.Location = new System.Drawing.Point(328, 38);
            this.bing.Name = "bing";
            this.bing.Size = new System.Drawing.Size(46, 17);
            this.bing.TabIndex = 2;
            this.bing.Text = "Bing";
            this.bing.UseVisualStyleBackColor = true;
            // 
            // wiki
            // 
            this.wiki.AutoSize = true;
            this.wiki.Location = new System.Drawing.Point(380, 38);
            this.wiki.Name = "wiki";
            this.wiki.Size = new System.Drawing.Size(72, 17);
            this.wiki.TabIndex = 4;
            this.wiki.Text = "Wikipedia";
            this.wiki.UseVisualStyleBackColor = true;
            // 
            // stackoverflow
            // 
            this.stackoverflow.AutoSize = true;
            this.stackoverflow.Location = new System.Drawing.Point(458, 38);
            this.stackoverflow.Name = "stackoverflow";
            this.stackoverflow.Size = new System.Drawing.Size(93, 17);
            this.stackoverflow.TabIndex = 5;
            this.stackoverflow.Text = "Stackoverflow";
            this.stackoverflow.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 68);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 6;
            this.search.Text = "Search...";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(109, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search keyword:";
            // 
            // WebSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(595, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.stackoverflow);
            this.Controls.Add(this.wiki);
            this.Controls.Add(this.bing);
            this.Controls.Add(this.google);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebSearch";
            this.Text = "Internet Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton google;
        private System.Windows.Forms.RadioButton bing;
        private System.Windows.Forms.RadioButton wiki;
        private System.Windows.Forms.RadioButton stackoverflow;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
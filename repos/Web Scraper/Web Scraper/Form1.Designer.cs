namespace Web_Scraper
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
            this.scrapeBtn = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // scrapeBtn
            // 
            this.scrapeBtn.Location = new System.Drawing.Point(90, 104);
            this.scrapeBtn.Name = "scrapeBtn";
            this.scrapeBtn.Size = new System.Drawing.Size(95, 59);
            this.scrapeBtn.TabIndex = 0;
            this.scrapeBtn.Text = "Fetch HTML";
            this.scrapeBtn.UseVisualStyleBackColor = true;
            this.scrapeBtn.Click += new System.EventHandler(this.scrapeBtn_Click);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(59, 76);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(150, 22);
            this.urlBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter URL Here";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.scrapeBtn);
            this.Name = "Form1";
            this.Text = "Web Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scrapeBtn;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


namespace GUIClassBasics
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
            this.saveStdntBtn = new System.Windows.Forms.Button();
            this.displayStdntBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveStdntBtn
            // 
            this.saveStdntBtn.Location = new System.Drawing.Point(0, 0);
            this.saveStdntBtn.Name = "saveStdntBtn";
            this.saveStdntBtn.Size = new System.Drawing.Size(110, 49);
            this.saveStdntBtn.TabIndex = 0;
            this.saveStdntBtn.Text = "Save Student Info";
            this.saveStdntBtn.UseVisualStyleBackColor = true;
            this.saveStdntBtn.Click += new System.EventHandler(this.saveStdntBtn_Click);
            // 
            // displayStdntBtn
            // 
            this.displayStdntBtn.Location = new System.Drawing.Point(0, 69);
            this.displayStdntBtn.Name = "displayStdntBtn";
            this.displayStdntBtn.Size = new System.Drawing.Size(110, 49);
            this.displayStdntBtn.TabIndex = 1;
            this.displayStdntBtn.Text = "Display Student Info";
            this.displayStdntBtn.UseVisualStyleBackColor = true;
            this.displayStdntBtn.Click += new System.EventHandler(this.displayStdntBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayStdntBtn);
            this.Controls.Add(this.saveStdntBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveStdntBtn;
        private System.Windows.Forms.Button displayStdntBtn;
    }
}


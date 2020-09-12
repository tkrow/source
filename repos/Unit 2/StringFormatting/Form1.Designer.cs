namespace StringFormatting
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblCurrencyTwoDemialPlaces = new System.Windows.Forms.Label();
            this.lblNumericFormatting = new System.Windows.Forms.Label();
            this.lblRightAlignment = new System.Windows.Forms.Label();
            this.lblLeftAlignment = new System.Windows.Forms.Label();
            this.lblLeftAlignmentTwoValues = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(162, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(118, 25);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Display Outputs";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblCurrencyTwoDemialPlaces
            // 
            this.lblCurrencyTwoDemialPlaces.AutoSize = true;
            this.lblCurrencyTwoDemialPlaces.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCurrencyTwoDemialPlaces.Location = new System.Drawing.Point(12, 55);
            this.lblCurrencyTwoDemialPlaces.Name = "lblCurrencyTwoDemialPlaces";
            this.lblCurrencyTwoDemialPlaces.Size = new System.Drawing.Size(216, 17);
            this.lblCurrencyTwoDemialPlaces.TabIndex = 1;
            this.lblCurrencyTwoDemialPlaces.Text = "Currency To Two Decimal Places";
            // 
            // lblNumericFormatting
            // 
            this.lblNumericFormatting.AutoSize = true;
            this.lblNumericFormatting.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNumericFormatting.Location = new System.Drawing.Point(12, 72);
            this.lblNumericFormatting.Name = "lblNumericFormatting";
            this.lblNumericFormatting.Size = new System.Drawing.Size(294, 17);
            this.lblNumericFormatting.TabIndex = 2;
            this.lblNumericFormatting.Text = "Numeric Formatting To Three Decimal Places";
            // 
            // lblRightAlignment
            // 
            this.lblRightAlignment.AutoSize = true;
            this.lblRightAlignment.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRightAlignment.Location = new System.Drawing.Point(12, 89);
            this.lblRightAlignment.Name = "lblRightAlignment";
            this.lblRightAlignment.Size = new System.Drawing.Size(132, 17);
            this.lblRightAlignment.TabIndex = 3;
            this.lblRightAlignment.Text = "Right Aligned Value";
            // 
            // lblLeftAlignment
            // 
            this.lblLeftAlignment.AutoSize = true;
            this.lblLeftAlignment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblLeftAlignment.Location = new System.Drawing.Point(12, 106);
            this.lblLeftAlignment.Name = "lblLeftAlignment";
            this.lblLeftAlignment.Size = new System.Drawing.Size(123, 17);
            this.lblLeftAlignment.TabIndex = 4;
            this.lblLeftAlignment.Text = "Left Aligned Value";
            // 
            // lblLeftAlignmentTwoValues
            // 
            this.lblLeftAlignmentTwoValues.AutoSize = true;
            this.lblLeftAlignmentTwoValues.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblLeftAlignmentTwoValues.Location = new System.Drawing.Point(12, 123);
            this.lblLeftAlignmentTwoValues.Name = "lblLeftAlignmentTwoValues";
            this.lblLeftAlignmentTwoValues.Size = new System.Drawing.Size(160, 17);
            this.lblLeftAlignmentTwoValues.TabIndex = 5;
            this.lblLeftAlignmentTwoValues.Text = "Left Aligned Two Values";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.lblLeftAlignmentTwoValues);
            this.Controls.Add(this.lblLeftAlignment);
            this.Controls.Add(this.lblRightAlignment);
            this.Controls.Add(this.lblNumericFormatting);
            this.Controls.Add(this.lblCurrencyTwoDemialPlaces);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblCurrencyTwoDemialPlaces;
        private System.Windows.Forms.Label lblNumericFormatting;
        private System.Windows.Forms.Label lblRightAlignment;
        private System.Windows.Forms.Label lblLeftAlignment;
        private System.Windows.Forms.Label lblLeftAlignmentTwoValues;
    }
}


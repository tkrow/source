namespace StringManipulations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.containsInput = new System.Windows.Forms.TextBox();
            this.containsTestFor = new System.Windows.Forms.TextBox();
            this.containsOutput = new System.Windows.Forms.Label();
            this.containsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.insertUserInput = new System.Windows.Forms.TextBox();
            this.insertInput = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.insertLocation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.InsertOutput = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.crtStringBuilder = new System.Windows.Forms.Button();
            this.stringBuilderOutput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mainStringBuilder = new System.Windows.Forms.TextBox();
            this.removeStringBuilder1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.removeStringBuilder2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contains()";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Text For:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contain()Output";
            // 
            // containsInput
            // 
            this.containsInput.Location = new System.Drawing.Point(141, 47);
            this.containsInput.Name = "containsInput";
            this.containsInput.Size = new System.Drawing.Size(159, 22);
            this.containsInput.TabIndex = 5;
            // 
            // containsTestFor
            // 
            this.containsTestFor.Location = new System.Drawing.Point(326, 45);
            this.containsTestFor.Name = "containsTestFor";
            this.containsTestFor.Size = new System.Drawing.Size(159, 22);
            this.containsTestFor.TabIndex = 5;
            // 
            // containsOutput
            // 
            this.containsOutput.AutoSize = true;
            this.containsOutput.Location = new System.Drawing.Point(184, 81);
            this.containsOutput.Name = "containsOutput";
            this.containsOutput.Size = new System.Drawing.Size(0, 17);
            this.containsOutput.TabIndex = 4;
            // 
            // containsButton
            // 
            this.containsButton.Location = new System.Drawing.Point(517, 37);
            this.containsButton.Name = "containsButton";
            this.containsButton.Size = new System.Drawing.Size(119, 30);
            this.containsButton.TabIndex = 6;
            this.containsButton.Text = "Test Contains()\r\n";
            this.containsButton.UseVisualStyleBackColor = true;
            this.containsButton.Click += new System.EventHandler(this.containsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = " Insert()";
            // 
            // insertUserInput
            // 
            this.insertUserInput.Location = new System.Drawing.Point(326, 158);
            this.insertUserInput.Name = "insertUserInput";
            this.insertUserInput.Size = new System.Drawing.Size(159, 22);
            this.insertUserInput.TabIndex = 8;
            // 
            // insertInput
            // 
            this.insertInput.Location = new System.Drawing.Point(141, 160);
            this.insertInput.Name = "insertInput";
            this.insertInput.Size = new System.Drawing.Size(159, 22);
            this.insertInput.TabIndex = 9;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(584, 150);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(119, 30);
            this.insertButton.TabIndex = 10;
            this.insertButton.Text = "Test Insert()\r\n";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Insert()Output";
            // 
            // insertLocation
            // 
            this.insertLocation.Location = new System.Drawing.Point(505, 158);
            this.insertLocation.Name = "insertLocation";
            this.insertLocation.Size = new System.Drawing.Size(59, 22);
            this.insertLocation.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "String to Insert";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Index";
            // 
            // InsertOutput
            // 
            this.InsertOutput.AutoSize = true;
            this.InsertOutput.Location = new System.Drawing.Point(184, 206);
            this.InsertOutput.Name = "InsertOutput";
            this.InsertOutput.Size = new System.Drawing.Size(0, 17);
            this.InsertOutput.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "StringBuilder example";
            // 
            // crtStringBuilder
            // 
            this.crtStringBuilder.Location = new System.Drawing.Point(33, 366);
            this.crtStringBuilder.Name = "crtStringBuilder";
            this.crtStringBuilder.Size = new System.Drawing.Size(106, 59);
            this.crtStringBuilder.TabIndex = 17;
            this.crtStringBuilder.Text = "Create StringBuilder Object";
            this.crtStringBuilder.UseVisualStyleBackColor = true;
            this.crtStringBuilder.Click += new System.EventHandler(this.crtStringBuilder_Click);
            // 
            // stringBuilderOutput
            // 
            this.stringBuilderOutput.AutoSize = true;
            this.stringBuilderOutput.Location = new System.Drawing.Point(290, 387);
            this.stringBuilderOutput.Name = "stringBuilderOutput";
            this.stringBuilderOutput.Size = new System.Drawing.Size(0, 17);
            this.stringBuilderOutput.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "stringBuilderOutput\r\n";
            // 
            // mainStringBuilder
            // 
            this.mainStringBuilder.Location = new System.Drawing.Point(187, 309);
            this.mainStringBuilder.Name = "mainStringBuilder";
            this.mainStringBuilder.Size = new System.Drawing.Size(155, 22);
            this.mainStringBuilder.TabIndex = 20;
            // 
            // removeStringBuilder1
            // 
            this.removeStringBuilder1.Location = new System.Drawing.Point(380, 309);
            this.removeStringBuilder1.Name = "removeStringBuilder1";
            this.removeStringBuilder1.Size = new System.Drawing.Size(93, 22);
            this.removeStringBuilder1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Main String";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(360, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Start Index Removed";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "End Index Removed";
            // 
            // removeStringBuilder2
            // 
            this.removeStringBuilder2.Location = new System.Drawing.Point(543, 309);
            this.removeStringBuilder2.Name = "removeStringBuilder2";
            this.removeStringBuilder2.Size = new System.Drawing.Size(93, 22);
            this.removeStringBuilder2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.removeStringBuilder2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.removeStringBuilder1);
            this.Controls.Add(this.mainStringBuilder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.stringBuilderOutput);
            this.Controls.Add(this.crtStringBuilder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.InsertOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.insertLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.insertUserInput);
            this.Controls.Add(this.insertInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.containsButton);
            this.Controls.Add(this.containsTestFor);
            this.Controls.Add(this.containsInput);
            this.Controls.Add(this.containsOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox containsInput;
        private System.Windows.Forms.TextBox containsTestFor;
        private System.Windows.Forms.Label containsOutput;
        private System.Windows.Forms.Button containsButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox insertUserInput;
        private System.Windows.Forms.TextBox insertInput;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox insertLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label InsertOutput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button crtStringBuilder;
        private System.Windows.Forms.Label stringBuilderOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mainStringBuilder;
        private System.Windows.Forms.TextBox removeStringBuilder1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox removeStringBuilder2;
    }
}


namespace IntermProgFinalProject
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
            this.inputTransactionAmount = new System.Windows.Forms.TextBox();
            this.processTransactionInput = new System.Windows.Forms.Button();
            this.transactionBox = new System.Windows.Forms.ListBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ssnBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateOfBirthBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.zipCodeBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.processUserInput = new System.Windows.Forms.Button();
            this.personInfoOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Amount";
            // 
            // inputTransactionAmount
            // 
            this.inputTransactionAmount.Location = new System.Drawing.Point(181, 29);
            this.inputTransactionAmount.Name = "inputTransactionAmount";
            this.inputTransactionAmount.Size = new System.Drawing.Size(199, 22);
            this.inputTransactionAmount.TabIndex = 1;
            // 
            // processTransactionInput
            // 
            this.processTransactionInput.Location = new System.Drawing.Point(181, 62);
            this.processTransactionInput.Name = "processTransactionInput";
            this.processTransactionInput.Size = new System.Drawing.Size(199, 79);
            this.processTransactionInput.TabIndex = 2;
            this.processTransactionInput.Text = "Process Transaction";
            this.processTransactionInput.UseVisualStyleBackColor = true;
            this.processTransactionInput.Click += new System.EventHandler(this.processTransactionInput_Click);
            // 
            // transactionBox
            // 
            this.transactionBox.FormattingEnabled = true;
            this.transactionBox.ItemHeight = 16;
            this.transactionBox.Location = new System.Drawing.Point(386, 9);
            this.transactionBox.Name = "transactionBox";
            this.transactionBox.Size = new System.Drawing.Size(433, 532);
            this.transactionBox.TabIndex = 3;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(15, 29);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(73, 22);
            this.firstNameBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(15, 74);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(73, 22);
            this.lastNameBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // ssnBox
            // 
            this.ssnBox.Location = new System.Drawing.Point(17, 119);
            this.ssnBox.Name = "ssnBox";
            this.ssnBox.Size = new System.Drawing.Size(73, 22);
            this.ssnBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "SSN";
            // 
            // dateOfBirthBox
            // 
            this.dateOfBirthBox.Location = new System.Drawing.Point(17, 164);
            this.dateOfBirthBox.Name = "dateOfBirthBox";
            this.dateOfBirthBox.Size = new System.Drawing.Size(110, 22);
            this.dateOfBirthBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of Birth";
            // 
            // userIdBox
            // 
            this.userIdBox.Location = new System.Drawing.Point(17, 210);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(110, 22);
            this.userIdBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "User ID";
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(17, 255);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(199, 22);
            this.streetBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Street Address";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(17, 300);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(110, 22);
            this.cityBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "City";
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(17, 393);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(110, 22);
            this.stateBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "State";
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Location = new System.Drawing.Point(17, 348);
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(110, 22);
            this.zipCodeBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Zip Code";
            // 
            // processUserInput
            // 
            this.processUserInput.Location = new System.Drawing.Point(17, 435);
            this.processUserInput.Name = "processUserInput";
            this.processUserInput.Size = new System.Drawing.Size(110, 79);
            this.processUserInput.TabIndex = 24;
            this.processUserInput.Text = "Create User";
            this.processUserInput.UseVisualStyleBackColor = true;
            this.processUserInput.Click += new System.EventHandler(this.processUserInput_Click);
            // 
            // personInfoOutput
            // 
            this.personInfoOutput.AutoSize = true;
            this.personInfoOutput.Location = new System.Drawing.Point(147, 348);
            this.personInfoOutput.Name = "personInfoOutput";
            this.personInfoOutput.Size = new System.Drawing.Size(0, 17);
            this.personInfoOutput.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 546);
            this.Controls.Add(this.personInfoOutput);
            this.Controls.Add(this.processUserInput);
            this.Controls.Add(this.zipCodeBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.userIdBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateOfBirthBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ssnBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transactionBox);
            this.Controls.Add(this.processTransactionInput);
            this.Controls.Add(this.inputTransactionAmount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTransactionAmount;
        private System.Windows.Forms.Button processTransactionInput;
        private System.Windows.Forms.ListBox transactionBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ssnBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateOfBirthBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox zipCodeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button processUserInput;
        private System.Windows.Forms.Label personInfoOutput;
    }
}


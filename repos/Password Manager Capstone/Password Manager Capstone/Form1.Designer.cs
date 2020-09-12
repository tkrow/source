namespace Password_Manager_Capstone
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.infoGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.siteList = new System.Windows.Forms.ListBox();
            this.siteLbl = new System.Windows.Forms.Label();
            this.siteBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.acceptPassBtn = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.CheckBox();
            this.symbolBox = new System.Windows.Forms.CheckBox();
            this.lowerBox = new System.Windows.Forms.CheckBox();
            this.upperBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.finishedPassBox = new System.Windows.Forms.RichTextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.infoGrid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.passLbl);
            this.groupBox1.Controls.Add(this.passBox);
            this.groupBox1.Controls.Add(this.emailLbl);
            this.groupBox1.Controls.Add(this.emailBox);
            this.groupBox1.Controls.Add(this.nameLbl);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.siteList);
            this.groupBox1.Controls.Add(this.siteLbl);
            this.groupBox1.Controls.Add(this.siteBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 607);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Manager";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(22, 356);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(110, 43);
            this.editBtn.TabIndex = 15;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(139, 306);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 92);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete File";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // infoGrid
            // 
            this.infoGrid.AllowUserToAddRows = false;
            this.infoGrid.AllowUserToDeleteRows = false;
            this.infoGrid.AllowUserToResizeColumns = false;
            this.infoGrid.AllowUserToResizeRows = false;
            this.infoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoGrid.Location = new System.Drawing.Point(22, 443);
            this.infoGrid.Name = "infoGrid";
            this.infoGrid.ReadOnly = true;
            this.infoGrid.RowHeadersVisible = false;
            this.infoGrid.RowTemplate.Height = 24;
            this.infoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.infoGrid.Size = new System.Drawing.Size(436, 146);
            this.infoGrid.TabIndex = 13;
            this.infoGrid.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Information";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(22, 306);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(110, 43);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Websites";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(22, 254);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(69, 17);
            this.passLbl.TabIndex = 8;
            this.passLbl.Text = "Password";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(22, 277);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(217, 22);
            this.passBox.TabIndex = 3;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(22, 185);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 6;
            this.emailLbl.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(22, 208);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(217, 22);
            this.emailBox.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(22, 117);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(73, 17);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Username";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(22, 137);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(217, 22);
            this.nameBox.TabIndex = 1;
            // 
            // siteList
            // 
            this.siteList.FormattingEnabled = true;
            this.siteList.ItemHeight = 16;
            this.siteList.Location = new System.Drawing.Point(245, 74);
            this.siteList.Name = "siteList";
            this.siteList.Size = new System.Drawing.Size(213, 324);
            this.siteList.TabIndex = 4;
            this.siteList.SelectedIndexChanged += new System.EventHandler(this.siteList_SelectedIndexChanged);
            // 
            // siteLbl
            // 
            this.siteLbl.AutoSize = true;
            this.siteLbl.Location = new System.Drawing.Point(22, 51);
            this.siteLbl.Name = "siteLbl";
            this.siteLbl.Size = new System.Drawing.Size(59, 17);
            this.siteLbl.TabIndex = 1;
            this.siteLbl.Text = "Website";
            // 
            // siteBox
            // 
            this.siteBox.Location = new System.Drawing.Point(22, 74);
            this.siteBox.Name = "siteBox";
            this.siteBox.Size = new System.Drawing.Size(217, 22);
            this.siteBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.acceptPassBtn);
            this.groupBox2.Controls.Add(this.numberBox);
            this.groupBox2.Controls.Add(this.symbolBox);
            this.groupBox2.Controls.Add(this.lowerBox);
            this.groupBox2.Controls.Add(this.upperBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.finishedPassBox);
            this.groupBox2.Controls.Add(this.generateBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lengthBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(499, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 440);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password Generator";
            // 
            // acceptPassBtn
            // 
            this.acceptPassBtn.Location = new System.Drawing.Point(319, 125);
            this.acceptPassBtn.Name = "acceptPassBtn";
            this.acceptPassBtn.Size = new System.Drawing.Size(140, 48);
            this.acceptPassBtn.TabIndex = 26;
            this.acceptPassBtn.Text = "Accept Password";
            this.acceptPassBtn.UseVisualStyleBackColor = true;
            this.acceptPassBtn.Click += new System.EventHandler(this.acceptPassBtn_Click);
            // 
            // numberBox
            // 
            this.numberBox.AutoSize = true;
            this.numberBox.Location = new System.Drawing.Point(19, 152);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(87, 21);
            this.numberBox.TabIndex = 25;
            this.numberBox.Text = "Numbers";
            this.numberBox.UseVisualStyleBackColor = true;
            // 
            // symbolBox
            // 
            this.symbolBox.AutoSize = true;
            this.symbolBox.Location = new System.Drawing.Point(19, 125);
            this.symbolBox.Name = "symbolBox";
            this.symbolBox.Size = new System.Drawing.Size(83, 21);
            this.symbolBox.TabIndex = 24;
            this.symbolBox.Text = "Symbols";
            this.symbolBox.UseVisualStyleBackColor = true;
            // 
            // lowerBox
            // 
            this.lowerBox.AutoSize = true;
            this.lowerBox.Location = new System.Drawing.Point(19, 98);
            this.lowerBox.Name = "lowerBox";
            this.lowerBox.Size = new System.Drawing.Size(146, 21);
            this.lowerBox.TabIndex = 23;
            this.lowerBox.Text = "Lowercase Letters";
            this.lowerBox.UseVisualStyleBackColor = true;
            // 
            // upperBox
            // 
            this.upperBox.AutoSize = true;
            this.upperBox.Location = new System.Drawing.Point(19, 71);
            this.upperBox.Name = "upperBox";
            this.upperBox.Size = new System.Drawing.Size(147, 21);
            this.upperBox.TabIndex = 22;
            this.upperBox.Text = "Uppercase Letters";
            this.upperBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Finished Password";
            // 
            // finishedPassBox
            // 
            this.finishedPassBox.Location = new System.Drawing.Point(19, 208);
            this.finishedPassBox.Name = "finishedPassBox";
            this.finishedPassBox.ReadOnly = true;
            this.finishedPassBox.Size = new System.Drawing.Size(440, 213);
            this.finishedPassBox.TabIndex = 20;
            this.finishedPassBox.Text = "";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(319, 71);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(140, 48);
            this.generateBtn.TabIndex = 16;
            this.generateBtn.Text = "Generate Password";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password Size";
            // 
            // lengthBox
            // 
            this.lengthBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lengthBox.Location = new System.Drawing.Point(231, 75);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(66, 22);
            this.lengthBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Character Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ListBox siteList;
        private System.Windows.Forms.Label siteLbl;
        private System.Windows.Forms.TextBox siteBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView infoGrid;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lengthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.RichTextBox finishedPassBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox numberBox;
        private System.Windows.Forms.CheckBox symbolBox;
        private System.Windows.Forms.CheckBox lowerBox;
        private System.Windows.Forms.CheckBox upperBox;
        private System.Windows.Forms.Button acceptPassBtn;
    }
}


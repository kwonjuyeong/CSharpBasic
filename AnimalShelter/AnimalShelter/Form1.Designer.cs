namespace AnimalShelter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreateCustomer = new Button();
            CusDetailPanel = new Panel();
            CusIsQualified = new Label();
            label2 = new Label();
            CusDescription = new Label();
            label6 = new Label();
            CusAddress = new Label();
            label5 = new Label();
            CusAge = new Label();
            label4 = new Label();
            CusFullName = new Label();
            label3 = new Label();
            CusNewPanel = new Panel();
            CusNewDescription = new TextBox();
            label10 = new Label();
            CusNewAddress = new TextBox();
            label9 = new Label();
            CusNewBirthday = new TextBox();
            label8 = new Label();
            CusNewFirstName = new TextBox();
            label7 = new Label();
            CusNewLastName = new TextBox();
            label1 = new Label();
            CustomerList = new ListBox();
            CusDetailPanel.SuspendLayout();
            CusNewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CreateCustomer
            // 
            CreateCustomer.Location = new Point(199, 341);
            CreateCustomer.Name = "CreateCustomer";
            CreateCustomer.Size = new Size(135, 38);
            CreateCustomer.TabIndex = 0;
            CreateCustomer.Text = "입양자 생성";
            CreateCustomer.UseVisualStyleBackColor = true;
            CreateCustomer.Click += CreateCustomer_Click;
            // 
            // CusDetailPanel
            // 
            CusDetailPanel.Controls.Add(CusIsQualified);
            CusDetailPanel.Controls.Add(label2);
            CusDetailPanel.Controls.Add(CusDescription);
            CusDetailPanel.Controls.Add(label6);
            CusDetailPanel.Controls.Add(CusAddress);
            CusDetailPanel.Controls.Add(label5);
            CusDetailPanel.Controls.Add(CusAge);
            CusDetailPanel.Controls.Add(label4);
            CusDetailPanel.Controls.Add(CusFullName);
            CusDetailPanel.Controls.Add(label3);
            CusDetailPanel.Location = new Point(535, 23);
            CusDetailPanel.Name = "CusDetailPanel";
            CusDetailPanel.Size = new Size(287, 391);
            CusDetailPanel.TabIndex = 1;
            // 
            // CusIsQualified
            // 
            CusIsQualified.AutoSize = true;
            CusIsQualified.Location = new Point(84, 72);
            CusIsQualified.Name = "CusIsQualified";
            CusIsQualified.Size = new Size(39, 15);
            CusIsQualified.TabIndex = 11;
            CusIsQualified.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 72);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 10;
            label2.Text = "입양가능";
            // 
            // CusDescription
            // 
            CusDescription.AutoSize = true;
            CusDescription.Location = new Point(84, 123);
            CusDescription.Name = "CusDescription";
            CusDescription.Size = new Size(39, 15);
            CusDescription.TabIndex = 9;
            CusDescription.Text = "label2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 123);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 8;
            label6.Text = "설명";
            // 
            // CusAddress
            // 
            CusAddress.AutoSize = true;
            CusAddress.Location = new Point(84, 97);
            CusAddress.Name = "CusAddress";
            CusAddress.Size = new Size(39, 15);
            CusAddress.TabIndex = 7;
            CusAddress.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 97);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 6;
            label5.Text = "주소";
            // 
            // CusAge
            // 
            CusAge.AutoSize = true;
            CusAge.Location = new Point(84, 48);
            CusAge.Name = "CusAge";
            CusAge.Size = new Size(39, 15);
            CusAge.TabIndex = 5;
            CusAge.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 48);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "나이";
            // 
            // CusFullName
            // 
            CusFullName.AutoSize = true;
            CusFullName.Location = new Point(84, 23);
            CusFullName.Name = "CusFullName";
            CusFullName.Size = new Size(39, 15);
            CusFullName.TabIndex = 3;
            CusFullName.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 23);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "이름";
            // 
            // CusNewPanel
            // 
            CusNewPanel.Controls.Add(CusNewDescription);
            CusNewPanel.Controls.Add(label10);
            CusNewPanel.Controls.Add(CreateCustomer);
            CusNewPanel.Controls.Add(CusNewAddress);
            CusNewPanel.Controls.Add(label9);
            CusNewPanel.Controls.Add(CusNewBirthday);
            CusNewPanel.Controls.Add(label8);
            CusNewPanel.Controls.Add(CusNewFirstName);
            CusNewPanel.Controls.Add(label7);
            CusNewPanel.Controls.Add(CusNewLastName);
            CusNewPanel.Controls.Add(label1);
            CusNewPanel.Location = new Point(169, 23);
            CusNewPanel.Name = "CusNewPanel";
            CusNewPanel.Size = new Size(348, 391);
            CusNewPanel.TabIndex = 2;
            // 
            // CusNewDescription
            // 
            CusNewDescription.Location = new Point(57, 137);
            CusNewDescription.Multiline = true;
            CusNewDescription.Name = "CusNewDescription";
            CusNewDescription.Size = new Size(277, 190);
            CusNewDescription.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 137);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 8;
            label10.Text = "설명";
            // 
            // CusNewAddress
            // 
            CusNewAddress.Location = new Point(57, 104);
            CusNewAddress.Name = "CusNewAddress";
            CusNewAddress.Size = new Size(277, 23);
            CusNewAddress.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 108);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 6;
            label9.Text = "주소";
            // 
            // CusNewBirthday
            // 
            CusNewBirthday.Location = new Point(57, 75);
            CusNewBirthday.Name = "CusNewBirthday";
            CusNewBirthday.Size = new Size(108, 23);
            CusNewBirthday.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 79);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 4;
            label8.Text = "생일";
            // 
            // CusNewFirstName
            // 
            CusNewFirstName.Location = new Point(57, 46);
            CusNewFirstName.Name = "CusNewFirstName";
            CusNewFirstName.Size = new Size(108, 23);
            CusNewFirstName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 50);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 2;
            label7.Text = "이름";
            // 
            // CusNewLastName
            // 
            CusNewLastName.Location = new Point(57, 16);
            CusNewLastName.Name = "CusNewLastName";
            CusNewLastName.Size = new Size(108, 23);
            CusNewLastName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 0;
            label1.Text = "성";
            // 
            // CustomerList
            // 
            CustomerList.FormattingEnabled = true;
            CustomerList.ItemHeight = 15;
            CustomerList.Location = new Point(12, 23);
            CustomerList.Name = "CustomerList";
            CustomerList.Size = new Size(151, 394);
            CustomerList.TabIndex = 3;
            CustomerList.Click += CustomerList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 435);
            Controls.Add(CustomerList);
            Controls.Add(CusNewPanel);
            Controls.Add(CusDetailPanel);
            Name = "Form1";
            Text = "Form1";
            CusDetailPanel.ResumeLayout(false);
            CusDetailPanel.PerformLayout();
            CusNewPanel.ResumeLayout(false);
            CusNewPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CreateCustomer;
        private Panel CusDetailPanel;
        private Label CusDescription;
        private Label label6;
        private Label CusAddress;
        private Label label5;
        private Label CusAge;
        private Label label4;
        private Label CusFullName;
        private Label label3;
        private Label CusIsQualified;
        private Label label2;
        private Panel CusNewPanel;
        private TextBox CusNewDescription;
        private Label label10;
        private TextBox CusNewAddress;
        private Label label9;
        private TextBox CusNewBirthday;
        private Label label8;
        private TextBox CusNewFirstName;
        private Label label7;
        private TextBox CusNewLastName;
        private Label label1;
        private ListBox CustomerList;
    }
}

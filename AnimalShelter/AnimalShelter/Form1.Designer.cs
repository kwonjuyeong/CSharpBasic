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
            CusDescription = new Label();
            label6 = new Label();
            CusAddress = new Label();
            label5 = new Label();
            CusAge = new Label();
            label4 = new Label();
            CusFullName = new Label();
            label3 = new Label();
            CusIsQualified = new Label();
            label2 = new Label();
            CusDetailPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CreateCustomer
            // 
            CreateCustomer.Location = new Point(29, 24);
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
            CusDetailPanel.Location = new Point(323, 24);
            CusDetailPanel.Name = "CusDetailPanel";
            CusDetailPanel.Size = new Size(257, 391);
            CusDetailPanel.TabIndex = 1;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 436);
            Controls.Add(CusDetailPanel);
            Controls.Add(CreateCustomer);
            Name = "Form1";
            Text = "Form1";
            CusDetailPanel.ResumeLayout(false);
            CusDetailPanel.PerformLayout();
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
    }
}

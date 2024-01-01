namespace HelloCsharpwin
{
    partial class Calculator
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
            HelloLabel = new Label();
            Sum2 = new TextBox();
            Sum1 = new TextBox();
            SumNumbers = new Button();
            SumResult = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // HelloLabel
            // 
            HelloLabel.AutoSize = true;
            HelloLabel.Location = new Point(33, 38);
            HelloLabel.Name = "HelloLabel";
            HelloLabel.Size = new Size(107, 15);
            HelloLabel.TabIndex = 0;
            HelloLabel.Text = "여기를 클릭하세요";
            HelloLabel.Click += HelloLabel_Click;
            // 
            // Sum2
            // 
            Sum2.Location = new Point(165, 83);
            Sum2.Name = "Sum2";
            Sum2.Size = new Size(100, 23);
            Sum2.TabIndex = 1;
            // 
            // Sum1
            // 
            Sum1.Location = new Point(33, 84);
            Sum1.Name = "Sum1";
            Sum1.Size = new Size(100, 23);
            Sum1.TabIndex = 2;
            // 
            // SumNumbers
            // 
            SumNumbers.Location = new Point(290, 83);
            SumNumbers.Name = "SumNumbers";
            SumNumbers.Size = new Size(75, 23);
            SumNumbers.TabIndex = 3;
            SumNumbers.Text = "=";
            SumNumbers.UseVisualStyleBackColor = true;
            SumNumbers.Click += SumNumbers_Click;
            // 
            // SumResult
            // 
            SumResult.Location = new Point(391, 83);
            SumResult.Name = "SumResult";
            SumResult.Size = new Size(102, 23);
            SumResult.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 88);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 5;
            label1.Text = "+";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(SumResult);
            Controls.Add(SumNumbers);
            Controls.Add(Sum1);
            Controls.Add(Sum2);
            Controls.Add(HelloLabel);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloLabel;
        private TextBox Sum2;
        private TextBox Sum1;
        private Button SumNumbers;
        private TextBox SumResult;
        private Label label1;
    }
}

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
            Num1 = new Button();
            Num2 = new Button();
            NumScreen = new Label();
            plus = new Button();
            Num3 = new Button();
            Num4 = new Button();
            Num5 = new Button();
            Num6 = new Button();
            Num7 = new Button();
            Num8 = new Button();
            Num9 = new Button();
            Num0 = new Button();
            minus = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dot = new Button();
            switchPM = new Button();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.BackColor = Color.White;
            Num1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num1.Location = new Point(12, 300);
            Num1.Name = "Num1";
            Num1.Size = new Size(85, 55);
            Num1.TabIndex = 0;
            Num1.Text = "1";
            Num1.UseVisualStyleBackColor = false;
            Num1.Click += NumButton1_Click;
            // 
            // Num2
            // 
            Num2.BackColor = Color.White;
            Num2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num2.Location = new Point(101, 300);
            Num2.Name = "Num2";
            Num2.Size = new Size(85, 55);
            Num2.TabIndex = 1;
            Num2.Text = "2";
            Num2.UseVisualStyleBackColor = false;
            Num2.Click += NumButton2_Click;
            // 
            // NumScreen
            // 
            NumScreen.BackColor = Color.White;
            NumScreen.BorderStyle = BorderStyle.Fixed3D;
            NumScreen.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            NumScreen.Location = new Point(12, 21);
            NumScreen.Name = "NumScreen";
            NumScreen.Size = new Size(357, 69);
            NumScreen.TabIndex = 2;
            NumScreen.Text = "0";
            NumScreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // plus
            // 
            plus.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            plus.Location = new Point(284, 300);
            plus.Name = "plus";
            plus.Size = new Size(85, 55);
            plus.TabIndex = 3;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += NumPlus_Click;
            // 
            // Num3
            // 
            Num3.BackColor = Color.White;
            Num3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num3.Location = new Point(192, 300);
            Num3.Name = "Num3";
            Num3.Size = new Size(85, 55);
            Num3.TabIndex = 4;
            Num3.Text = "3";
            Num3.UseVisualStyleBackColor = false;
            Num3.Click += Num3_Click;
            // 
            // Num4
            // 
            Num4.BackColor = Color.White;
            Num4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num4.Location = new Point(12, 241);
            Num4.Name = "Num4";
            Num4.Size = new Size(85, 55);
            Num4.TabIndex = 5;
            Num4.Text = "4";
            Num4.UseVisualStyleBackColor = false;
            Num4.Click += Num4_Click;
            // 
            // Num5
            // 
            Num5.BackColor = Color.White;
            Num5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num5.Location = new Point(101, 241);
            Num5.Name = "Num5";
            Num5.Size = new Size(85, 55);
            Num5.TabIndex = 6;
            Num5.Text = "5";
            Num5.UseVisualStyleBackColor = false;
            Num5.Click += Num5_Click;
            // 
            // Num6
            // 
            Num6.BackColor = Color.White;
            Num6.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num6.Location = new Point(191, 241);
            Num6.Name = "Num6";
            Num6.Size = new Size(85, 55);
            Num6.TabIndex = 7;
            Num6.Text = "6";
            Num6.UseVisualStyleBackColor = false;
            Num6.Click += Num6_Click;
            // 
            // Num7
            // 
            Num7.BackColor = Color.White;
            Num7.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num7.Location = new Point(12, 180);
            Num7.Name = "Num7";
            Num7.Size = new Size(85, 55);
            Num7.TabIndex = 8;
            Num7.Text = "7";
            Num7.UseVisualStyleBackColor = false;
            Num7.Click += Num7_Click;
            // 
            // Num8
            // 
            Num8.BackColor = Color.White;
            Num8.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num8.Location = new Point(101, 180);
            Num8.Name = "Num8";
            Num8.Size = new Size(85, 55);
            Num8.TabIndex = 9;
            Num8.Text = "8";
            Num8.UseVisualStyleBackColor = false;
            Num8.Click += Num8_Click;
            // 
            // Num9
            // 
            Num9.BackColor = Color.White;
            Num9.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num9.Location = new Point(191, 180);
            Num9.Name = "Num9";
            Num9.Size = new Size(85, 55);
            Num9.TabIndex = 10;
            Num9.Text = "9";
            Num9.UseVisualStyleBackColor = false;
            Num9.Click += Num9_Click;
            // 
            // Num0
            // 
            Num0.BackColor = Color.White;
            Num0.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num0.Location = new Point(101, 360);
            Num0.Name = "Num0";
            Num0.Size = new Size(85, 55);
            Num0.TabIndex = 11;
            Num0.Text = "0";
            Num0.UseVisualStyleBackColor = false;
            Num0.Click += Num0_Click;
            // 
            // minus
            // 
            minus.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            minus.Location = new Point(284, 241);
            minus.Name = "minus";
            minus.Size = new Size(85, 55);
            minus.TabIndex = 12;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(284, 360);
            button1.Name = "button1";
            button1.Size = new Size(85, 55);
            button1.TabIndex = 13;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button2.Location = new Point(284, 180);
            button2.Name = "button2";
            button2.Size = new Size(85, 55);
            button2.TabIndex = 14;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button3.Location = new Point(284, 120);
            button3.Name = "button3";
            button3.Size = new Size(85, 55);
            button3.TabIndex = 15;
            button3.Text = "%";
            button3.UseVisualStyleBackColor = true;
            // 
            // dot
            // 
            dot.BackColor = Color.White;
            dot.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            dot.Location = new Point(192, 360);
            dot.Name = "dot";
            dot.Size = new Size(85, 55);
            dot.TabIndex = 16;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            // 
            // switchPM
            // 
            switchPM.BackColor = Color.White;
            switchPM.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            switchPM.Location = new Point(12, 359);
            switchPM.Name = "switchPM";
            switchPM.Size = new Size(85, 55);
            switchPM.TabIndex = 17;
            switchPM.Text = "+/-";
            switchPM.UseVisualStyleBackColor = false;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(388, 429);
            Controls.Add(switchPM);
            Controls.Add(dot);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(minus);
            Controls.Add(Num0);
            Controls.Add(Num9);
            Controls.Add(Num8);
            Controls.Add(Num7);
            Controls.Add(Num6);
            Controls.Add(Num5);
            Controls.Add(Num4);
            Controls.Add(Num3);
            Controls.Add(plus);
            Controls.Add(NumScreen);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Num1;
        private Button Num2;
        private Label NumScreen;
        private Button plus;
        private Button Num3;
        private Button Num4;
        private Button Num5;
        private Button Num6;
        private Button Num7;
        private Button Num8;
        private Button Num9;
        private Button Num0;
        private Button minus;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button dot;
        private Button switchPM;
    }
}

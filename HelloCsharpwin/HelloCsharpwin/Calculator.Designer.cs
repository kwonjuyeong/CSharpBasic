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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            Num1 = new Button();
            Num2 = new Button();
            NumScreen = new Label();
            plusBtn = new Button();
            Num3 = new Button();
            Num4 = new Button();
            Num5 = new Button();
            Num6 = new Button();
            Num7 = new Button();
            Num8 = new Button();
            Num9 = new Button();
            Num0 = new Button();
            minusBtn = new Button();
            equalsBtn = new Button();
            multiplyBtn = new Button();
            divBtn = new Button();
            dotBtn = new Button();
            switchPM = new Button();
            ClearBtn = new Button();
            rootBtn = new Button();
            SqrBtn = new Button();
            OneOverXBtn = new Button();
            backBtn = new Button();
            CEBtn = new Button();
            PercentBtn = new Button();
            expressionScreen = new Label();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.BackColor = Color.White;
            Num1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num1.Location = new Point(10, 365);
            Num1.Name = "Num1";
            Num1.Size = new Size(85, 55);
            Num1.TabIndex = 0;
            Num1.Text = "1";
            Num1.UseVisualStyleBackColor = false;
            Num1.Click += NumButton_Click;
            Num1.KeyDown += Calculator_KeyDown;
            // 
            // Num2
            // 
            Num2.BackColor = Color.White;
            Num2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num2.Location = new Point(100, 365);
            Num2.Name = "Num2";
            Num2.Size = new Size(85, 55);
            Num2.TabIndex = 1;
            Num2.Text = "2";
            Num2.UseVisualStyleBackColor = false;
            Num2.Click += NumButton_Click;
            Num2.KeyDown += Calculator_KeyDown;
            // 
            // NumScreen
            // 
            NumScreen.BackColor = Color.White;
            NumScreen.BorderStyle = BorderStyle.Fixed3D;
            NumScreen.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            NumScreen.Location = new Point(10, 55);
            NumScreen.Name = "NumScreen";
            NumScreen.Size = new Size(355, 61);
            NumScreen.TabIndex = 2;
            NumScreen.Text = "0";
            NumScreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // plusBtn
            // 
            plusBtn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            plusBtn.Location = new Point(280, 365);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(85, 55);
            plusBtn.TabIndex = 3;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = true;
            plusBtn.Click += OptBtn_Click;
            plusBtn.KeyDown += Calculator_KeyDown;
            // 
            // Num3
            // 
            Num3.BackColor = Color.White;
            Num3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num3.Location = new Point(190, 365);
            Num3.Name = "Num3";
            Num3.Size = new Size(85, 55);
            Num3.TabIndex = 4;
            Num3.Text = "3";
            Num3.UseVisualStyleBackColor = false;
            Num3.Click += NumButton_Click;
            Num3.KeyDown += Calculator_KeyDown;
            // 
            // Num4
            // 
            Num4.BackColor = Color.White;
            Num4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num4.Location = new Point(10, 305);
            Num4.Name = "Num4";
            Num4.Size = new Size(85, 55);
            Num4.TabIndex = 5;
            Num4.Text = "4";
            Num4.UseVisualStyleBackColor = false;
            Num4.Click += NumButton_Click;
            Num4.KeyDown += Calculator_KeyDown;
            // 
            // Num5
            // 
            Num5.BackColor = Color.White;
            Num5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num5.Location = new Point(100, 305);
            Num5.Name = "Num5";
            Num5.Size = new Size(85, 55);
            Num5.TabIndex = 6;
            Num5.Text = "5";
            Num5.UseVisualStyleBackColor = false;
            Num5.Click += NumButton_Click;
            Num5.KeyDown += Calculator_KeyDown;
            // 
            // Num6
            // 
            Num6.BackColor = Color.White;
            Num6.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num6.Location = new Point(190, 305);
            Num6.Name = "Num6";
            Num6.Size = new Size(85, 55);
            Num6.TabIndex = 7;
            Num6.Text = "6";
            Num6.UseVisualStyleBackColor = false;
            Num6.Click += NumButton_Click;
            Num6.KeyDown += Calculator_KeyDown;
            // 
            // Num7
            // 
            Num7.BackColor = Color.White;
            Num7.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num7.Location = new Point(10, 245);
            Num7.Name = "Num7";
            Num7.Size = new Size(85, 55);
            Num7.TabIndex = 8;
            Num7.Text = "7";
            Num7.UseVisualStyleBackColor = false;
            Num7.Click += NumButton_Click;
            Num7.KeyDown += Calculator_KeyDown;
            // 
            // Num8
            // 
            Num8.BackColor = Color.White;
            Num8.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num8.Location = new Point(100, 245);
            Num8.Name = "Num8";
            Num8.Size = new Size(85, 55);
            Num8.TabIndex = 9;
            Num8.Text = "8";
            Num8.UseVisualStyleBackColor = false;
            Num8.Click += NumButton_Click;
            Num8.KeyDown += Calculator_KeyDown;
            // 
            // Num9
            // 
            Num9.BackColor = Color.White;
            Num9.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num9.Location = new Point(190, 245);
            Num9.Name = "Num9";
            Num9.Size = new Size(85, 55);
            Num9.TabIndex = 10;
            Num9.Text = "9";
            Num9.UseVisualStyleBackColor = false;
            Num9.Click += NumButton_Click;
            Num9.KeyDown += Calculator_KeyDown;
            // 
            // Num0
            // 
            Num0.BackColor = Color.White;
            Num0.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            Num0.Location = new Point(100, 425);
            Num0.Name = "Num0";
            Num0.Size = new Size(85, 55);
            Num0.TabIndex = 11;
            Num0.Text = "0";
            Num0.UseVisualStyleBackColor = false;
            Num0.Click += NumButton_Click;
            Num0.KeyDown += Calculator_KeyDown;
            // 
            // minusBtn
            // 
            minusBtn.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold);
            minusBtn.Location = new Point(280, 305);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(85, 55);
            minusBtn.TabIndex = 12;
            minusBtn.Text = "-";
            minusBtn.UseVisualStyleBackColor = true;
            minusBtn.Click += OptBtn_Click;
            minusBtn.KeyDown += Calculator_KeyDown;
            // 
            // equalsBtn
            // 
            equalsBtn.BackColor = Color.Black;
            equalsBtn.FlatStyle = FlatStyle.Flat;
            equalsBtn.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            equalsBtn.ForeColor = SystemColors.ButtonHighlight;
            equalsBtn.Location = new Point(280, 425);
            equalsBtn.Name = "equalsBtn";
            equalsBtn.Size = new Size(85, 55);
            equalsBtn.TabIndex = 13;
            equalsBtn.Text = "=";
            equalsBtn.UseVisualStyleBackColor = false;
            equalsBtn.Click += OptBtn_Click;
            equalsBtn.KeyDown += Calculator_KeyDown;
            // 
            // multiplyBtn
            // 
            multiplyBtn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            multiplyBtn.Location = new Point(280, 245);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(85, 55);
            multiplyBtn.TabIndex = 14;
            multiplyBtn.Text = "x";
            multiplyBtn.UseVisualStyleBackColor = true;
            multiplyBtn.Click += OptBtn_Click;
            multiplyBtn.KeyDown += Calculator_KeyDown;
            // 
            // divBtn
            // 
            divBtn.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold);
            divBtn.Location = new Point(280, 185);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(85, 55);
            divBtn.TabIndex = 15;
            divBtn.Text = "÷";
            divBtn.UseVisualStyleBackColor = true;
            divBtn.Click += OptBtn_Click;
            divBtn.KeyDown += Calculator_KeyDown;
            // 
            // dotBtn
            // 
            dotBtn.BackColor = Color.White;
            dotBtn.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            dotBtn.Location = new Point(190, 425);
            dotBtn.Name = "dotBtn";
            dotBtn.Size = new Size(85, 55);
            dotBtn.TabIndex = 16;
            dotBtn.Text = ".";
            dotBtn.UseVisualStyleBackColor = false;
            dotBtn.Click += dotBtn_Click;
            dotBtn.KeyDown += Calculator_KeyDown;
            // 
            // switchPM
            // 
            switchPM.BackColor = Color.White;
            switchPM.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            switchPM.Location = new Point(10, 425);
            switchPM.Name = "switchPM";
            switchPM.Size = new Size(85, 55);
            switchPM.TabIndex = 17;
            switchPM.Text = "+/-";
            switchPM.UseVisualStyleBackColor = false;
            switchPM.Click += switchPM_Click;
            switchPM.KeyDown += Calculator_KeyDown;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            ClearBtn.Location = new Point(190, 125);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(85, 55);
            ClearBtn.TabIndex = 18;
            ClearBtn.Text = "C";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            ClearBtn.KeyDown += Calculator_KeyDown;
            // 
            // rootBtn
            // 
            rootBtn.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rootBtn.Location = new Point(190, 185);
            rootBtn.Name = "rootBtn";
            rootBtn.Size = new Size(85, 55);
            rootBtn.TabIndex = 19;
            rootBtn.Text = "²√𝓍";
            rootBtn.UseVisualStyleBackColor = true;
            rootBtn.Click += rootBtn_Click;
            rootBtn.KeyDown += Calculator_KeyDown;
            // 
            // SqrBtn
            // 
            SqrBtn.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            SqrBtn.Location = new Point(100, 185);
            SqrBtn.Name = "SqrBtn";
            SqrBtn.Size = new Size(85, 55);
            SqrBtn.TabIndex = 20;
            SqrBtn.Text = "𝓍²";
            SqrBtn.UseVisualStyleBackColor = true;
            SqrBtn.Click += SqrBtn_Click;
            SqrBtn.KeyDown += Calculator_KeyDown;
            // 
            // OneOverXBtn
            // 
            OneOverXBtn.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            OneOverXBtn.Location = new Point(10, 185);
            OneOverXBtn.Name = "OneOverXBtn";
            OneOverXBtn.Size = new Size(85, 55);
            OneOverXBtn.TabIndex = 21;
            OneOverXBtn.Text = "1/𝓍";
            OneOverXBtn.UseVisualStyleBackColor = true;
            OneOverXBtn.Click += OneOverXBtn_Click;
            OneOverXBtn.KeyDown += Calculator_KeyDown;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(280, 125);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(85, 55);
            backBtn.TabIndex = 22;
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            backBtn.KeyDown += Calculator_KeyDown;
            // 
            // CEBtn
            // 
            CEBtn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            CEBtn.Location = new Point(100, 125);
            CEBtn.Name = "CEBtn";
            CEBtn.Size = new Size(85, 55);
            CEBtn.TabIndex = 23;
            CEBtn.Text = "CE";
            CEBtn.UseVisualStyleBackColor = true;
            CEBtn.Click += CEBtn_Click;
            CEBtn.KeyDown += Calculator_KeyDown;
            // 
            // PercentBtn
            // 
            PercentBtn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            PercentBtn.Location = new Point(10, 125);
            PercentBtn.Name = "PercentBtn";
            PercentBtn.Size = new Size(85, 55);
            PercentBtn.TabIndex = 24;
            PercentBtn.Text = "%";
            PercentBtn.UseVisualStyleBackColor = true;
            PercentBtn.Click += PercentBtn_Click;
            PercentBtn.KeyDown += Calculator_KeyDown;
            // 
            // expressionScreen
            // 
            expressionScreen.BackColor = Color.Black;
            expressionScreen.BorderStyle = BorderStyle.Fixed3D;
            expressionScreen.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            expressionScreen.ForeColor = SystemColors.HighlightText;
            expressionScreen.Location = new Point(10, 15);
            expressionScreen.Name = "expressionScreen";
            expressionScreen.Size = new Size(355, 40);
            expressionScreen.TabIndex = 25;
            expressionScreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(378, 497);
            Controls.Add(expressionScreen);
            Controls.Add(PercentBtn);
            Controls.Add(CEBtn);
            Controls.Add(backBtn);
            Controls.Add(OneOverXBtn);
            Controls.Add(SqrBtn);
            Controls.Add(rootBtn);
            Controls.Add(ClearBtn);
            Controls.Add(switchPM);
            Controls.Add(dotBtn);
            Controls.Add(divBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(equalsBtn);
            Controls.Add(minusBtn);
            Controls.Add(Num0);
            Controls.Add(Num9);
            Controls.Add(Num8);
            Controls.Add(Num7);
            Controls.Add(Num6);
            Controls.Add(Num5);
            Controls.Add(Num4);
            Controls.Add(Num3);
            Controls.Add(plusBtn);
            Controls.Add(NumScreen);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Name = "Calculator";
            Text = "계산기";
            ResumeLayout(false);
        }

        #endregion

        private Button Num1;
        private Button Num2;
        private Label NumScreen;
        private Button plusBtn;
        private Button Num3;
        private Button Num4;
        private Button Num5;
        private Button Num6;
        private Button Num7;
        private Button Num8;
        private Button Num9;
        private Button Num0;
        private Button minusBtn;
        private Button equalsBtn;
        private Button multiplyBtn;
        private Button divBtn;
        private Button dotBtn;
        private Button switchPM;
        private Button ClearBtn;
        private Button rootBtn;
        private Button SqrBtn;
        private Button OneOverXBtn;
        private Button backBtn;
        private Button CEBtn;
        private Button PercentBtn;
        private Label expressionScreen;
    }
}

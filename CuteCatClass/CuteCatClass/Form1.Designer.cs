namespace CuteCatClass
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
            components = new System.ComponentModel.Container();
            CatScreen = new Label();
            Play = new Button();
            Feed = new Button();
            CatTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // CatScreen
            // 
            CatScreen.BorderStyle = BorderStyle.Fixed3D;
            CatScreen.Location = new Point(12, 9);
            CatScreen.Name = "CatScreen";
            CatScreen.Size = new Size(662, 51);
            CatScreen.TabIndex = 0;
            CatScreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Play
            // 
            Play.Font = new Font("맑은 고딕", 11.25F);
            Play.Location = new Point(12, 84);
            Play.Name = "Play";
            Play.Size = new Size(107, 50);
            Play.TabIndex = 1;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // Feed
            // 
            Feed.Font = new Font("맑은 고딕", 11.25F);
            Feed.Location = new Point(143, 84);
            Feed.Name = "Feed";
            Feed.Size = new Size(108, 50);
            Feed.TabIndex = 2;
            Feed.Text = "Feed";
            Feed.UseVisualStyleBackColor = true;
            Feed.Click += Feed_Click;
            // 
            // CatTimer
            // 
            CatTimer.Enabled = true;
            CatTimer.Interval = 5000;
            CatTimer.Tick += CatTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Feed);
            Controls.Add(Play);
            Controls.Add(CatScreen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label CatScreen;
        private Button Play;
        private Button Feed;
        private System.Windows.Forms.Timer CatTimer;
    }
}

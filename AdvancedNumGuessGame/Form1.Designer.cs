namespace AdvancedNumGuessGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.setPanel = new System.Windows.Forms.Panel();
            this.historyBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.difficultyBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.difficultyInfo = new System.Windows.Forms.Label();
            this.guessBtn = new System.Windows.Forms.Button();
            this.timeInfo = new System.Windows.Forms.Label();
            this.hint = new System.Windows.Forms.Label();
            this.guessBox = new System.Windows.Forms.MaskedTextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.scoreInfo = new System.Windows.Forms.Label();
            this.inGamePanel = new System.Windows.Forms.Panel();
            this.setPanel.SuspendLayout();
            this.inGamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // setPanel
            // 
            this.setPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.setPanel.Controls.Add(this.historyBtn);
            this.setPanel.Controls.Add(this.nameBox);
            this.setPanel.Controls.Add(this.label2);
            this.setPanel.Controls.Add(this.aboutBtn);
            this.setPanel.Controls.Add(this.startBtn);
            this.setPanel.Controls.Add(this.difficultyBox);
            this.setPanel.Controls.Add(this.label1);
            this.setPanel.Controls.Add(this.difficultyInfo);
            this.setPanel.Location = new System.Drawing.Point(0, 0);
            this.setPanel.Name = "setPanel";
            this.setPanel.Size = new System.Drawing.Size(403, 118);
            this.setPanel.TabIndex = 0;
            // 
            // historyBtn
            // 
            this.historyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.historyBtn.ForeColor = System.Drawing.Color.Black;
            this.historyBtn.Location = new System.Drawing.Point(309, 61);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(82, 23);
            this.historyBtn.TabIndex = 8;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(256, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(135, 23);
            this.nameBox.TabIndex = 7;
            this.nameBox.Text = "Player";
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your Name:";
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.aboutBtn.ForeColor = System.Drawing.Color.Black;
            this.aboutBtn.Location = new System.Drawing.Point(309, 88);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(82, 23);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.Control;
            this.startBtn.ForeColor = System.Drawing.Color.Black;
            this.startBtn.Location = new System.Drawing.Point(309, 35);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(82, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Play";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // difficultyBox
            // 
            this.difficultyBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.difficultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyBox.ForeColor = System.Drawing.Color.Black;
            this.difficultyBox.FormattingEnabled = true;
            this.difficultyBox.Items.AddRange(new object[] {
            "Baby Mode",
            "Kid Mode",
            "Easy",
            "Medium",
            "Hard",
            "Extreme",
            "Impossible"});
            this.difficultyBox.Location = new System.Drawing.Point(80, 6);
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(94, 23);
            this.difficultyBox.TabIndex = 2;
            this.difficultyBox.SelectedIndexChanged += new System.EventHandler(this.difficultyBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Difficulty:";
            // 
            // difficultyInfo
            // 
            this.difficultyInfo.AutoEllipsis = true;
            this.difficultyInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficultyInfo.ForeColor = System.Drawing.Color.White;
            this.difficultyInfo.Location = new System.Drawing.Point(12, 32);
            this.difficultyInfo.Name = "difficultyInfo";
            this.difficultyInfo.Size = new System.Drawing.Size(291, 81);
            this.difficultyInfo.TabIndex = 3;
            this.difficultyInfo.Text = "Number range: 1...10\r\nDuration: 300 Second (5 Min)\r\nWrong guess: -1 Second\r\nRight" +
    " guess: 1 Second";
            // 
            // guessBtn
            // 
            this.guessBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guessBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessBtn.ForeColor = System.Drawing.Color.Black;
            this.guessBtn.Location = new System.Drawing.Point(210, 11);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(181, 43);
            this.guessBtn.TabIndex = 5;
            this.guessBtn.Text = "Check your guess";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // timeInfo
            // 
            this.timeInfo.AutoSize = true;
            this.timeInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeInfo.ForeColor = System.Drawing.Color.Black;
            this.timeInfo.Location = new System.Drawing.Point(12, 134);
            this.timeInfo.Name = "timeInfo";
            this.timeInfo.Size = new System.Drawing.Size(217, 21);
            this.timeInfo.TabIndex = 6;
            this.timeInfo.Text = "Time remaining: 300 Second";
            // 
            // hint
            // 
            this.hint.AutoEllipsis = true;
            this.hint.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hint.ForeColor = System.Drawing.Color.Black;
            this.hint.Location = new System.Drawing.Point(12, 167);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(379, 114);
            this.hint.TabIndex = 7;
            this.hint.Text = "Guess a number";
            this.hint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessBox
            // 
            this.guessBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guessBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessBox.Location = new System.Drawing.Point(132, 11);
            this.guessBox.Mask = "0000";
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(72, 43);
            this.guessBox.TabIndex = 8;
            this.guessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guessBox.ValidatingType = typeof(int);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(12, 11);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(82, 43);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit Game";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // scoreInfo
            // 
            this.scoreInfo.AutoSize = true;
            this.scoreInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreInfo.ForeColor = System.Drawing.Color.Black;
            this.scoreInfo.Location = new System.Drawing.Point(12, 298);
            this.scoreInfo.Name = "scoreInfo";
            this.scoreInfo.Size = new System.Drawing.Size(106, 21);
            this.scoreInfo.TabIndex = 9;
            this.scoreInfo.Text = "Your Score: 0";
            // 
            // inGamePanel
            // 
            this.inGamePanel.BackColor = System.Drawing.SystemColors.Control;
            this.inGamePanel.Controls.Add(this.exitBtn);
            this.inGamePanel.Controls.Add(this.guessBox);
            this.inGamePanel.Controls.Add(this.guessBtn);
            this.inGamePanel.Enabled = false;
            this.inGamePanel.Location = new System.Drawing.Point(0, 333);
            this.inGamePanel.Name = "inGamePanel";
            this.inGamePanel.Size = new System.Drawing.Size(403, 70);
            this.inGamePanel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(403, 399);
            this.Controls.Add(this.inGamePanel);
            this.Controls.Add(this.scoreInfo);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.timeInfo);
            this.Controls.Add(this.setPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Number Guess Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.setPanel.ResumeLayout(false);
            this.setPanel.PerformLayout();
            this.inGamePanel.ResumeLayout(false);
            this.inGamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel setPanel;
        private Label difficultyInfo;
        private ComboBox difficultyBox;
        private Label label1;
        private Button startBtn;
        private Button guessBtn;
        private Label timeInfo;
        private Label hint;
        private Button aboutBtn;
        private MaskedTextBox guessBox;
        private Button exitBtn;
        private Label scoreInfo;
        private TextBox nameBox;
        private Label label2;
        private Button historyBtn;
        private Panel inGamePanel;
    }
}
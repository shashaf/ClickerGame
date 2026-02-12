namespace ClickerGame.Forms
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            btnClick = new Button();
            labelScore = new Label();
            btnUpgrade = new Button();
            btnBack = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Font = new Font("Comic Sans MS", 20F);
            btnClick.Location = new Point(317, 167);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(155, 83);
            btnClick.TabIndex = 0;
            btnClick.Text = "Кликай";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Comic Sans MS", 20F);
            labelScore.Location = new Point(327, 107);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(145, 47);
            labelScore.TabIndex = 1;
            labelScore.Text = "Очки: 0";
            // 
            // btnUpgrade
            // 
            btnUpgrade.Font = new Font("Comic Sans MS", 9F);
            btnUpgrade.Location = new Point(317, 272);
            btnUpgrade.Name = "btnUpgrade";
            btnUpgrade.Size = new Size(155, 29);
            btnUpgrade.TabIndex = 2;
            btnUpgrade.Text = "Улучшить: 10";
            btnUpgrade.UseVisualStyleBackColor = true;
            btnUpgrade.Click += btnUpgrade_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Comic Sans MS", 9F);
            btnBack.Location = new Point(655, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(133, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Назад в меню";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // gameTimer
            // 
            gameTimer.Tick += gameTimer_Tick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnUpgrade);
            Controls.Add(labelScore);
            Controls.Add(btnClick);
            Name = "GameForm";
            Text = "Click Click Click";
            FormClosed += GameForm_FormClosed;
            Load += GameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private Label labelScore;
        private Button btnUpgrade;
        private Button btnBack;
        private System.Windows.Forms.Timer gameTimer;
    }
}
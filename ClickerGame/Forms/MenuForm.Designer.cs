namespace ClickerGame
{
    partial class MenuForm
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
            btnStart = new Button();
            btnSettings = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(333, 156);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(139, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Начать игру";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += this.btnStart_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(333, 201);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(139, 29);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Настройки";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += this.btnSettings_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(333, 248);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 29);
            btnExit.TabIndex = 0;
            btnExit.Text = "Выйти из игры";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnSettings);
            Controls.Add(btnStart);
            Name = "MenuForm";
            Text = "Click Click Click";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnSettings;
        private Button btnExit;
    }
}

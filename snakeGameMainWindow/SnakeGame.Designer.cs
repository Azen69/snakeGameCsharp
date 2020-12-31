namespace snakeGameMainWindow
{
    partial class SnakeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeGame));
            this.startGameButton = new System.Windows.Forms.Button();
            this.snakeControl1 = new snakeControl.SnakeControl();
            this.optionsMenuButton = new System.Windows.Forms.Button();
            this.topResultButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Transparent;
            this.startGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startGameButton.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.Color.Yellow;
            this.startGameButton.Image = ((System.Drawing.Image)(resources.GetObject("startGameButton.Image")));
            this.startGameButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startGameButton.Location = new System.Drawing.Point(562, 37);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(184, 67);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // snakeControl1
            // 
            this.snakeControl1.AutoSize = true;
            this.snakeControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.snakeControl1.Location = new System.Drawing.Point(12, 12);
            this.snakeControl1.Name = "snakeControl1";
            this.snakeControl1.Size = new System.Drawing.Size(274, 403);
            this.snakeControl1.TabIndex = 0;
            // 
            // optionsMenuButton
            // 
            this.optionsMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.optionsMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.optionsMenuButton.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsMenuButton.ForeColor = System.Drawing.Color.Yellow;
            this.optionsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("optionsMenuButton.Image")));
            this.optionsMenuButton.Location = new System.Drawing.Point(562, 129);
            this.optionsMenuButton.Name = "optionsMenuButton";
            this.optionsMenuButton.Size = new System.Drawing.Size(184, 67);
            this.optionsMenuButton.TabIndex = 2;
            this.optionsMenuButton.Text = "OPTIONS";
            this.optionsMenuButton.UseVisualStyleBackColor = false;
            // 
            // topResultButton
            // 
            this.topResultButton.BackColor = System.Drawing.Color.Transparent;
            this.topResultButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topResultButton.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topResultButton.ForeColor = System.Drawing.Color.Yellow;
            this.topResultButton.Image = ((System.Drawing.Image)(resources.GetObject("topResultButton.Image")));
            this.topResultButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.topResultButton.Location = new System.Drawing.Point(562, 224);
            this.topResultButton.Name = "topResultButton";
            this.topResultButton.Size = new System.Drawing.Size(184, 67);
            this.topResultButton.TabIndex = 3;
            this.topResultButton.Text = "Top 10";
            this.topResultButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Yellow;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitButton.Location = new System.Drawing.Point(562, 316);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(184, 67);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.topResultButton);
            this.Controls.Add(this.optionsMenuButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.snakeControl1);
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGame by Mikolaj Wesolek";
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private snakeControl.SnakeControl snakeControl1;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button optionsMenuButton;
        private System.Windows.Forms.Button topResultButton;
        private System.Windows.Forms.Button exitButton;
    }
}


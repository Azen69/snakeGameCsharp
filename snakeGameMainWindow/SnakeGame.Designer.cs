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
            this.optionsMenuButton = new System.Windows.Forms.Button();
            this.topResultButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.resolutionBox = new System.Windows.Forms.ComboBox();
            this.speedBox = new System.Windows.Forms.ComboBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.wallBox = new System.Windows.Forms.CheckBox();
            this.saveOptions = new System.Windows.Forms.Button();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.BoardLabel = new System.Windows.Forms.Label();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxWhite = new System.Windows.Forms.PictureBox();
            this.snakeControl1 = new snakeControl.SnakeControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).BeginInit();
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            // optionsMenuButton
            // 
            this.optionsMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.optionsMenuButton.Click += new System.EventHandler(this.optionsMenuButton_Click);
            // 
            // topResultButton
            // 
            this.topResultButton.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainMenuButton.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.ForeColor = System.Drawing.Color.Yellow;
            this.mainMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("mainMenuButton.Image")));
            this.mainMenuButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainMenuButton.Location = new System.Drawing.Point(562, 37);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(184, 67);
            this.mainMenuButton.TabIndex = 5;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resolutionLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.resolutionLabel.Location = new System.Drawing.Point(506, 227);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(104, 18);
            this.resolutionLabel.TabIndex = 7;
            this.resolutionLabel.Text = "Resolution:";
            this.resolutionLabel.Visible = false;
            // 
            // resolutionBox
            // 
            this.resolutionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resolutionBox.BackColor = System.Drawing.Color.Black;
            this.resolutionBox.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionBox.ForeColor = System.Drawing.Color.White;
            this.resolutionBox.FormattingEnabled = true;
            this.resolutionBox.Location = new System.Drawing.Point(616, 224);
            this.resolutionBox.Name = "resolutionBox";
            this.resolutionBox.Size = new System.Drawing.Size(150, 26);
            this.resolutionBox.TabIndex = 8;
            this.resolutionBox.Visible = false;
            // 
            // speedBox
            // 
            this.speedBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedBox.BackColor = System.Drawing.Color.Black;
            this.speedBox.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedBox.ForeColor = System.Drawing.Color.White;
            this.speedBox.FormattingEnabled = true;
            this.speedBox.Location = new System.Drawing.Point(616, 265);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(150, 26);
            this.speedBox.TabIndex = 9;
            this.speedBox.Visible = false;
            // 
            // speedLabel
            // 
            this.speedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.speedLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.speedLabel.Location = new System.Drawing.Point(550, 268);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(60, 18);
            this.speedLabel.TabIndex = 10;
            this.speedLabel.Text = "Speed:";
            this.speedLabel.Visible = false;
            // 
            // wallBox
            // 
            this.wallBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wallBox.AutoSize = true;
            this.wallBox.BackColor = System.Drawing.Color.Black;
            this.wallBox.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallBox.ForeColor = System.Drawing.Color.White;
            this.wallBox.Location = new System.Drawing.Point(616, 310);
            this.wallBox.Name = "wallBox";
            this.wallBox.Size = new System.Drawing.Size(129, 22);
            this.wallBox.TabIndex = 11;
            this.wallBox.Text = "Wall Active";
            this.wallBox.UseVisualStyleBackColor = false;
            this.wallBox.Visible = false;
            // 
            // saveOptions
            // 
            this.saveOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveOptions.BackColor = System.Drawing.Color.Transparent;
            this.saveOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveOptions.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveOptions.ForeColor = System.Drawing.Color.Yellow;
            this.saveOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveOptions.Image")));
            this.saveOptions.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.saveOptions.Location = new System.Drawing.Point(562, 129);
            this.saveOptions.Name = "saveOptions";
            this.saveOptions.Size = new System.Drawing.Size(184, 67);
            this.saveOptions.TabIndex = 12;
            this.saveOptions.Text = "Save Changes";
            this.saveOptions.UseVisualStyleBackColor = false;
            this.saveOptions.Visible = false;
            this.saveOptions.Click += new System.EventHandler(this.saveOptions_Click);
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.AutoSize = true;
            this.radioButtonWhite.BackColor = System.Drawing.Color.Black;
            this.radioButtonWhite.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWhite.ForeColor = System.Drawing.Color.White;
            this.radioButtonWhite.Location = new System.Drawing.Point(710, 361);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(73, 22);
            this.radioButtonWhite.TabIndex = 14;
            this.radioButtonWhite.TabStop = true;
            this.radioButtonWhite.Text = "White";
            this.radioButtonWhite.UseVisualStyleBackColor = false;
            this.radioButtonWhite.Visible = false;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.BackColor = System.Drawing.Color.Black;
            this.radioButtonGreen.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGreen.ForeColor = System.Drawing.Color.White;
            this.radioButtonGreen.Location = new System.Drawing.Point(616, 361);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(77, 22);
            this.radioButtonGreen.TabIndex = 15;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = false;
            this.radioButtonGreen.Visible = false;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.BackColor = System.Drawing.Color.Black;
            this.radioButtonBlue.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBlue.ForeColor = System.Drawing.Color.White;
            this.radioButtonBlue.Location = new System.Drawing.Point(530, 361);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(65, 22);
            this.radioButtonBlue.TabIndex = 16;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = false;
            this.radioButtonBlue.Visible = false;
            // 
            // BoardLabel
            // 
            this.BoardLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoardLabel.AutoSize = true;
            this.BoardLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BoardLabel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.BoardLabel.Location = new System.Drawing.Point(595, 340);
            this.BoardLabel.Name = "BoardLabel";
            this.BoardLabel.Size = new System.Drawing.Size(116, 18);
            this.BoardLabel.TabIndex = 17;
            this.BoardLabel.Text = "Board color:";
            this.BoardLabel.Visible = false;
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.Location = new System.Drawing.Point(553, 389);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(15, 18);
            this.pictureBoxBlue.TabIndex = 18;
            this.pictureBoxBlue.TabStop = false;
            this.pictureBoxBlue.Visible = false;
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.Location = new System.Drawing.Point(648, 389);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(15, 18);
            this.pictureBoxGreen.TabIndex = 19;
            this.pictureBoxGreen.TabStop = false;
            this.pictureBoxGreen.Visible = false;
            // 
            // pictureBoxWhite
            // 
            this.pictureBoxWhite.Location = new System.Drawing.Point(730, 389);
            this.pictureBoxWhite.Name = "pictureBoxWhite";
            this.pictureBoxWhite.Size = new System.Drawing.Size(15, 18);
            this.pictureBoxWhite.TabIndex = 20;
            this.pictureBoxWhite.TabStop = false;
            this.pictureBoxWhite.Visible = false;
            // 
            // snakeControl1
            // 
            this.snakeControl1.AutoSize = true;
            this.snakeControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.snakeControl1.Location = new System.Drawing.Point(12, 12);
            this.snakeControl1.Name = "snakeControl1";
            this.snakeControl1.Size = new System.Drawing.Size(10, 10);
            this.snakeControl1.TabIndex = 0;
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxWhite);
            this.Controls.Add(this.pictureBoxGreen);
            this.Controls.Add(this.pictureBoxBlue);
            this.Controls.Add(this.BoardLabel);
            this.Controls.Add(this.radioButtonBlue);
            this.Controls.Add(this.radioButtonGreen);
            this.Controls.Add(this.radioButtonWhite);
            this.Controls.Add(this.saveOptions);
            this.Controls.Add(this.wallBox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.resolutionBox);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.topResultButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.snakeControl1);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.optionsMenuButton);
            this.DoubleBuffered = true;
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGame by Mikolaj Wesolek";
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.SizeChanged += new System.EventHandler(this.SnakeGame_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private snakeControl.SnakeControl snakeControl1;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button optionsMenuButton;
        private System.Windows.Forms.Button topResultButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.ComboBox resolutionBox;
        private System.Windows.Forms.ComboBox speedBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.CheckBox wallBox;
        private System.Windows.Forms.Button saveOptions;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.Label BoardLabel;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxWhite;
    }
}


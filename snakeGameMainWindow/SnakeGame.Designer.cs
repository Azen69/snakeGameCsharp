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
            this.snakeControl1 = new snakeControl.SnakeControl();
            this.SuspendLayout();
            // 
            // snakeControl1
            // 
            this.snakeControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.snakeControl1.Location = new System.Drawing.Point(387, 27);
            this.snakeControl1.Name = "snakeControl1";
            this.snakeControl1.Size = new System.Drawing.Size(400, 400);
            this.snakeControl1.TabIndex = 0;
            
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.snakeControl1);
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private snakeControl.SnakeControl snakeControl1;
    }
}


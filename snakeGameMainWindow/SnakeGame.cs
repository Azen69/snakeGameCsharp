using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using snakeControl;

namespace snakeGameMainWindow
{
    public partial class SnakeGame : Form
    {
        public SnakeGame()
        {
            InitializeComponent();
            
        }

        private void SnakeGame_Load(object sender, EventArgs e)
        {  
         
       
        snakeControl1.timer1.Stop();
        snakeControl1.Hide();
        mainMenuButton.Hide();
        resolutionBox.Items.Add("    400x400");
        resolutionBox.Items.Add("    800x600");
        resolutionBox.Items.Add("    1920x1080");
        speedBox.Items.Add("   1x");
        speedBox.Items.Add("   2x");
        speedBox.Items.Add("   5x");
        resolutionBox.SelectedIndex = 0;
        speedBox.SelectedIndex = 0;
        pictureBoxBlue.BackColor = Color.FromArgb(150, Color.Blue);
        pictureBoxGreen.BackColor = Color.FromArgb(255, Color.Green);
        pictureBoxWhite.BackColor = Color.FromArgb(255, Color.White);
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            snakeControl1.Width = this.Width - 40;
            snakeControl1.Height = this.Height - 65;
            snakeControl1.timer1.Start();
            startGameButton.Hide();
            topResultButton.Hide();
            optionsMenuButton.Hide();
            exitButton.Hide();
            snakeControl1.Show();

            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            mainMenuClick();
        }
        public void mainMenuClick()
        {
            startGameButton.Text ="Resume Game";
            startGameButton.Show();
            topResultButton.Show();
            optionsMenuButton.Show();
            exitButton.Show();
            snakeControl1.timer1.Stop();
            snakeControl1.Hide();

            mainMenuButton.Hide();
            saveOptions.Hide();
            resolutionLabel.Hide();
            resolutionBox.Hide();
            speedBox.Hide();
            speedLabel.Hide();
            wallBox.Hide();
            pictureBoxGreen.Hide();
            radioButtonGreen.Hide();
            pictureBoxBlue.Hide();
            radioButtonBlue.Hide();
            radioButtonWhite.Hide();
            BoardLabel.Hide();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //problem with priority of key down solved by this
        {
            
            if (keyData == Keys.Escape)
            {

                mainMenuClick();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);

            }
        }

        private void SnakeGame_SizeChanged(object sender, EventArgs e)
        {
            startGameButton.Width=this.Width/5;
            exitButton.Width = this.Width / 5;
            topResultButton.Width = this.Width / 5;
            mainMenuButton.Width = this.Width / 5;
            optionsMenuButton.Width = this.Width / 5;
        }

        private void optionsMenuButton_Click(object sender, EventArgs e)
        {
            startGameButton.Hide();
            topResultButton.Hide();
            optionsMenuButton.Hide();
            exitButton.Hide();
            mainMenuButton.Show();
            saveOptions.Show();
            resolutionLabel.Show();
            resolutionBox.Show();
            speedBox.Show();
            speedLabel.Show();
            wallBox.Show();
            saveOptions.Show();
            pictureBoxGreen.Show();
            radioButtonGreen.Show();
            pictureBoxBlue.Show();
            radioButtonBlue.Show();
            radioButtonWhite.Show();
            pictureBoxWhite.Show();
            BoardLabel.Show();
        }

        private void saveOptions_Click(object sender, EventArgs e)
        {
            string message = "Changes have been saved and will be visible in the new game";
            string caption = "INFO about saving";
            DialogResult result;
            result = MessageBox.Show(message, caption,
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation);

        }


    }
}

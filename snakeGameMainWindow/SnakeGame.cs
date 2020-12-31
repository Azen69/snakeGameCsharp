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
         
        snakeControl1.Width = this.Width - 40;
        snakeControl1.Height = this.Height - 65;
        snakeControl1.timer1.Stop();
        snakeControl1.Hide();


        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            startGameButton.Hide();
            topResultButton.Hide();
            optionsMenuButton.Hide();
            exitButton.Hide();
            snakeControl1.Show();
            snakeControl1.timer1.Start();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

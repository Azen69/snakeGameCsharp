using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakeControl
{
    public partial class SnakeControl: UserControl
    {
        private Snake snake;
        private int square = 25;
        private int sum = 0;
        public SnakeControl()
        {
           
            InitializeComponent();
            snake = new Snake(1, 1);


        }
  

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           Board board = new Board(panel1.Width, panel1.Height, Brushes.Green);
            board.Draw(e);
            SnakeDraw snakeDraw = new SnakeDraw();
            
            for (int i = 0; i < snake.size.Count; i++)
            {
               snakeDraw.Draw(e,square*snake.size[i].X,square*snake.size[i].Y,square-1,square-1, Brushes.Black);
                
                
            }
            

        }
        private void snakeIsMoving(Snake snake)
        {
            
                
                for (int i = snake.size.Count - 1; i > 0; i--)
            {
                snake.size[i].X = (snake.size[i-1].X);
                snake.size[i].Y = (snake.size[i - 1].Y);

            }
            switch (snake.direction)
            {
                case "left":
                   snake.size[0].X -=snake.xPosition;
                    break;
                case "right":
                    snake.size[0].X += snake.xPosition;
                    break;
                case "up":
                    snake.size[0].Y -= snake.yPosition;
                    break;
                case "down":
                    snake.size[0].Y += snake.yPosition;
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            snakeIsMoving(snake);
            panel1.Invalidate();
           
        }

        private void SnakeControl_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 200;
            this.timer1.Start();
        }

        private void SnakeControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                snake.direction = "up";
            else if (e.KeyCode == Keys.Down)
                snake.direction = "down";
            else if (e.KeyCode == Keys.Right)
                snake.direction = "right";
            else if (e.KeyCode == Keys.Left)
                snake.direction = "left";
  
            
        }    protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Up)
            {
                snake.direction = "up";
                return true;
            }
            else if (keyData == Keys.Down)
            {
                snake.direction = "down";
                return true;
            }
            else if (keyData == Keys.Right)
            {
                snake.direction = "right";
                return true;
            }
            else if (keyData == Keys.Left)
            {
                snake.direction = "left";
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);

            }
            }
    }

}

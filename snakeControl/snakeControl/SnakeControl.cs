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
        private int square =25;
        public int borderX,borderY;
        private bool wall=false;
        
        public SnakeControl()
        {
           
            InitializeComponent();
            snake = new Snake(10, 10);


        }
  

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Board board = new Board(panel1.Width, panel1.Height, Brushes.Green,square);
            board.Draw(e);
            SnakeDraw snakeDraw = new SnakeDraw();
      
            for (int i = 0; i < snake.size.Count; i++)
            {
                //label1.Text = Convert.ToString(panel1.Height / square);
               snakeDraw.Draw(e,square*snake.size[i].X,square*snake.size[i].Y,square-1,square-1, Brushes.Black);
                
                
            }
            

        }
        private void snakeIsMoving(Snake snake)
        {
            borderX = panel1.Width / square;
            borderY = panel1.Height / square;
            if (!wall)
            {
                if ((snake.size[0].X > borderX))
                {
                    snake.size[0].X = 0;
                }
                if ((snake.size[0].Y > borderY))
                {
                    snake.size[0].Y = 0;
                }
                if ((snake.size[0].X < 0 ))
                {
                    snake.size[0].X = borderX;
                }
                if ((snake.size[0].Y < 0))
                {
                    snake.size[0].Y = borderY;
                }

            }
          for (int i = snake.size.Count - 1; i > 0; i--)
            {
                snake.size[i].X = (snake.size[i-1].X);
                snake.size[i].Y = (snake.size[i - 1].Y);

            }

            switch (snake.direction)
            {
                case "left":
                   snake.size[0].X -=1;
                    break;
                case "right":
                    snake.size[0].X += 1;
                    break;
                case "up":
                    snake.size[0].Y -=1;
                    break;
                case "down":
                    snake.size[0].Y += 1;
                    break;
            }

        }
        protected override CreateParams CreateParams //problem with flicking solve by this
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            snakeIsMoving(snake);

            panel1.Refresh();
            
        }

        private void SnakeControl_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 200;
            this.timer1.Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Up && snake.direction!="down")
            {
                snake.direction = "up";
                return true;
            }
            else if (keyData == Keys.Down && snake.direction != "up")
            {
                snake.direction = "down";
                return true;
            }
            else if (keyData == Keys.Right && snake.direction != "left")
            {
                snake.direction = "right";
                return true;
            }
            else if (keyData == Keys.Left && snake.direction != "right")
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

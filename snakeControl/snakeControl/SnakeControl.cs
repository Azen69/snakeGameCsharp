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
    public partial class SnakeControl : UserControl
    {
        private Random rnd;
        private Snake snake;
        private Board board;
        private Food food;
        private List<int> randomListOfPosition;
        private int square = 25;
        private bool wall = false;
        private bool foodExisted = false;
        private Color boardColor = Color.FromArgb(255, Color.Green);
        private Color borderColor = Color.FromArgb(255, Color.DarkGray);
        private Color foodColor = Color.FromArgb(255, Color.Red);

        public SnakeControl()
        {
            InitializeComponent();
            positionGenerator();
            snake = new Snake(randomListOfPosition[0], randomListOfPosition[1], square);
            randomListOfPosition.Clear();
            positionGenerator();
            food = new Food(randomListOfPosition[0], randomListOfPosition[1],square);
            foodExisted = true;
            randomListOfPosition.Clear();
            board = new Board(panel1.Width, panel1.Height, new SolidBrush(boardColor), square);
        }
        private void positionGenerator()
        {
            randomListOfPosition = new List<int>();
            rnd = new Random();
            randomListOfPosition.Add(rnd.Next(2,panel1.Width/square-2));
            randomListOfPosition.Add(rnd.Next(2,panel1.Height / square-2));
            
        }
 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            
            board.Draw(e, borderColor);
            food.Draw(e, new SolidBrush(foodColor));
            for (int i = 0; i < snake.size.Count; i++)
            {
               snake.Draw(e,square*snake.size[i].X,square*snake.size[i].Y,square,square, Brushes.Black);
            }

        }
    

        private void SnakeControl_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 200;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            snake.snakeIsMoving(wall,panel1.Width,panel1.Height);
            panel1.Refresh();
            
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //problem with priority of usercontrol solved by this
        {
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
        protected override CreateParams CreateParams //problem with flicking solve by this
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
    }

}

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
        private Random rnd=new Random();
        private Snake snake;
        private Board board;
        private Food food;
        private List<int> randomListOfPositionSnake, randomListOfPositionFood;
        private int square = 25;
        private bool wall = false;
        private bool foodExisted = false;
        private Color boardColor = Color.FromArgb(255, Color.Green);
        private Color borderColor = Color.FromArgb(255, Color.DarkGray);
        private Color foodColor = Color.FromArgb(255, Color.Red);

        public SnakeControl()
        {
            randomListOfPositionSnake = new List<int>();
            randomListOfPositionFood = new List<int>();
            InitializeComponent();
            positionGenerator(randomListOfPositionSnake);
            snake = new Snake(randomListOfPositionSnake[0], randomListOfPositionSnake[1], square);
            positionGenerator(randomListOfPositionFood);
            food = new Food(randomListOfPositionFood[0], randomListOfPositionFood[1],square);
            foodExisted = true;
            board = new Board(panel1.Width, panel1.Height, new SolidBrush(boardColor), square);
        }
        private void positionGenerator(List<int> randomListOfPosition)
        {
            randomListOfPosition.Add(rnd.Next(2,panel1.Width/square-2));
            randomListOfPosition.Add(rnd.Next(2,panel1.Height / square-2));
        }
 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (!foodExisted)
            {
                foodExisted = true;
                while (foodExisted)
                {
                    randomListOfPositionFood.Clear();
                    positionGenerator(randomListOfPositionFood);
                    foodExisted = false;


                    for (int i = 0; i < snake.size.Count; i++)
                    {
                        if (snake.size[i].X == randomListOfPositionFood[0]&& snake.size[i].Y == randomListOfPositionFood[1])
                        {
                            foodExisted = true;
                            
                        }

                    }
                      
                }
                food = new Food(randomListOfPositionFood[0], randomListOfPositionFood[1], square);
                foodExisted = true;
            }
            foodEatenBySnake();
            board.Draw(e, borderColor);
            food.Draw(e, new SolidBrush(foodColor));
            for (int i = 0; i < snake.size.Count; i++)
            {
               snake.Draw(e,square*snake.size[i].X,square*snake.size[i].Y,square-1,square-1, Brushes.Black);
            }

        }
        private void foodEatenBySnake()
        {

            if (snake.size[0].X==food.size[0].X && snake.size[0].Y == food.size[0].Y)
            {
                snake.size.Add(new Positions(food.size[0].X, food.size[0].Y));
                foodExisted = false;
                
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
            if (snake.bodyColision())
            {
                this.timer1.Stop();
            }
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

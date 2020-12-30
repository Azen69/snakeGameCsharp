using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace snakeControl
{
    class Snake
    {
        private int borderX, borderY;
        private int xPosition, yPosition;
        public List<Positions> size { get; set; }
        private int square;
        public string direction { get; set; }
        public Snake(int xPosition, int yPosition,int square)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.square = square;
            size = new List<Positions>();
            size.Add(new Positions(this.xPosition, this.yPosition));

            direction = "right";
        }
        public void Draw(PaintEventArgs g, int x, int y, int width, int height, Brush Color)
        {
            g.Graphics.FillRectangle(Color, new Rectangle(x, y, width, height));
        }
        public bool bodyColision(bool wall)
        {
            for (int i = 1; i < size.Count; i++)
            {
                if (size[i].X == size[0].X && size[i].Y == size[0].Y)
                {
                    return true;

                }
            }
            if (wall)
            {

                if (size[0].X > borderX || size[0].Y> borderY || size[0].X < 0 || size[0].Y < 0)
                {
                    return true;
                }

               
            }
            return false;
        }
        public void snakeIsMoving(bool wall, int width,int height)
        {
            borderX = width / square;
            borderY = height / square;
            if (!wall)
            {
                if ((size[0].X > borderX))
                {
                    size[0].X = 0;
                }
                if ((size[0].Y > borderY))
                {
                    size[0].Y = 0;
                }
                if ((size[0].X < 0))
                {
                    size[0].X = borderX;
                }
                if ((size[0].Y < 0))
                {
                    size[0].Y = borderY;
                }

            }
            for (int i = size.Count - 1; i > 0; i--)
            {
                size[i].X = (size[i - 1].X);
                size[i].Y = (size[i - 1].Y);

            }
            switch (direction)
            {
                case "left":
                    size[0].X -= 1;
                    break;
                case "right":
                    size[0].X += 1;
                    break;
                case "up":
                    size[0].Y -= 1;
                    break;
                case "down":
                    size[0].Y += 1;
                    break;
            }

        }

    }
}

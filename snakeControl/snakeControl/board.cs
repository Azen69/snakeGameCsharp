using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace snakeControl
{
    class Board
    {
        
        private Brush Color;
        private int width,height,square;
        private int x1, y1, x2, y2;
        public Board(int x,int y, SolidBrush Color,int square)
        {
            this.width = x;
            this.height = y;
            this.Color = Color;
            this.square = square;
        }
        public void Draw(PaintEventArgs g, Color color)
        {
           g.Graphics.FillRectangle(this.Color, new Rectangle(0,0,width,height));
            Pen pen = new Pen(color);
            pen.Width = 2.0F;
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = height;
            g.Graphics.DrawLine(pen, x1, y1, x2, y2);
            while (x1<width)
            {
                x1 += square;
                x2 += square;
                
                g.Graphics.DrawLine(pen, x1, y1, x2, y2);
            }
            x1 = 0;
            y1 = 0;
            x2 = width;
            y2 = 0;
            while (y1 < height)
            {
                y1 += square;
                y2 += square;
                
                g.Graphics.DrawLine(pen, x1, y1, x2, y2);
            }



        }
    }
}

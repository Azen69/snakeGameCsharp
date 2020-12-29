using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace snakeControl
{
    class SnakeDraw
    {
        public void Draw(PaintEventArgs g,int x,int y, int width, int height, Brush Color)
        {
            g.Graphics.FillRectangle(Color, new Rectangle(x, y, width, height));
        }
    }
}

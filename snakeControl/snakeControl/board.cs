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

        private int width { get; set; }
        private int height { get; set; }
        public Board(int x,int y,Brush Color)
        {
            this.width = x;
            this.height = y;
            this.Color = Color;
        }
        public void Draw(PaintEventArgs g)
        {
            g.Graphics.FillRectangle(Color, new Rectangle(0,0,width,height));
           
        }
    }
}

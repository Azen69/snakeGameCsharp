using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace snakeControl
{
    class Food
    {
        public List<Positions> size { get; set; }
        private int sizeOfSquare;
      
        public Food(int xPosition, int yPosition, int sizeOfSquare )
        {
            size=new List<Positions>();
            size.Add(new Positions(xPosition,yPosition));
            this.sizeOfSquare = sizeOfSquare;
        }
        public void Draw(PaintEventArgs g, SolidBrush Color)
        {
            g.Graphics.FillRectangle(Color, new Rectangle(this.size[0].X* sizeOfSquare, this.size[0].Y* sizeOfSquare, this.sizeOfSquare-1, this.sizeOfSquare-1 ));
        }
    }
}

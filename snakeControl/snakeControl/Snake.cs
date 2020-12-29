using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeControl
{
    class Snake
    {
        public int xPosition, yPosition;
        public  List<Positions> size;
        public string direction;
        public Snake(int xPosition, int yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            size = new List<Positions>();
            size.Add(new Positions(this.xPosition, this.yPosition));
            size.Add(new Positions(this.xPosition, this.yPosition));
            direction = "right";
        }
       
    }
}

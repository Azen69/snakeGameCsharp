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
        public SnakeControl()
        {
           
            InitializeComponent();
           
            
        }
  

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Board board = new Board(panel1.Width, panel1.Height, Brushes.Violet);
            board.Draw(e);
        }
    }

}

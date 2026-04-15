using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirintus
{
    public class Bonusz: PictureBox
    {
        public Bonusz(Point location)
        {
            BackColor = Color.Orange;
            Size = new Size(10, 10);
            
        }
    }
}

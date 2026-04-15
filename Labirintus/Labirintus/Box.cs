using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirintus
{
    public class Box: PictureBox
    {
        public Box()
        {
            BackColor = Color.Black;
            Size = new Size(20, 20);
        }
    }
}

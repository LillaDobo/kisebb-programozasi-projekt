using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //enum Sex {Male, Female}

    /// <summary>
    /// Dokumentáció
    /// </summary>
    internal class SnakeSegment : PictureBox
    {
        public static int SnakeSegmentSize { get; } = 20;
        public SnakeSegment()
        {
            BackColor = Color.LimeGreen;
            Width = SnakeSegmentSize;
            Height = SnakeSegmentSize;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="step"></param>
        public SnakeSegment(int step)
        {
            Width = SnakeSegmentSize;
            Height = SnakeSegmentSize;
            if(step % 2 ==0)
            {
                BackColor = Color.LimeGreen;
            }
            else
            {
                BackColor = Color.Fuchsia;
            }
        }
    }
}

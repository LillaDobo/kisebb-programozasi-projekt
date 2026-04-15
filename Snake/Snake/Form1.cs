namespace Snake
{
    public partial class Form1 : Form
    {
        int directionX = 1;
        int directionY = 0;
        int headX = 100;
        int headY = 100;
        int snakeLength = 5;

        /*
        int directionX1 = -1;
        int directionY1 = 0;
        int headX1 = 300;
        int headY1 = 100;
        int snakeLength1 = 5;
        */
        int stepCounter = 0;

        List<SnakeSegment> snake = new List<SnakeSegment>();
        //List<SnakeSegment> snake1 = new List<SnakeSegment>();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            headX += directionX * SnakeSegment.SnakeSegmentSize;
            headY += directionY * SnakeSegment.SnakeSegmentSize;

            bool isSnakeDead = false;
            foreach (SnakeSegment segment in snake)
            {
                if (segment.Top == headY && segment.Left == headX)
                {
                    //timer1.Enabled = false;
                    isSnakeDead = true;
                    break;
                }

            }

            if (isSnakeDead)
            {
                foreach (var segment in snake)
                {
                    Controls.Remove(segment);
                }
                snake.Clear();
                stepCounter = 0;
                snakeLength = 5;
                label1.Text = "0";
                return;
                //snake.Clear();
                //Controls.Clear();
                //stepCounter = 0;
            }
            label1.Text = stepCounter.ToString();
            var newHead = new SnakeSegment(stepCounter)
            {
                Top = headY,
                Left = headX,
            };
            Controls.Add(newHead);
            snake.Add(newHead);

            if (snake.Count() > snakeLength)
            {
                var tailToCut = snake.First();
                snake.Remove(tailToCut);
                //snake.RemoveAt(0);
                Controls.Remove(tailToCut);
            }
            //------------------
            //headX1 += directionX1 * SnakeSegment.SnakeSegmentSize;
            //headY1 += directionY1 * SnakeSegment.SnakeSegmentSize;


            //------------------
            stepCounter++;

            if (stepCounter % 5 == 0)
            {
                snakeLength++;
            }



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                directionY = -1;
                directionX = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                directionY = 1;
                directionX = 0;
            }

            if (e.KeyCode == Keys.Right)
            {
                directionY = 0;
                directionX = 1;
            }

            if (e.KeyCode == Keys.Left)
            {
                directionY = 0;
                directionX = -1;
            }

            /*
            if (e.KeyCode == Keys.W) { directionX1 = 0; directionY1 = -1; }
            if (e.KeyCode == Keys.S) { directionX1 = 0; directionY1 = 1; }
            if (e.KeyCode == Keys.A) { directionX1 = -1; directionY1 = 0; }
            if (e.KeyCode == Keys.D) { directionX1 = 1; directionY1 = 0; }
            */
        }

    }
}
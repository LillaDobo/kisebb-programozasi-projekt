namespace QuizGame
{
    public partial class Form1 : Form
    {
        List<QuestionUserControl> questions = new List<QuestionUserControl>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("jatek.csv");

            int row = 0;
            while (!sr.EndOfStream)
            {
                if (row == 50) return;
                string line = sr.ReadLine();
                string[] strings = line.Split(';');
                if (strings.Length != 6) continue;
                string question = strings[0];
                string answer1 = strings[1];
                string answer2 = strings[2];
                string answer3 = strings[3];
                string answer4 = strings[4];
                int correctAnswer = int.Parse(strings[5]);

                QuestionUserControl quc = new QuestionUserControl(question, answer1, answer2, answer3, answer4, correctAnswer);
                quc.Top = row * quc.Height;

                questions.Add(quc);
                Controls.Add(quc);
                row++;
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answered = 0;
            int correctAnswer = 0;
            foreach (var item in questions)
            {
                if(item.Answered == true)
                {
                    answered++;
                    if (item.Correct)
                    {
                        correctAnswer++;
                    }
                }
            }
            if (DialogResult.OK == MessageBox.Show( $"{correctAnswer} találat a(z) {answered} kérdésbõl", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Information)) return;


        }
    }
}
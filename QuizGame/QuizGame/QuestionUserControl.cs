using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class QuestionUserControl : UserControl
    {
        int correctAnswer;

        public bool Correct { get; set; } = false;
        public bool Answered { get; set; } = false;

        public QuestionUserControl()
        {
            InitializeComponent();

        }

        public QuestionUserControl(string q, string a1, string a2, string a3, string a4, int correctAnswer)
        {
            InitializeComponent();
            label1.Text = q;
            button1.Text = a1;
            button2.Text = a2;
            button3.Text = a3;
            button4.Text = a4;
            this.correctAnswer = correctAnswer; //this az osztály szintűvé teszi a változót

        }

        public void ColorCorrectAnswer()
        {
            if (correctAnswer == 1) button1.BackColor = Color.Green;
            if (correctAnswer == 2) button2.BackColor = Color.Green;
            if (correctAnswer == 3) button3.BackColor = Color.Green;
            if (correctAnswer == 4) button4.BackColor = Color.Green;
            Enabled = false;
            Answered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            if (correctAnswer == 1) Correct = true;
            ColorCorrectAnswer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            if (correctAnswer == 2) Correct = true;
            ColorCorrectAnswer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            if (correctAnswer == 3) Correct = true;
            ColorCorrectAnswer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            if (correctAnswer == 4) Correct = true;
            ColorCorrectAnswer();
        }
    }
}

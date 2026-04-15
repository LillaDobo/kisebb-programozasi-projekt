using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Numerics;

namespace Labirintus
{

    public partial class Form1 : Form
    {
        List<Box> falak = new List<Box>();
        Player jatekos = new Player();
        Box finishLine = new Box();
        int[] start = new int[2];
        int[] finish = new int[2];
        bool indulas = false;
        int stepCounter;
        DateTime startTime;
        DateTime pauseStartTime;
        TimeSpan pauseTotalTime = TimeSpan.Zero;
        bool betoltve = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (!indulas) return;
            int x = jatekos.Location.X;
            int y = jatekos.Location.Y;

            if (e.KeyCode == Keys.D)
            {
                x += 20;
            }
            if (e.KeyCode == Keys.A)
            {
                x -= 20;
            }
            if (e.KeyCode == Keys.W)
            {
                y -= 20;
            }
            if (e.KeyCode == Keys.S)
            {
                y += 20;
            }

            var wall = falak.FirstOrDefault(w => w.Location.X == x && w.Location.Y == y);
            if (wall == null)
            {
                jatekos.Location = new Point(x, y);
                stepCounter++;
                label1.Text = $"Lépések: {stepCounter}";
            }
            if (jatekos.Location == new Point(finish[0], finish[1]))
            {
                MessageBox.Show("Gratulálunk nyertél!");
                timer1.Stop();
            }


            if (jatekos.Location == finishLine.Location)
            {
                MessageBox.Show("Gratulálok, nyertél!");
                //panel1.Controls.Remove(jatekos);
                indulas = false;
                timer1.Stop();
            }
        }

        private void btn_New_Game_Click(object sender, EventArgs e)
        {
            if (!betoltve) return;
            if (!panel1.Controls.Contains(jatekos))
                panel1.Controls.Add(jatekos);
            stepCounter = 0;
            startTime = DateTime.Now;
            timer1.Start();

            jatekos.Location = new Point(start[0], start[1]);

            label1.Text = "Lépések: 0";
            label2.Text = "Idõ: 00:00";
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            indulas = true;
            if (!betoltve) return;
            stepCounter = 0;
            startTime = DateTime.Now;
            if (!panel1.Controls.Contains(jatekos))
                panel1.Controls.Add(jatekos);

            jatekos.Location = new Point(start[0], start[1]);
            label1.Text = "Lépések: 0";
            label2.Text = "Idõ: 00:00";
            timer1.Start();


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            label2.Text = $"Idõ: {elapsed.Minutes:D2}:{elapsed.Seconds:D2}";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pauseStartTime = DateTime.Now;
            var result = MessageBox.Show("Biztosan ki akarsz lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                TimeSpan pauseDuration = DateTime.Now - pauseStartTime;
                pauseTotalTime += pauseDuration;
                timer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            betoltve = true;
            panel1.Controls.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    int y = 0;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (!line.Any(c => c == 'S' || c == 'F' || c == '#'))
                        {
                            MessageBox.Show("A fájl nem tartalmaz érvényes pályaadatokat!", "Hibás formátum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                      
                        for (int x = 0; x < line.Length; x++)
                        {
                            if (line[x] == 'S')
                            {
                                start[0] = x * 20;
                                start[1] = y * 20;
                            }
                            else if (line[x] == 'F')
                            {
                                finish[0] = x * 20;
                                finish[1] = y * 20;
                            }
                            else if (line[x] == '#')
                            {
                                Box pb = new Box();
                                pb.Location = new Point(x * 20, y * 20);
                                panel1.Controls.Add(pb);
                                falak.Add(pb);
                            }

                        }
                        y++;
                    }
                    sr.Close();

                    finishLine.Location = new Point(finish[0], finish[1]);
                    finishLine.BackColor = Color.Fuchsia;
                    panel1.Controls.Add(finishLine);


                }
                KeyDown += Form1_KeyDown;
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"Fájlhiba történt:\n{ioEx.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ismeretlen hiba történt:\n{ex.Message}", "Ismeretlen hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

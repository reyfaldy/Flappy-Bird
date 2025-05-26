namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipespeed;
        int gravity;
        int score;
        int highscore;

        public Form1()
        {
            InitializeComponent();
            highscore = LoadHighScore();

            this.KeyPreview = true;

            BtnRestart.TabStop = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            BtnRestart.Text = "START";
            BtnRestart.Visible = true;
            lb_score.Text = "Flappy Bird!";
            this.ActiveControl = null;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            flappy.Top += gravity;
            pipe_up.Left -= pipespeed;
            pipe_down.Left -= pipespeed;
            lb_score.Text = "SCORE: " + score;

            if (pipe_up.Left < -150)
            {
                pipe_up.Left = 650;
                pipe_down.Left = 650;
                score++;
            }

            if (score > 5)
            {
                pipespeed = 25;
            }

            if (score > 10)
            {
                pipespeed = 50;
            }

            if (score > 20)
            {
                pipespeed = 80;
            }

            if (score > 30)
            {
                pipespeed = 100;
            }

            if (flappy.Bounds.IntersectsWith(pipe_down.Bounds) ||
                flappy.Bounds.IntersectsWith(pipe_up.Bounds) ||
                flappy.Bounds.IntersectsWith(ground.Bounds))
            {
                EndGame();
            }

            if (flappy.Top < -25)
            {
                EndGame();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && timer1.Enabled)
            {
                gravity = 15;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter && !timer1.Enabled && BtnRestart.Visible)
            {
                BtnRestart.PerformClick();
                e.Handled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && timer1.Enabled)
            {
                gravity = -15;
                e.Handled = true;
            }
        }

        private void SaveHighScore(int score)
        {
            string path = "highscore.txt";
            File.WriteAllText(path, score.ToString());
        }

        private int LoadHighScore()
        {
            string path = "highscore.txt";
            if (File.Exists(path))
            {
                string scoreText = File.ReadAllText(path);
                if (int.TryParse(scoreText, out int savedScore))
                {
                    lb_highscore.Text = "HIGH SCORE: " + savedScore;
                    return savedScore;
                }
            }
            lb_highscore.Text = "HIGH SCORE: 0";
            return 0;
        }

        private void EndGame()
        {
            timer1.Stop();
            if (score > highscore)
            {
                highscore = score;
                SaveHighScore(highscore);
            }

            BtnRestart.Visible = true;
            BtnRestart.Text = "RESTART";
            BtnRestart.BringToFront();

            this.Focus();
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            score = 0;
            gravity = 10;
            pipespeed = 15;

            flappy.Top = this.Height / 2 - flappy.Height / 2;
            pipe_up.Left = 600;
            pipe_down.Left = 600;
            cloud.Left = 0;

            lb_score.Text = "SCORE: 0";
            lb_highscore.Text = "HIGH SCORE: " + highscore;
            BtnRestart.Visible = false;

            timer1.Start();
            this.Focus();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace BirthdayApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int score = 0;
        int total_shots = 20;
        int miss_shots = 0;
        static SoundPlayer sp;
        static SoundPlayer spstart;
        static SoundPlayer cheer;

        void shot_voice()
        {
            sp = new SoundPlayer();

            sp.SoundLocation = "shotgun2.wav";  // a hangfájl elérési útja
            sp.Load();
            sp.Play();
            /*
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"D:\Agi\IT\CS50\pop2.wav";
            player.Play();*/
        }

        void hit_voice()
        {
            sp = new SoundPlayer();

            sp.SoundLocation = "yesss.wav";  // a hangfájl elérési útja
            sp.Load();
            sp.Play();
            /*
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"D:\Agi\IT\CS50\pop2.wav";
            player.Play();*/
        }


        void fn_shot()
        {
            score++;
            label1.Text = "Score=" + score;
            total_shots--;
            label3.Text = "Total left=" + total_shots;

            hit_voice();
        }

        void fn_miss_shot()
        {
            miss_shots++;
            label2.Text = "Missed=" + miss_shots;
            total_shots--;
            label3.Text = "Total left=" + total_shots;

            shot_voice();

        }

        void reset()
        {
            label4.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            score = 0;
            total_shots = 20;
            miss_shots = 0;
            label1.Text = "Score=" + score;
            label2.Text = "Missed=" + miss_shots;
            label3.Text = "Total left=" + total_shots;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int x, y;
            x = r.Next(0, 400);
            y = r.Next(100, 200);
            wcPapir.Location = new Point(x, y);
            if (total_shots<=0)
            {
                if (score==10)
                {
                    timer1.Stop();
                    level2screen.Visible = true;
                    this.UseWaitCursor = false;
                }
                else
                {
                    timer1.Stop();
                    label4.Visible = true;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false; 
                }

            }
            else
            {
                if (score == 10)
                {
                    timer1.Stop();
                    level2screen.Visible = true;
                    level2screen.Cursor = Cursors.Arrow;
                    cheer = new SoundPlayer();

                    cheer.SoundLocation = "cheer.wav";  // a hangfájl elérési útja
                    cheer.Load();
                    cheer.Play();


                }
            }
        }

        private void wcPapir_Click(object sender, EventArgs e)
        {
            fn_shot();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            fn_miss_shot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            spstart.Stop();
        }

        private void level2screen_Click(object sender, EventArgs e)
        {
            Level2 f2 = new Level2(); // átadjuk a termékeket
            this.Hide();
            spstart.Stop();

            f2.ShowDialog();
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            spstart = new SoundPlayer();

            spstart.SoundLocation = "backmusic.wav";  // a hangfájl elérési útja
            spstart.Load();
            spstart.Play();
        }
    }
}

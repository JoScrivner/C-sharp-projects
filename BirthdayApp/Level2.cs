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
    public partial class Level2 : Form
    {


        bool goleft = false;
        bool goright = false;
        bool jumping = false;

        int jumpSpeed = 10;
        int force = 8;
        int score2 = 0;

        static SoundPlayer sp2;
        static SoundPlayer spstart;



        public Level2()
        {
            InitializeComponent();
        }

        void soundeffect()
        {
            sp2 = new SoundPlayer();

            sp2.SoundLocation = "yesss.wav";  // a hangfájl elérési útja
            sp2.Load();
            sp2.Play();
           
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goleft = true;
                    break;
                case Keys.Right:
                    goright = true;
                    break;
                case Keys.Space:
                    if (!jumping)
                    {
                        jumping = true;
                    }
                    break;

            }
            /*
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
            */

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goleft = false;
                    break;
                case Keys.Right:
                    goright = false;
                    break;
            }
            /*
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
*/
            if (jumping)
            {
                jumping = false;
            }
            
        }

        
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            int xMin = 0;
            int xMax = this.Width;

            if (player.Left <= xMin)
            {
                goleft = false;
                // Arguments go here for if object player has passed the left of the window border.
            }
            if (player.Left > 338)
            {
                goright = false;
                // Arguments here for if object player is passing the bottom of the screen.
            }

            player.Top += jumpSpeed;

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (goleft)
            {
                player.Left -= 5;
            }

            if (goright)
            {
                player.Left += 5;
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 3;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }
                }
                /*
                else
                {
                    if (player.Bounds.IntersectsWith(wall1.Bounds))
                    {
                        force = 0;
                        player.Left = x.Right - player.Width;
                    }
                    
                }
                
                */
                if (x is PictureBox && x.Tag == "flour")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        soundeffect();
                        score2++;
                        scorelabel.Text = "Score=" + score2;
                    }
                }

                if (player.Bounds.IntersectsWith(door.Bounds))
                {

                    timer2.Stop();
                    countd.Stop();
                    

                    level2finish.Visible = true;

                }

            }

        }

        private void level2welcome_Click(object sender, EventArgs e)
        {
            level2welcome.Visible = false;
            spstart.Stop();

            timer2.Enabled = true;
            timer2.Start();
            countd.Enabled=true;
            countd.Start();
            
        }

        private void level2finish_Click(object sender, EventArgs e)
        {

            Level3 f3 = new Level3(); // átadjuk a termékeket
            this.Hide();


            f3.ShowDialog();
            this.Close();
            
        }


        int timeleft = 15;


        private void countd_Tick(object sender, EventArgs e)
        {

            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                timertext.Text = "00:" + timeleft;
            }
            else
            {
                scorelabel.Visible = false;
                timertext.Text = "OUT OF TIME";
                player.Visible = false;
                button1.Enabled = true;
                button1.Visible = true;
            }

        }


        void reset()
        {
            Level2 fr = new Level2();
            fr.ShowDialog();
            this.Close();
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            

            spstart = new SoundPlayer();

            spstart.SoundLocation = "backmusic.wav";  // a hangfájl elérési útja

            spstart.Load();
            spstart.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}

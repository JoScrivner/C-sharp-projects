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
    public partial class Level3 : Form
    {
        public Level3()
        {
            InitializeComponent();
        }

        int score3 = 0;
        static SoundPlayer sp3;
        static SoundPlayer cheer;



        void soundeffect3()
        {
            sp3 = new SoundPlayer();

            sp3.SoundLocation = "correct.wav";  // a hangfájl elérési útja
            sp3.Load();
            sp3.Play();

        }

        private void btnlivingroom_Click(object sender, EventArgs e) //4 items
        {
            btnbacklivingroom.Enabled = true;
            btnbacklivingroom.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            picturelivingroom.Visible = true;                 

        }

        private void btnbacklivingroom_Click(object sender, EventArgs e)
        {
            picturelivingroom.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            btnbacklivingroom.Enabled = false;
            btnbacklivingroom.Visible = false;
            btnlivingroom.Enabled = false;
        }

        private void btnkitchen_Click(object sender, EventArgs e) //3 items
        {
            btnbackkitchen.Enabled = true;
            btnbackkitchen.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            picturekitchen.Visible = true;
        }

        private void btnbackkitchen_Click(object sender, EventArgs e)
        {
            picturekitchen.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            btnbackkitchen.Enabled = false;
            btnbackkitchen.Visible = false;
            btnkitchen.Enabled = false;
        }

        private void btnbathroom_Click(object sender, EventArgs e) //3 items
        {
            btnbackbathroom.Enabled = true;
            btnbackbathroom.Visible = true;
            pictureBox5.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            picturebathroom.Visible = true;
        }

        private void btnbackbathroom_Click(object sender, EventArgs e)
        {
            picturebathroom.Visible = false;
            pictureBox5.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            btnbackbathroom.Enabled = false;
            btnbackbathroom.Visible = false;
            btnbathroom.Enabled = false;
        }

        
        private void btnsheldonroom_Click(object sender, EventArgs e) //3 items
        {
            btnbacksheldon.Enabled = true;
            btnbacksheldon.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureSheldon.Visible = true;
        }

        private void btnbacksheldon_Click(object sender, EventArgs e)
        {
            pictureSheldon.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            btnbacksheldon.Enabled = false;
            btnbacksheldon.Visible = false;
            btnsheldonroom.Enabled = false;
        }

        private void btnleonardroom_Click(object sender, EventArgs e) //2 items
        {
            btnbackleonard.Enabled = true;
            btnbackleonard.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureleonardroom.Visible = true;
        }

        private void btnbackleonard_Click(object sender, EventArgs e)
        {
            pictureleonardroom.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            btnbackleonard.Enabled = false;
            btnbackleonard.Visible = false;
            btnleonardroom.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((Control)sender).Hide();
            soundeffect3();
            score3++;
            labelfound.Text = "Found: " + score3 + "/15";
            if (score3==15)
            {
                level3finish.Visible = true;
                cheer = new SoundPlayer();

                cheer.SoundLocation = "cheer.wav";  // a hangfájl elérési útja
                cheer.Load();
                cheer.Play();

            }
        }

        void reset()
        {
            Level3 fr = new Level3();
            fr.ShowDialog();
            this.Close();
        }

        private void btnretry_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void level3welcome_Click(object sender, EventArgs e)
        {
            level3welcome.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;


        }

        private void level3finish_Click(object sender, EventArgs e)
        {
            cheer.Stop();

            Finale fin = new Finale(); // átadjuk a termékeket
            this.Hide();

            fin.ShowDialog();
            this.Close();
        }

        private void Level3_Load(object sender, EventArgs e)
        {
            
        }
    }
}

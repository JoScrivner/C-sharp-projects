using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BirthdayApp
{
    public partial class Finale : Form
    {
        public Finale()
        {
            InitializeComponent();
        }

        private void Finale_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "finale.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.volume=100;

        }
    }
}

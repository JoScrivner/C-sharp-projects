using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GyartmanylapKeszito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlapanyagKezelo_Click(object sender, EventArgs e)
        {
            

           

            AlapanyagForm f2 = new AlapanyagForm();
            f2.ShowDialog();
        }

        private void btnGyartmanylapKezelo_Click(object sender, EventArgs e)
        {
            GyartmanylapForm f4 = new GyartmanylapForm();
            f4.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

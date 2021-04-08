using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iskolak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        internal Iskola I;
        int ID = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbIskolatipus.DataSource = Enum.GetNames(typeof(IskolaTipus));
            
        }

        private void cmbIskolatipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((IskolaTipus)cmbIskolatipus.SelectedIndex)
            {
                case IskolaTipus.altalanos:
                    gbAltalanos.Enabled = true;
                    gbGimnazium.Enabled = false;
                    break;
                case IskolaTipus.gimnazium:
                    gbGimnazium.Enabled = true;
                    gbAltalanos.Enabled = false;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbCim.Text != "" && tbIgazgato.Text != "" && tbMegnevezes.Text != "")
            {
                switch ((IskolaTipus)cmbIskolatipus.SelectedIndex)
                {
                    case IskolaTipus.altalanos:
                        I = new Altalanos(tbMegnevezes.Text, (int)numAktiv.Value, (int)numMax.Value, tbCim.Text, tbIgazgato.Text, (int)numOsz.Value, cbTagozat.Checked, cbSzakkorok.Checked);
                        break;
                    case IskolaTipus.gimnazium:
                        I = new Gimnazium(tbMegnevezes.Text, (int)numAktiv.Value, (int)numMax.Value, tbCim.Text, tbIgazgato.Text, cbKozponti.Checked, cbSport.Checked, (int)numTermek.Value);
                        break;
                }
                I.IID = ID;  // visszaírjuk a kimentett ID-t
            }
            else
            {
                MessageBox.Show("Nem töltött ki minden szövegmezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}

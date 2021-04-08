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
    public partial class UjAlapanyagForm : Form
    {
        internal Alapanyag P;

        public UjAlapanyagForm()
        {
            InitializeComponent();
        }

        private void UjAlapanyagForm_Load(object sender, EventArgs e)
        {
            if (P == null)
            {
                Text = "Új alapanyag hozzáadása";

            }
            else
            {
                Text = "Alapanyag módosítása";

                tbMegnevezes.Text = P.Megnevezes;
                numFeherje.Value = new decimal((double)P.Feherje);
                numZsir.Value = new decimal((double)P.Zsir);
                numSo.Value = new decimal((double)P.So);
                numCukor.Value = new decimal((double)P.Cukor);
                cbGluten.Checked = P.Gluten;
                cbRakfelek.Checked = P.Rakfelek;
                cbTojas.Checked = P.Tojas;
                cbHalak.Checked = P.Halak;
                cbFoldimogyoro.Checked = P.Foldimogyoro;
                cbSzoja.Checked = P.Szoja;
                cbTej.Checked = P.Tej;
                cbDiofelek.Checked = P.Diofelek;
                cbZeller.Checked = P.Zeller;
                cbMustar.Checked = P.Mustar;
                cbSzezammag.Checked = P.Szezammag;
                cbKendioxid.Checked = P.Kendioxid;
                cbCsillagfurt.Checked = P.Csillagfurt;
                cbPuhatestuek.Checked = P.Puhatestuek;
                

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbMegnevezes.Text != "")

            {
                
                 P = new Alapanyag(tbMegnevezes.Text, (double)numFeherje.Value, (double)numZsir.Value, (double)numSo.Value, (double)numCukor.Value, cbGluten.Checked, cbRakfelek.Checked, cbTojas.Checked, cbHalak.Checked, cbFoldimogyoro.Checked, cbSzoja.Checked, cbTej.Checked, cbDiofelek.Checked, cbZeller.Checked, cbMustar.Checked, cbSzezammag.Checked, cbKendioxid.Checked, cbCsillagfurt.Checked, cbPuhatestuek.Checked);
                        
            }
            else
            {
                MessageBox.Show("Nem töltött ki minden szövegmezőt!");
                DialogResult = DialogResult.None;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

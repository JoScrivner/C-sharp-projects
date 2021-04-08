using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvesboltMintaVizsga
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        internal Konyv K;
        int ID = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbKonyvTipus.DataSource = Enum.GetNames(typeof(KonyvTipus));
            cmbTerulet.DataSource = Enum.GetNames(typeof(TudomanyTeruletTipus));
            cmbKategoria.DataSource = Enum.GetNames(typeof(KategoriaTipus));

            if (K != null)  // van módosítandó könyv
            {
                Text = "Könyv módosítása";
                tbCim.Text = K.Cim;
                tbSzerzo.Text = K.Szerzo;
                nudOldalszam.Value = K.Oldalszam;
                nudAr.Value = K.Ar;
                nudKiadasEve.Value = K.KiadasEve;
                ID = K.DBID;  // kimentjük a módosítandó könyv adatbázisbeli ID-ját
                switch (K)
                {
                    case IrodalmiKonyv ik:
                        cmbKonyvTipus.SelectedIndex = (int)KonyvTipus.irodalmi;
                        cmbKategoria.SelectedIndex = (int)ik.Kategoria;
                        break;
                    case TudomanyosKonyv tk:
                        cmbKonyvTipus.SelectedIndex = (int)KonyvTipus.tudományos;
                        cmbTerulet.SelectedIndex = (int)tk.TudomanyTerulet;
                        cbElismert.Checked = tk.Elismert;
                        break;
                }
                cmbKonyvTipus.Enabled = false;  // módosításnál NEM lehet könyvtípust módosítani!
            }
        }

        private void cmbKonyvTipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((KonyvTipus)cmbKonyvTipus.SelectedIndex)
            {
                case KonyvTipus.tudományos:
                    gbTudomanyos.Enabled = true;
                    gbIrodalmi.Enabled = false;
                    break;
                case KonyvTipus.irodalmi:
                    gbIrodalmi.Enabled = true;
                    gbTudomanyos.Enabled = false;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbCim.Text != "" && tbSzerzo.Text != "")
            {
                switch ((KonyvTipus)cmbKonyvTipus.SelectedIndex)
                {
                    case KonyvTipus.tudományos:
                        K = new TudomanyosKonyv(tbCim.Text, tbSzerzo.Text, (int)nudOldalszam.Value, (int)nudAr.Value, (int)nudKiadasEve.Value, (TudomanyTeruletTipus)cmbTerulet.SelectedIndex, cbElismert.Checked);
                        break;
                    case KonyvTipus.irodalmi:
                        K = new IrodalmiKonyv(tbCim.Text, tbSzerzo.Text, (int)nudOldalszam.Value, (int)nudAr.Value, (int)nudKiadasEve.Value, (KategoriaTipus)cmbKategoria.SelectedIndex);
                        break;
                }
                K.DBID = ID;  // visszaírjuk a kimentett ID-t
            }
            else
            {
                MessageBox.Show("Nem töltött ki minden szövegmezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}

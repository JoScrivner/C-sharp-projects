using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butorok
{
    public partial class Form2 : Form
    {
        internal Butor P;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbTipus.DataSource = Enum.GetNames(typeof(ButorTipus));
            cmbElhelyezes.DataSource = Enum.GetNames(typeof(ElhelyezesTipus));
            cmbAnyag.DataSource = Enum.GetNames(typeof(AnyagTipus));

            if (P == null) //ekkor új telefont adunk hozzá
            {
                Text = "Új butor hozzáadása";
            }
            else //ekkor módosítjuk a régi adatait (tehát be kell ket tölteni)
            {
                Text = "Butor módosítása";

                tbMegnevezes.Text = P.Megnevezes;
                //cmbTipus.SelectedIndex = (int)P.; //OSType => int konverzió
                cmbElhelyezes.SelectedIndex = (int)P.Elhelyezes;
                cmbAnyag.SelectedIndex = (int)P.Anyag;

                numx.Value = (decimal)P.Meret.x;
                numy.Value = (decimal)P.Meret.y;
                numz.Value = (decimal)P.Meret.z;
                numDarab.Value = (decimal)P.DB;

                switch (P)   // elágazás a változó DINAMIKUS típusa szerint
                {
                    case Asztal asz:
                        cmbTipus.SelectedIndex = (int)ButorTipus.asztal;  // a combobox-ból kiválasztjuk a tejterméket
                        cbkinyitajtos.Checked = asz.Kinyithato;
                        cbcsuszasuveg.Checked = asz.Csuszasgatlos;
                        numferopolc.Value = asz.Ferohely;
                        break;
                    case Szekreny sz:
                        cmbTipus.SelectedIndex = (int)ButorTipus.szekreny;
                        cbkinyitajtos.Checked = sz.Ajtos;
                        cbcsuszasuveg.Checked = sz.Uvegezheto;
                        numferopolc.Value = sz.Polcok;
                        break;
                    
                }

            }
        }

        private void cmbTipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ButorTipus)cmbTipus.SelectedIndex)
            {
                case ButorTipus.asztal:
                    cbkinyitajtos.Text = "Kinyithato";
                    cbcsuszasuveg.Text = "Csuszasgatlos";
                    labelFeroPolc.Text = "Ferohely:";
                    break;
                case ButorTipus.szekreny:
                    cbkinyitajtos.Text = "Ajtos";
                    cbcsuszasuveg.Text = "Uvegezheto";
                    labelFeroPolc.Text = "Polcok szama:";
                    break;
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbMegnevezes.Text != "")

            {
                switch ((ButorTipus)cmbTipus.SelectedIndex)
                {
                    case ButorTipus.asztal:
                        P = new Asztal(tbMegnevezes.Text, (int)numx.Value, (int)numy.Value, (int)numz.Value, (AnyagTipus)cmbAnyag.SelectedIndex, (ElhelyezesTipus)cmbElhelyezes.SelectedIndex, (int)numDarab.Value, cbkinyitajtos.Checked, (int)numferopolc.Value, cbcsuszasuveg.Checked);
                        break;

                    case ButorTipus.szekreny:
                        P= new Szekreny(tbMegnevezes.Text, (int)numx.Value, (int)numy.Value, (int)numz.Value, (AnyagTipus)cmbAnyag.SelectedIndex, (ElhelyezesTipus)cmbElhelyezes.SelectedIndex, (int)numDarab.Value, cbkinyitajtos.Checked, cbcsuszasuveg.Checked, (int)numferopolc.Value);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Nem töltött ki minden szövegmezőt!");
                DialogResult = DialogResult.None;
            }
            
        }
    }
}

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
using System.Xml.Linq;

namespace KonyvesboltMintaVizsga
{
    public partial class Form1 : Form
    {
        KonyvLista konyvek;

        public Form1()
        {
            InitializeComponent();
        }

        void ListBoxFrissites()
        {
            lbIrodalmi.Items.Clear();
            lbTudomanyos.Items.Clear();
            foreach (var item in konyvek)
            {
                if (item is IrodalmiKonyv)
                {
                    lbIrodalmi.Items.Add(item);
                }
                else
                {
                    lbTudomanyos.Items.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                konyvek = ABKezelo.Listaz();
                ListBoxFrissites();

                // ezt NEM kérte a feladat:
                konyvek.UjElem += ABKezelo.Beszuras;  // feliratkozás az egyik eseményre
                konyvek.ElemTorolve += ABKezelo.Torles;  // feliratkozás a másik eseményre

                // ezt KÉRTE a feladat:
                konyvek.UjElem += Konyvek_Valtozott;
                konyvek.ElemTorolve += Konyvek_Valtozott;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz. " + ex.Message);
            }
        }

        private void Konyvek_Valtozott(Konyv k)
        {
            Text = "Könyvesbolt [*]";
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XDocument xml = new XDocument(new XElement("Könyvek"));  // XML dokumentum létrehozása, benne egy root node-dal
                foreach (var item in konyvek)  // végigmegyünk az összes könyvön
                {
                    xml.Root.Add(item.ToXML());  // hozzáadjuk a root node-hoz a könyvet
                }
                xml.Save(saveFileDialog1.FileName);  // mentés
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan ki akar lépni?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                konyvek.Add(f2.K);  // "átnyúlunk" a Form2-re a létrehozott könyvért
                ListBoxFrissites();
            }
        }

        private void lbIrodalmi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbIrodalmi.SelectedIndex > -1)
            {
                lbTudomanyos.SelectedIndex = -1;
            }
        }

        private void lbTudomanyos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTudomanyos.SelectedIndex > -1)
            {
                lbIrodalmi.SelectedIndex = -1;
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (lbIrodalmi.SelectedIndex > -1 || lbTudomanyos.SelectedIndex > -1)
            {
                if (MessageBox.Show("Biztosan törölni akarja a könyvet?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Konyv k = lbIrodalmi.SelectedIndex > -1 ? (Konyv)lbIrodalmi.SelectedItem : (Konyv)lbTudomanyos.SelectedItem;
                    konyvek.Remove(k);
                    ListBoxFrissites();
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt könyv!");
            }
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            if (lbIrodalmi.SelectedIndex > -1 || lbTudomanyos.SelectedIndex > -1)
            {
                Konyv k = lbIrodalmi.SelectedIndex > -1 ? (Konyv)lbIrodalmi.SelectedItem : (Konyv)lbTudomanyos.SelectedItem;
                int ind = konyvek.IndexOf(k);  // megkeressük a könyvet a listában
                Form2 f2 = new Form2();
                f2.K = k;  // átadjuk a módosítandó könyvet
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    konyvek[ind] = f2.K;  // a módosított könyvet visszaírjuk a listába
                    ListBoxFrissites();
                    ABKezelo.Modositas(f2.K);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt könyv!");
            }
        }

        private void lbIrodalmi_DoubleClick(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;  // akire a kattintás történt
            if (lb.SelectedIndex > -1)
            {
                Konyv k = (Konyv)lb.SelectedItem;  // az a könyv, amire duplán kattintottak
                Form3 f3 = new Form3();
                f3.dragabbak = konyvek.FindAll(x => x.CompareTo(k) > 0); // a "nagyobb" könyvek kiszűrése
                f3.ShowDialog();
            }
        }
    }
}

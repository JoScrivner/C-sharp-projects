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


namespace Iskolak
{
    public partial class Form1 : Form
    {
        IskolaLista iskolak;

        public Form1()
        {
            InitializeComponent();
        }

        void ListBoxFrissites()
        {
            lbAltalanos.Items.Clear();
            lbGimnazium.Items.Clear();
            foreach (var item in iskolak)
            {
                if (item is Altalanos)
                {
                    lbAltalanos.Items.Add(item);
                }
                else
                {
                    lbGimnazium.Items.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                iskolak = ABKezelo.Listaz();
                ListBoxFrissites();

                // ezt (NEM) kérte a feladat:
                iskolak.UjElem += ABKezelo.Beszuras;  // feliratkozás az egyik eseményre
                iskolak.ElemTorolve += ABKezelo.Torles;  // feliratkozás a másik eseményre

                // ezt NEM KÉRTE a feladat:
                iskolak.UjElem += Iskolak_Valtozott;
                iskolak.ElemTorolve += Iskolak_Valtozott;
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz. " + ex.Message);
            }
        }

        
        private void Iskolak_Valtozott(Iskola i)
        {
            Text = "Iskolak [*]";
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
                iskolak.Add(f2.I);
                ListBoxFrissites();
            }

        }


        private void lbAltalanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAltalanos.SelectedIndex > -1)
            {
                lbGimnazium.SelectedIndex = -1;
            }
        }

        private void lbGimnazium_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGimnazium.SelectedIndex > -1)
            {
                lbAltalanos.SelectedIndex = -1;
            }
        }


        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (lbAltalanos.SelectedIndex > -1 || lbGimnazium.SelectedIndex > -1)
            {
                if (MessageBox.Show("Biztosan törölni akarja a könyvet?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Iskola i = lbAltalanos.SelectedIndex > -1 ? (Iskola)lbAltalanos.SelectedItem : (Iskola)lbAltalanos.SelectedItem;
                    iskolak.Remove(i);
                    ListBoxFrissites();
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt könyv!");
            }
        }

        private void lbAltalanos_Click(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb.SelectedIndex > -1)
            {
                labelkalk.Text = $"Fenntartasi koltseg: {(lb.SelectedItem as Iskola).FenntartasiKoltseg()} Ft";
            }
        }
        private void lbGimnazium_Click(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb.SelectedIndex > -1)
            {
                labelkalk.Text = $"Fenntartasi koltseg: {(lb.SelectedItem as Iskola).FenntartasiKoltseg()} Ft";
            }
        }

        /*
        private void btnXML_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XDocument xml = new XDocument(new XElement("Iskolak"));  // XML dokumentum létrehozása, benne egy root node-dal
                foreach (var item in iskolak)  // végigmegyünk az összes könyvön
                {
                    xml.Root.Add(item.ToXML());  // hozzáadjuk a root node-hoz a könyvet
                }
                xml.Save(saveFileDialog.FileName);  // mentés
            }
        }
        */
    }
}

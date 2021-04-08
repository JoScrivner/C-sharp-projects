using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butorok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                lbButorok.Items.Add(f2.P);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if (MessageBox.Show("Biztosan ki akar lépni?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (StreamWriter w = new StreamWriter("butorok.csv", false, Encoding.UTF8))
                    {
                        foreach (Butor item in lbButorok.Items)
                        {
                            w.WriteLine(item.ToCSV());
                        }
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            
        }


        int mp;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("butorok.csv"))
            {
                string[] fajl = File.ReadAllLines("butorok.csv"); //fájl beolvasása egyetlen utasítással
                foreach (var item in fajl)
                {
                    //Butor b = new Butor(item);
                   // lbButorok.Items.Add(b);

                    string[] db = item.Split(';');
                    Butor b = null;
                    switch ((ButorTipus)int.Parse(db[0]))
                    {
                        case ButorTipus.asztal: b = new Asztal(item); break;
                        case ButorTipus.szekreny: b = new Szekreny(item); break;
                        
                    }
                    lbButorok.Items.Add(b);
                }
            }
            mp = 300;
            timer1.Enabled = true;
            DateTime dt = DateTime.Today.AddSeconds(mp);
        }


        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (lbButorok.SelectedIndex > -1)
            {
                if (MessageBox.Show("Biztosan törli a kijelölt terméket?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lbButorok.Items.RemoveAt(lbButorok.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt termék!");
            }
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            int ind = lbButorok.SelectedIndex;  // a kijelölt elem sorszáma
            if (ind > -1)
            {
                Form2 f2 = new Form2();
                f2.P = (Butor)lbButorok.SelectedItem;  // "átküldjük" a módosítandó objektumot
                if (f2.ShowDialog() == DialogResult.OK)  // megnyitjuk az ablakot, és ha az OK-val zárta be, akkor...
                {
                    lbButorok.Items.RemoveAt(ind);  // a régi objektum törlése
                    lbButorok.Items.Insert(ind, f2.P);  // beszúrjuk az új objektumot a régi helyére
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt termék!");
            }
        }

        private void lbButorok_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show($"{lbButorok.SelectedItem.ToString()}");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            mp--;
            DateTime dt = DateTime.Today.AddSeconds(mp);          
            if (mp == 0)
            {
                timer1.Enabled = false;
                btnKeres.Enabled = true;
            }
        }


        private void btnKeres_Click(object sender, EventArgs e)
        {
            List<Butor> lista = new List<Butor>();
            foreach (Butor item in lbButorok.Items)
            {
                lista.Add(item);
            }

            Form3 f3 = new Form3(lista);  // átadjuk a termékeket
            f3.ShowDialog();  // megnyitjuk az ablakot
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            double osszdb = 0;
            double osszar = 0;
            int osszx = 0;
            int osszy = 0;
            int osszz = 0;
            foreach (Butor item in lbButorok.Items)
            {
                osszdb++;
                osszar += item.Ar();
                osszx += item.Meret.x;
                osszy += item.Meret.y;
                osszz += item.Meret.z;

            }
            MessageBox.Show($"Átlagár: {osszar/osszdb} Ft, átlagméret: {osszx/osszdb} cm *{osszy / osszdb} cm *{osszz / osszdb} cm");
        }*/


        private void button1_Click(object sender, System.EventArgs e)
        {
            double osszdb = 0;
            double osszar = 0;
            int osszx = 0;
            int osszy = 0;
            int osszz = 0;
            foreach (Butor item in lbButorok.Items)
            {
                osszdb++;
                osszar += item.Ar();
                osszx += item.Meret.x;
                osszy += item.Meret.y;
                osszz += item.Meret.z;
                
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // or just "txt files (*.txt)|*.txt" if you only want to save text files
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    writer.WriteLine($"Átlagár: {Math.Round(osszar / osszdb)} Ft, átlagméret: {Math.Round((osszx / osszdb),2)} cm * {Math.Round((osszy / osszdb),2)} cm * {Math.Round((osszz / osszdb),2)} cm");
                    writer.Close();
                }
            }
        }
    }
}

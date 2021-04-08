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


namespace GyartmanylapKeszito
{
    public partial class AlapanyagForm : Form
    {
        List<Alapanyag> talalatok;
        List<Alapanyag> lista = new List<Alapanyag>();

        

        public AlapanyagForm()
        {
            InitializeComponent();
            
        }

        private void AlapanyagForm_Load(object sender, EventArgs e)
        {
            lbKereses.Visible = false;
            Encoding encoding = Encoding.GetEncoding(1250);
            if (File.Exists("files/tapertekadatok.csv"))
            {
                string[] fajl = File.ReadAllLines("files/tapertekadatok.csv", encoding);
                foreach (var item in fajl)
                {

                    string[] db = item.Split(';');
                    Alapanyag al = null;
                    al = new Alapanyag(item);
                    lbTalalatok.Items.Add(al);
                    lista.Add(al);
                } 
            }
        }

        
        


        void Listaz(List<Alapanyag> lista)
        {
            lbKereses.Items.Clear();
            foreach (var item in lista)
            {
                lbKereses.Items.Add($"{item.Megnevezes}");
            }
        }

        
        

        const string EKEZETES = "áaÁAéeÉEíiÍIóoÓOöoÖOőoŐOúuÚUüuÜUűuŰU";
        static string EkezetNelkul(string szoveg)
        {
            string eredmeny = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] >= 'a' && szoveg[i] <= 'z' || szoveg[i] >= 'A' && szoveg[i] <= 'Z')
                {
                    eredmeny += szoveg[i];
                }
                else   // az i. karakter NEM az angol ábécé kis- vagy nagybetűje
                {
                    int ind = EKEZETES.IndexOf(szoveg[i]);  // az ékezetes karakterek között keresünk
                    if (ind > -1)  // megtaláltuk
                    {
                        eredmeny += EKEZETES[ind + 1];  // a KÖVETKEZŐ karaktert fűzzük hozzá
                    }
                    else  // ha nem az angol ábécé karaktere, és nem ékezetes
                    {
                        eredmeny += szoveg[i];
                    }
                }
            }
            return eredmeny;
        }

        
        private void tbKeres_TextChanged(object sender, EventArgs e)
        {
            if (tbKeres.Text != "")
            {
                lbKereses.Visible = true;
                lbKereses.Items.Clear();
                string szoveg = tbKeres.Text;
                string eredmeny = EkezetNelkul(szoveg);
                talalatok = new List<Alapanyag>();
                foreach (var item in lista)
                {
                    if (item.Megnevezes.ToLower().Contains(szoveg.ToLower()))  // ha a megnevezés tartalmazza a beírt szöveget
                    {
                        talalatok.Add(item);
                    }
                }
                Listaz(talalatok);
                
            }
            else
            {

               lbKereses.Visible = false;
                
            }
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            UjAlapanyagForm f3 = new UjAlapanyagForm();
            if (f3.ShowDialog() == DialogResult.OK)
            {
                lbTalalatok.Items.Add(f3.P);
                lista.Add(f3.P);
                
                tbKeres_TextChanged(sender, e);
                
            }
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (tbKeres.Text == "")
            {
                if (lbTalalatok.SelectedIndex > -1)
                {
                    if (MessageBox.Show("Biztosan törli a kijelölt alapanyagot?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lista.RemoveAt(lbTalalatok.SelectedIndex);
                        lbTalalatok.Items.RemoveAt(lbTalalatok.SelectedIndex);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Nincs kijelölt alapanyag!");
                } 
            }
            else
            {
                int ind2 = lbKereses.SelectedIndex;
                if (ind2 > -1)
                {
                    int n=lista.Count;
                    int i = 0;
                    bool isFound = false;
                    while (!isFound & i<n)
                    {
                         isFound = lista[i].ToString() == lbKereses.SelectedItem.ToString();
                         i++;

                         if (isFound) 
                         {
                            i--;
                            int indk = lbTalalatok.Items.IndexOf(lista[i]);

                            if (MessageBox.Show("Biztosan törli a kijelölt alapanyagot?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                
                                lbTalalatok.Items.RemoveAt(indk);
                                lista.RemoveAt(indk);
                                n--;
                                lbKereses.Items.Clear();
                                string szoveg = tbKeres.Text;
                                string eredmeny = EkezetNelkul(szoveg);
                                talalatok = new List<Alapanyag>();
                                foreach (var item in lista)
                                {
                                    if (item.Megnevezes.ToLower().Contains(szoveg.ToLower()))  // ha a megnevezés tartalmazza a beírt szöveget
                                    {
                                        talalatok.Add(item);
                                    }
                                }
                                Listaz(talalatok);

                            }
                            

                         }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Nincs kijelölt alapanyag!");
                }
            }
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {

            if (tbKeres.Text == "")
            {
                int ind = lbTalalatok.SelectedIndex;  // a kijelölt elem sorszáma
                if (ind > -1)
                {
                    UjAlapanyagForm f3 = new UjAlapanyagForm();
                    f3.P = (Alapanyag)lbTalalatok.SelectedItem;  // "átküldjük" a módosítandó objektumot
                    if (f3.ShowDialog() == DialogResult.OK)  // megnyitjuk az ablakot, és ha az OK-val zárta be, akkor...
                    {
                        lbTalalatok.Items.RemoveAt(ind);  // a régi objektum törlése
                        lista.RemoveAt(ind);

                        lbTalalatok.Items.Insert(ind, f3.P);  // beszúrjuk az új objektumot a régi helyére
                        lista.Insert(ind, f3.P);
                        tbKeres_TextChanged(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Nincs kijelölt alapanyag!");
                }
            }
            else
            {
                int ind2 = lbKereses.SelectedIndex;
                if (ind2 > -1)
                {
                    int n = lista.Count;
                    int i = 0;
                    bool isFound = false;
                    while (!isFound & i < n)
                    {
                        isFound = lista[i].ToString() == lbKereses.SelectedItem.ToString();
                        i++;

                        if (isFound)
                        {
                            i--;
                            int indk = lbTalalatok.Items.IndexOf(lista[i]);


                            UjAlapanyagForm f3 = new UjAlapanyagForm();
                            f3.P = (Alapanyag)lista[i];  // "átküldjük" a módosítandó objektumot
                            if (f3.ShowDialog() == DialogResult.OK)  // megnyitjuk az ablakot, és ha az OK-val zárta be, akkor...
                            {
                                lbTalalatok.Items.Remove(lista[i]);  // a régi objektum törlése
                                lista.RemoveAt(i);
                                lbTalalatok.Items.Add(f3.P);
                                lista.Insert(i, f3.P);
                                
                                tbKeres_TextChanged(sender, e);
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nincs kijelölt alapanyag!");
                }
            }


        }

        private void AlapanyagForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter w = new StreamWriter("files/tapertekadatok.csv", false, Encoding.UTF8))
            {
                foreach (Alapanyag item in lbTalalatok.Items)
                {
                    w.WriteLine(item.ToCSV());
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnUj_MouseHover(object sender, EventArgs e)
        {
            panel1.Height = btnUj.Height;
            panel1.Top = btnUj.Top;
        }

        private void btnModosit_MouseHover(object sender, EventArgs e)
        {
            panel1.Height = btnModosit.Height;
            panel1.Top = btnModosit.Top;
        }

        private void btnTorles_MouseHover(object sender, EventArgs e)
        {
            panel1.Height = btnTorles.Height;
            panel1.Top = btnTorles.Top;
        }

        
    }
}

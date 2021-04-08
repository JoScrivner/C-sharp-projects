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
    public partial class AnyaghanyadForm : Form
    {
        Form _aform;
        List<Alapanyag> hozzavalok = new List<Alapanyag>();
        List<Hozzavalo> felhasznalni = new List<Hozzavalo>();
        List<Hozzavalo> rendezett;

        public static double total;
        public static double feherjeSZ;
        public static double zsirSZ;
        public static double soSZ;
        public static double cukorSZ;

        public AnyaghanyadForm(Form aform)
        {
            _aform = aform;
            InitializeComponent();
            
        }

       

        void TapertekSzamitas(List<Hozzavalo> lista)
        {
            total = lista.Sum(item1 => item1.Mennyiseg);
            double totalFeh = lista.Sum(item2 => item2.Feherjetart());
            double totalZsir = lista.Sum(item3 => item3.Zsirtart());
            double totalSo = lista.Sum(item4 => item4.Sotart());
            double totalCuk = lista.Sum(item5 => item5.Cukortart());
           
            feherjeSZ = (totalFeh / (total / 100));
            zsirSZ = (totalZsir / (total / 100));
            soSZ = (totalSo / (total / 100));
            cukorSZ = (totalCuk / (total / 100));
            
        }

        

        void Rendez(List<Hozzavalo> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i].Mennyiseg < lista[j].Mennyiseg)
                    {
                        Hozzavalo s = lista[i];
                        lista[i] = lista[j];
                        lista[j] = s;
                    }
                }
            }
        }

        void Listaz(List<Hozzavalo> lista)
        {
            listBox1.Items.Clear();
            foreach (var item in lista)
            {
                listBox1.Items.Add(item);
            }
        }

        private void Anyaghanyad_Load(object sender, EventArgs e)
        {
            
            string filenev = UjGyartmanylapForm.passingtext + ".csv";
            Encoding encoding = Encoding.GetEncoding(1250);
            if (File.Exists("files/tapertekadatok.csv"))
            {
                string[] fajl = File.ReadAllLines("files/tapertekadatok.csv", encoding);
                foreach (var item in fajl)
                {
                    string[] db = item.Split(';');

                    Alapanyag hoz = null;
                    hoz = new Alapanyag(item);
                    hozzavalok.Add(hoz);
                    cmb1.Items.Add(hoz);
                    
                }
                


            }
            if (File.Exists($"files/{filenev}"))
            {
                string[] fajl2 = File.ReadAllLines($"files/{filenev}", encoding);
                foreach (var sor in fajl2)
                {
                    string[] db = sor.Split(';');
                    Hozzavalo al = null;
                    al = new Hozzavalo(sor);
                    felhasznalni.Add(al);
                    listBox1.Items.Add(al);
                    
                    TapertekSzamitas(felhasznalni);
                }

            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string filenev = UjGyartmanylapForm.passingtext + ".csv";
            
            using (StreamWriter w = new StreamWriter($"files/{filenev}", false, Encoding.UTF8))
            {
                foreach (Hozzavalo item in listBox1.Items)
                {
                    w.WriteLine(item.ToCSV());
                }
                
            }

            UjGyartmanylapForm objMain = (UjGyartmanylapForm)_aform;
            
            objMain.numFeherjesz.Value = new decimal(feherjeSZ);
            objMain.numZsirsz.Value = new decimal(zsirSZ);
            objMain.numSosz.Value = new decimal(soSZ);
            objMain.numCukorsz.Value = new decimal(cukorSZ);
            objMain.cbGluten.Checked = false;
            objMain.cbRakfelek.Checked = false;
            objMain.cbTojas.Checked = false;
            objMain.cbHalak.Checked = false;
            objMain.cbFoldimogyoro.Checked = false;
            objMain.cbSzoja.Checked = false;
            objMain.cbTej.Checked = false;
            objMain.cbDiofelek.Checked = false;
            objMain.cbZeller.Checked = false;
            objMain.cbMustar.Checked = false;
            objMain.cbSzezammag.Checked = false;
            objMain.cbKendioxid.Checked = false;
            objMain.cbCsillagfurt.Checked = false;
            objMain.cbPuhatestuek.Checked = false;

            foreach (var elem in felhasznalni)
            {
                if (elem.Gluten == true)
                {
                    objMain.cbGluten.Checked = true;
                }
                if (elem.Rakfelek == true)
                {
                    objMain.cbRakfelek.Checked = true;
                }
                if (elem.Tojas == true)
                {
                    objMain.cbTojas.Checked = true;
                }
                if (elem.Halak == true)
                {
                    objMain.cbHalak.Checked = true;
                }
                if (elem.Foldimogyoro == true)
                {
                    objMain.cbFoldimogyoro.Checked = true;
                }
                if (elem.Szoja == true)
                {
                    objMain.cbSzoja.Checked = true;
                }
                if (elem.Tej == true)
                {
                    objMain.cbTej.Checked = true;
                }
                if (elem.Diofelek == true)
                {
                    objMain.cbDiofelek.Checked = true;
                }
                if (elem.Zeller == true)
                {
                    objMain.cbZeller.Checked = true;
                }
                if (elem.Mustar == true)
                {
                    objMain.cbMustar.Checked = true;
                }
                if (elem.Szezammag == true)
                {
                    objMain.cbSzezammag.Checked = true;
                }
                if (elem.Kendioxid == true)
                {
                    objMain.cbKendioxid.Checked = true;
                }
                if (elem.Csillagfurt == true)
                {
                    objMain.cbCsillagfurt.Checked = true;
                }
                if (elem.Puhatestuek == true)
                {
                    objMain.cbPuhatestuek.Checked = true;
                }
            }

        }

        

        private void btnHozzaad_Click(object sender, EventArgs e)
        {

            if (cmb1.SelectedIndex > -1)
            {
                Hozzavalo h = new Hozzavalo(cmb1.Text, (cmb1.SelectedItem as Alapanyag).Feherje, (cmb1.SelectedItem as Alapanyag).Zsir, (cmb1.SelectedItem as Alapanyag).So,
                    (cmb1.SelectedItem as Alapanyag).Cukor, (cmb1.SelectedItem as Alapanyag).Gluten, (cmb1.SelectedItem as Alapanyag).Rakfelek, (cmb1.SelectedItem as Alapanyag).Tojas,
                    (cmb1.SelectedItem as Alapanyag).Halak, (cmb1.SelectedItem as Alapanyag).Foldimogyoro, (cmb1.SelectedItem as Alapanyag).Szoja, (cmb1.SelectedItem as Alapanyag).Tej,
                    (cmb1.SelectedItem as Alapanyag).Diofelek, (cmb1.SelectedItem as Alapanyag).Zeller, (cmb1.SelectedItem as Alapanyag).Mustar, (cmb1.SelectedItem as Alapanyag).Szezammag,
                    (cmb1.SelectedItem as Alapanyag).Kendioxid, (cmb1.SelectedItem as Alapanyag).Csillagfurt, (cmb1.SelectedItem as Alapanyag).Puhatestuek, (double)num1.Value);


                felhasznalni.Add(h);

                rendezett = new List<Hozzavalo>(felhasznalni);
                Rendez(rendezett);
                Listaz(rendezett);
                

                TapertekSzamitas(felhasznalni); 
            }
            else
            {
                MessageBox.Show("Kérem válasszon ki egy alapanyagot a legördülő menüből!");
            }

        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                if (MessageBox.Show("Biztosan törli a kijelölt hozzávalót?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    felhasznalni.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                    TapertekSzamitas(felhasznalni);

                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt hozzávaló!");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

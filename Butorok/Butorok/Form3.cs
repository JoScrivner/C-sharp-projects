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
    public partial class Form3 : Form
    {
        List<Butor> termekek, talalatok, rendezett;

        // a konstruktort úgy módosítottuk, hogy a termékek listáját át kell adnunk paraméterként meghíváskor
        internal Form3(List<Butor> atadott)
        {
            InitializeComponent();
            termekek = atadott;
        }

        void Listaz(List<Butor> lista)
        {
            lbTalalatok.Items.Clear();
            foreach (var item in lista)
            {
                lbTalalatok.Items.Add($"{item.Megnevezes}");
            }
        }


        void Rendez(List<Butor> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i].Ar() > lista[j].Ar())
                    {
                        Butor s = lista[i];
                        lista[i] = lista[j];
                        lista[j] = s;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbTalalatok.Items.Clear();
            if (tbKeres.Text != "")
            {
                talalatok = new List<Butor>();
                foreach (var item in termekek)
                {
                    if (item.Megnevezes.ToLower().Contains(tbKeres.Text.ToLower()))  // ha a megnevezés tartalmazza a beírt szöveget
                    {
                        talalatok.Add(item);
                    }
                }
                if (cbRendezett.Checked)   // ha a rendezett adatmegjelenítés be van kapcsolva
                {
                    rendezett = new List<Butor>(talalatok);  // a rendezett listába bemásolom a találatokat
                    Rendez(rendezett);
                    Listaz(rendezett);
                }
                else
                {
                    Listaz(talalatok);
                }
            }
        }
    }
}

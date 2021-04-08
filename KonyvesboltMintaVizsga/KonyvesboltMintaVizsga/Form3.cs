using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvesboltMintaVizsga
{
    public partial class Form3 : Form
    {
        internal List<Konyv> dragabbak;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dragabbak.ForEach(x => lbKonyvek.Items.Add(x));  // minden könyv listázása
        }

        private void btnSzures_Click(object sender, EventArgs e)
        {
            var lin = from x in dragabbak
                      where x.Oldalszam >= nudOldalszam.Value && x.KiadasEve == nudKiadasEve.Value
                      select x;
            lbKonyvek.DataSource = null;
            lbKonyvek.DataSource = lin.ToList();
        }
    }
}

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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GyartmanylapKeszito
{
    public partial class UjGyartmanylapForm : Form
    {
        internal Gyartmanylap G;
        List<Hozzavalo> felhasznalni2 = new List<Hozzavalo>();

        

        public static string passingtext;

        public UjGyartmanylapForm()
        {
            InitializeComponent();
            int h = Screen.PrimaryScreen.Bounds.Height - 40;
            //int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.Size = new Size(1240, h);
        }

        

        private void UjGyartmanylapForm_Load(object sender, EventArgs e)
        {
            if (G == null)
            {
                Text = "Új gyártmánylap létrehozása";

            }
            else
            {
                Text = "Gyártmánylap szerkesztése";

                tbGyMegnevezes.Text = G.GyMegnevezes;
                tbCim1.Text = G.Cim1.Replace("nlw", Environment.NewLine);
                tbCim2.Text = G.Cim2.Replace("nlw", Environment.NewLine);
                tbLeiras3.Text = G.Leiras3.Replace("nlw", Environment.NewLine);
                tbLeiras4.Text = G.Leiras4.Replace("nlw", Environment.NewLine);
                tbLeiras5.Text = G.Leiras5;
                tbBiztonsag1.Text = G.Biztonsag1.Replace("nlw", Environment.NewLine);
                tbBiztonsag2.Text = G.Biztonsag2.Replace("nlw", Environment.NewLine);
                cbGluten.Checked = G.Gluten;
                cbRakfelek.Checked = G.Rakfelek;
                cbTojas.Checked = G.Tojas;
                cbHalak.Checked = G.Halak;
                cbFoldimogyoro.Checked = G.Foldimogyoro;
                cbSzoja.Checked = G.Szoja;
                cbTej.Checked = G.Tej;
                cbDiofelek.Checked = G.Diofelek;
                cbZeller.Checked = G.Zeller;
                cbMustar.Checked = G.Mustar;
                cbSzezammag.Checked = G.Szezammag;
                cbKendioxid.Checked = G.Kendioxid;
                cbCsillagfurt.Checked = G.Csillagfurt;
                cbPuhatestuek.Checked = G.Puhatestuek;
                tbMegjelenes.Text = G.Megjelenes;
                tbSzin.Text = G.Szin;
                tbIz.Text = G.Iz;
                tbIllat.Text = G.Illat;
                tbAllomany.Text = G.Allomany;
                tbMinosegi4.Text = G.Minosegi4.Replace("nlw", Environment.NewLine);
                tbFogyido.Text = G.Fogyido;
                tbTarolas.Text = G.Tarolas;
                dtpErvKezdete.Value = (DateTime)G.ErvKezdete;
                dtpErvVege.Value = (DateTime)G.ErvVege;
                dtpModositasDatuma.Value = (DateTime)G.ModositasDatuma;
                tbFelelosSzemely.Text = G.FelelosSzemely;
                numFeherjesz.Value = new decimal((double)G.Feherjesz);
                numZsirsz.Value = new decimal((double)G.Zsirsz);
                numSosz.Value = new decimal((double)G.Sosz);
                numCukorsz.Value = new decimal((double)G.Cukorsz);
                tbAdalek.Text = G.Adalek;
                               
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (tbGyMegnevezes.Text != "")
            {
                
                string Cim1string = tbCim1.Text.Replace(Environment.NewLine, "nlw");
                string Cim2string = tbCim2.Text.Replace(Environment.NewLine, "nlw");
                string Leiras3string = tbLeiras3.Text.Replace(Environment.NewLine, "nlw");
                string Leiras4string = tbLeiras4.Text.Replace(Environment.NewLine, "nlw");
                string Biztonsagi1string = tbBiztonsag1.Text.Replace(Environment.NewLine, "nlw");
                string Biztonsagi2string = tbBiztonsag2.Text.Replace(Environment.NewLine, "nlw");
                string Minosegi4string= tbMinosegi4.Text.Replace(Environment.NewLine, "nlw");

                G = new Gyartmanylap(tbGyMegnevezes.Text, Cim1string, Cim2string, Leiras3string, Leiras4string, tbLeiras5.Text, Biztonsagi1string, Biztonsagi2string,
                    cbGluten.Checked, cbRakfelek.Checked, cbTojas.Checked, cbHalak.Checked, cbFoldimogyoro.Checked, cbSzoja.Checked, cbTej.Checked, cbDiofelek.Checked,
                    cbZeller.Checked, cbMustar.Checked, cbSzezammag.Checked, cbKendioxid.Checked, cbCsillagfurt.Checked, cbPuhatestuek.Checked, tbMegjelenes.Text,
                    tbSzin.Text, tbIz.Text, tbIllat.Text, tbAllomany.Text, Minosegi4string, tbFogyido.Text, tbTarolas.Text, (DateTime)dtpErvKezdete.Value,
                    (DateTime)dtpErvVege.Value, (DateTime)dtpModositasDatuma.Value, tbFelelosSzemely.Text, (double)numFeherjesz.Value, (double)numZsirsz.Value,
                    (double)numSosz.Value, (double)numCukorsz.Value, tbAdalek.Text);

            }
            else
            {
                MessageBox.Show("Kérem, töltse ki a Megnevezés mezőt!");
                DialogResult = DialogResult.None;
            }
        }

        private void btnAnyaghanyad_Click(object sender, EventArgs e)
        {
            if (tbGyMegnevezes.Text != "")
            {
                passingtext = tbGyMegnevezes.Text;
                
                AnyaghanyadForm aform = new AnyaghanyadForm(this);
                

                aform.ShowDialog();
                
                
            }
            else
            {
                MessageBox.Show("Kérem, töltse ki a Megnevezés mezőt!");
                DialogResult = DialogResult.None;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filename = "gyartmanylap_minta.pdf";
            System.Diagnostics.Process.Start(filename);
        }
        
    }
}

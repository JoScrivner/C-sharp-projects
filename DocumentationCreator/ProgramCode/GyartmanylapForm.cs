using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

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

using iTextSharp.text.pdf.draw;
using Font = iTextSharp.text.Font;

namespace GyartmanylapKeszito
{
    public partial class GyartmanylapForm : Form
    {
        List<Gyartmanylap> listagy = new List<Gyartmanylap>();
        List<Hozzavalo> anyaghanyadlista = new List<Hozzavalo>();


        public GyartmanylapForm()
        {
            InitializeComponent();
        }

        private void GyartmanylapForm_Load(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.GetEncoding(1250);
            if (File.Exists("files/gyartmanylapok.csv"))
            {
                string[] fajl = File.ReadAllLines("files/gyartmanylapok.csv", encoding);
                foreach (var item in fajl)
                {
                    string[] db = item.Split(';');
                    
                    Gyartmanylap al = null;
                    al = new Gyartmanylap(item);
                    lbGyartmanylapok.Items.Add(al);
                    listagy.Add(al);
                }
            }
        }

        private void btnUjgy_Click(object sender, EventArgs e)
        {
            UjGyartmanylapForm f5 = new UjGyartmanylapForm();
            if (f5.ShowDialog() == DialogResult.OK)
            {
                lbGyartmanylapok.Items.Add(f5.G);
            }
        }

        private void GyartmanylapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter w = new StreamWriter("files/gyartmanylapok.csv", false, Encoding.UTF8))
            {
                foreach (Gyartmanylap item in lbGyartmanylapok.Items)
                {
                    w.WriteLine(item.ToCSV());
                }
            }
        }

        private void btnModositgy_Click(object sender, EventArgs e)
        {
            int ind = lbGyartmanylapok.SelectedIndex;
            if (ind > -1)
            {
                UjGyartmanylapForm f6 = new UjGyartmanylapForm();
                f6.G = (Gyartmanylap)lbGyartmanylapok.SelectedItem;
                if (f6.ShowDialog() == DialogResult.OK)
                {
                    lbGyartmanylapok.Items.RemoveAt(ind);
                    lbGyartmanylapok.Items.Insert(ind, f6.G);
                }
            }
            else
            {
                MessageBox.Show("Kérem, jelölje ki a szerkeszteni kívánt gyártmánylapot!");
            }
        }

        private void btnTorlesgy_Click(object sender, EventArgs e)
        {
            if (lbGyartmanylapok.SelectedIndex > -1)
            {
                if (MessageBox.Show("Biztosan törli a kijelölt gyártmánylapot?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lbGyartmanylapok.Items.RemoveAt(lbGyartmanylapok.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Kérem, jelölje ki a törölni kívánt gyártmánylapot!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbGyartmanylapok.SelectedIndex > -1)
            {
                bool bRet = false;

                string filenev2 = lbGyartmanylapok.SelectedItem.ToString() + ".csv";
                Encoding encoding = Encoding.GetEncoding(1250);
                anyaghanyadlista.Clear();
                if (File.Exists($"files/{filenev2}"))
                {
                    string[] fajl2 = File.ReadAllLines($"files/{filenev2}", encoding);
                    foreach (var sor in fajl2)
                    {
                        string[] db = sor.Split(';');
                        Hozzavalo al = null;
                        al = new Hozzavalo(sor);
                        anyaghanyadlista.Add(al);
                    }
                }

                
                BaseFont timesbold = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED);
                BaseFont timesnormal = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                BaseFont timesboldit = BaseFont.CreateFont(BaseFont.TIMES_BOLDITALIC, BaseFont.CP1250, BaseFont.EMBEDDED);
                Font titlefont = new Font(timesbold, 24);
                Font titletextfont = new Font(timesbold, 14);
                Font textfont = new Font(timesnormal, 11);
                Font subtitlefont = new Font(timesbold, 11);
                Font italicfont = new Font(timesboldit, 11);
                

                Gyartmanylap pdfbe = lbGyartmanylapok.SelectedItem as Gyartmanylap;
                Document pdfDoc = new Document();
                string filenev = pdfbe.GyMegnevezes + ".pdf";
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filenev, FileMode.OpenOrCreate));
                pdfDoc.Open();


                Paragraph paragraph = new Paragraph("Gyártmánylap", titlefont);
                
            
                paragraph.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(paragraph);
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"Érvényesség kezdete:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{pdfbe.ErvKezdete.ToString("yyyy. MM. dd.")}", textfont));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"Érvényesség vége:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{pdfbe.ErvVege.ToString("yyyy. MM. dd.")}", textfont));
                pdfDoc.Add(new Paragraph("\n"));

                pdfDoc.Add(new Paragraph("I.  Az élelmiszer előállítója", titletextfont));
                pdfDoc.Add(new Paragraph($"1. A vállalkozó neve, székhelyének címe:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{pdfbe.Cim1.Replace("nlw", Environment.NewLine)}", textfont));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"2. Az előállító hely(ek) neve, címe:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{pdfbe.Cim2.Replace("nlw", Environment.NewLine)}", textfont));

                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph("II. Az élelmiszer leírása", titletextfont));
                pdfDoc.Add(new Paragraph($"1. Megnevezés:", subtitlefont));
                pdfDoc.Add(new Chunk ($"{pdfbe.GyMegnevezes}", textfont));
                pdfDoc.Add(new Paragraph("\n"));

                pdfDoc.Add(new Paragraph("2. A termék egységnyi mennyiségéhez felhasznált összetevők felsorolása előállításkorabeli tömegük csökkenő sorrendjében:\n (Mennyiségek kg - ban)", subtitlefont));
                
                pdfDoc.Add(new Paragraph("\n"));
                PdfPTable table = new PdfPTable(2);
                
                table.AddCell(new PdfPCell(new Phrase("Alapanyag neve", titletextfont)));
                table.AddCell(new PdfPCell(new Phrase("Mennyiség (kg-ban)", titletextfont)));

                double total = anyaghanyadlista.Sum(item1 => item1.Mennyiseg);
                

                foreach (Hozzavalo item in anyaghanyadlista)
                {
                    if(item.Mennyiseg<(total*0.02))
                    {
                        table.AddCell($"{item.Megnevezes}*");
                        table.AddCell($"{item.Mennyiseg}");
                    }
                    else
                    {
                        table.AddCell($"{item.Megnevezes}");
                        table.AddCell($"{item.Mennyiseg}");
                    }
                    
                }
                pdfDoc.Add(table);
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"* 2% alattiak", subtitlefont));

                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"3. Felhasznált adalékanyagok:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{ pdfbe.Adalek}", textfont));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"4. A géntechnológiával módosított szervezet vagy az abból előállított termék összetevőként történő használata esetén" +
                    $"a géntechnológiával módosított szervezet neve és az azt tartalmazó összetevő neve:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{pdfbe.Leiras3.Replace("nlw", Environment.NewLine)}", textfont));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"5. Az élelmiszer eltarthatóságát, biztonságát meghatározó műveletek és paraméterek:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{ pdfbe.Leiras4.Replace("nlw", Environment.NewLine)}", textfont));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"6. A termék csomagolása, engedélyezett csomagológázok használata:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{ pdfbe.Leiras5.Replace("nlw", Environment.NewLine)}", textfont));
                pdfDoc.Add(new Paragraph("\n"));

                pdfDoc.Add(new Paragraph("III. Élelmiszerbiztonsági jellemzők", titletextfont));
                pdfDoc.Add(new Paragraph($"1.  A termék élelmiszerbiztonság jellemzői:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{ pdfbe.Biztonsag1.Replace("nlw", Environment.NewLine)}", textfont));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"2. A jogszabályban vagy a Magyar Élelmiszerkönyv irányelvében meghatározott minőségben előállított élelmiszer esetén" +
                    $"a termékre vonatkozó, alkalmazott előírások megjelölése:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{ pdfbe.Biztonsag2.Replace("nlw", Environment.NewLine)}", textfont));
                pdfDoc.Add(new Paragraph("\n"));

                pdfDoc.Add(new Paragraph("IV. Minőségi jellemzők", titletextfont));
                pdfDoc.Add(new Paragraph($"1.Az élelmiszer fizikai, kémiai, mikrobiológiai jellemzői", subtitlefont));
                pdfDoc.Add(new Paragraph("(Szárazanyag - tartalomra számítva)", italicfont));
                pdfDoc.Add(new Paragraph(
                    $"Fehérjetartalom: {pdfbe.Feherjesz.ToString("#.##")} %\n" +
                    $"Zsírtartalom: {pdfbe.Zsirsz.ToString("#.##")} %\n" +
                    $"Konyhasótartalom: {pdfbe.Sosz.ToString("#.##")} %\n" +
                    $"Cukortartalom: {pdfbe.Cukorsz.ToString("#.##")} %\n", textfont));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"2. Allergén anyagok:", subtitlefont));

                /*foreach (var elem in anyaghanyadlista)
                {
                    
                }*/

                if (pdfbe.Gluten == true)
                {
                    pdfDoc.Add(new Paragraph("Glutén", textfont));
                }
                if (pdfbe.Rakfelek == true)
                {
                    pdfDoc.Add(new Paragraph("Rákfélék", textfont));
                }
                if (pdfbe.Tojas == true)
                {
                    pdfDoc.Add(new Paragraph("Tojás", textfont));
                }
                if (pdfbe.Halak == true)
                {
                    pdfDoc.Add(new Paragraph("Halak", textfont));
                }
                if (pdfbe.Foldimogyoro == true)
                {
                    pdfDoc.Add(new Paragraph("Földimogyoró", textfont));
                }
                if (pdfbe.Szoja == true)
                {
                    pdfDoc.Add(new Paragraph("Szója", textfont));
                }
                if (pdfbe.Tej == true)
                {
                    pdfDoc.Add(new Paragraph("Tej", textfont));
                }
                if (pdfbe.Diofelek == true)
                {
                    pdfDoc.Add(new Paragraph("Diófélék", textfont));
                }
                if (pdfbe.Zeller == true)
                {
                    pdfDoc.Add(new Paragraph("Zeller", textfont));
                }
                if (pdfbe.Mustar == true)
                {
                    pdfDoc.Add(new Paragraph("Mustár", textfont));
                }
                if (pdfbe.Szezammag == true)
                {
                    pdfDoc.Add(new Paragraph("Szezámmag", textfont));
                }
                if (pdfbe.Kendioxid == true)
                {
                    pdfDoc.Add(new Paragraph("Kén-dioxid", textfont));
                }
                if (pdfbe.Csillagfurt == true)
                {
                    pdfDoc.Add(new Paragraph("Csillagfürt", textfont));
                }
                if (pdfbe.Puhatestuek == true)
                {
                    pdfDoc.Add(new Paragraph("Puhatestűek", textfont));
                }

                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"3. Az érzékszervi jellemzők", subtitlefont));
                pdfDoc.Add(new Paragraph("(Kitérve az érzékszervi jellemzők bírálata során figyelembe veendő, a forgalomba hozatalt még nem kizáró, de a kifogástalan tulajdonságtól eltérő érzékszervi jellemzőkre)", italicfont));
                pdfDoc.Add(new Paragraph(
                    $"Megjelenés: {pdfbe.Megjelenes} \n" +
                    $"Szín: {pdfbe.Szin} \n" +
                    $"Íz: {pdfbe.Iz} \n" +
                    $"Illat: {pdfbe.Illat} \n" +
                    $"Állomány: {pdfbe.Allomany} \n", textfont));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"4. Az önkéntes megkülönböztető megjelölés használata esetén a megkülönböztetésre alapot adó jellemzők és az állítás" +
                    $"igazolásának módja:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{pdfbe.Minosegi4.Replace("nlw", Environment.NewLine)}", textfont));
                pdfDoc.Add(new Paragraph("\n"));

                pdfDoc.Add(new Paragraph($"V. Minőségmegőrzési/fogyaszthatósági időtartama:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{pdfbe.Fogyido}", textfont));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"VI. Tárolási feltételek:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{pdfbe.Tarolas}", textfont));
                pdfDoc.Add(new Paragraph("\n"));

                pdfDoc.Add(new Paragraph($"A gyártmánylap elkészítésének és módosításának dátuma:", subtitlefont));
                pdfDoc.Add(new Paragraph($"{pdfbe.ModositasDatuma.ToString("yyyy. MM. dd.")}", textfont));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph($"A gyártmánylap elkészítéséért felelős, valamint az élelmiszer-vállalkozásban az élelmiszer előállításáért szakmailag" +
                    $"felelős személy neve és aláírása:", subtitlefont));
                pdfDoc.Add(new Paragraph($"\n \n {pdfbe.FelelosSzemely}", textfont));

                bRet = true;

                pdfDoc.Close();

                if (bRet == true)
                {
                    MessageBox.Show(filenev + " sikeresen létrejött!");
                }

                System.Diagnostics.Process.Start(filenev);

            }
            else
            {
                MessageBox.Show("Nincs kijelölt gyártmánylap!");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUjgy_MouseHover(object sender, EventArgs e)
        {
            panel1.Height = btnUjgy.Height;
            panel1.Top = btnUjgy.Top;
        }

        private void btnModositgy_MouseHover(object sender, EventArgs e)
        {
            panel1.Height = btnModositgy.Height;
            panel1.Top = btnModositgy.Top;
        }

        private void btnTorlesgy_MouseHover(object sender, EventArgs e)
        {
            panel1.Height = btnTorlesgy.Height;
            panel1.Top = btnTorlesgy.Top;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            panel1.Height = button1.Height;
            panel1.Top = button1.Top;
            
        }
    }
}

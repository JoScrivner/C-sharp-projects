using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Iskolak
{
    class Gimnazium : Iskola
    {
        public bool VanKozponti { get; set; }
        public bool VanSport { get; set; }

        private int termekszama;

        public int Termekszama
        {
            get { return termekszama; }
            set { if (value >= 8) { termekszama = value; } }
        }

        

        public Gimnazium(string mn, int atsz, int mtsz, string c, string ignev, bool kp, bool sport, int tsz) : base(mn, atsz, mtsz, c, ignev)
        {
            VanKozponti = kp;
            VanSport = sport;
            Termekszama = tsz;
        }

        public override int FenntartasiKoltseg()
        {
            return Maxtanuloszam / Aktivtanuloszam * Termekszama * 150000;
        }

        
        public override string ToString()
        {
            return base.ToString() + $", {(VanKozponti ? "van kozponti felveteli" : "nincs kozponti felveteli")}, {(VanSport ? "van sportolasi lehetoseg" : "nincs sportolasi lehetoseg")}, termek szama: {Termekszama}";
        }
        



        public override XElement ToXML()
        {
            XElement node = base.ToXML();
            node.Add(new XElement("Kozponti felveteli", VanKozponti));
            node.Add(new XElement("Sportolasi lehetoseg", VanSport));
            node.Add(new XElement("Termek szama", Termekszama));

            return node;
        }
    }
}

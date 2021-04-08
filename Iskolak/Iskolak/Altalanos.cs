using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Iskolak
{
    class Altalanos : Iskola
    {
        private int osztalyokszama;

        public int Osztalyokszama
        {
            get { return osztalyokszama; }
            set { if (value >= 8) { osztalyokszama = value; } }
        }

        public bool VanTagozat { get; set; }
        public bool VanSzakkor { get; set; }

        public Altalanos(string mn, int atsz, int mtsz, string c, string ignev, int osz, bool tag, bool szakk) : base(mn, atsz, mtsz, c, ignev)
        {
            Osztalyokszama = osz;
            VanTagozat = tag;
            VanSzakkor = szakk;
        }

        public override int FenntartasiKoltseg()
        {
            return Maxtanuloszam / Aktivtanuloszam * Osztalyokszama * 100000;
        }

        
        public override string ToString()
        {
            return base.ToString() + $", osztalzok szama: {Osztalyokszama}, {(VanTagozat ? "vannak tagozatok" : "nincsenek tagozatok")}, {(VanSzakkor ? "vannak szakkorok" : "nincsenek szakkorok")}";
        }
        



        public override XElement ToXML()
        {
            XElement node = base.ToXML();
            node.Add(new XElement("Osztalyok szama", Osztalyokszama));
            node.Add(new XElement("Tagozat", VanTagozat));
            node.Add(new XElement("Szakkor", VanSzakkor));

            return node;
        }
    }
}

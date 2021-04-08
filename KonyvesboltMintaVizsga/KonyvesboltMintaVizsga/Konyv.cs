using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KonyvesboltMintaVizsga
{
    enum KonyvTipus
    {
        tudományos,
        irodalmi
    }
    enum TudomanyTeruletTipus
    {
        fizika, kémia, biológia, egyéb
    }
    enum KategoriaTipus
    {
        vers, novella, elbeszélés, egyéb
    }
    abstract class Konyv : IComparable<Konyv>   // generikus interfész megvalósítása
    {
        internal int DBID { get; set; }  // a könyv ID-ja az adatbázisban

        private string cim;

        public string Cim
        {
            get { return cim; }
            set { if (value != "") { cim = value; } }
        }

        private string szerzo;

        public string Szerzo
        {
            get { return szerzo; }
            set { if (value != "") { szerzo = value; } }
        }

        private int oldalszam;

        public int Oldalszam
        {
            get { return oldalszam; }
            set { if (value >= 10 && value <= 10000) { oldalszam = value; } }
        }

        private int ar;

        public int Ar
        {
            get { return ar; }
            set { if (value >= 100 && value <= 100000) { ar = value; } }
        }

        private int kiadaseve;

        public int KiadasEve
        {
            get { return kiadaseve; }
            set { if (value <= DateTime.Now.Year) kiadaseve = value; }
        }

        public Konyv(string ci, string sz, int os, int ar, int ke)
        {
            Cim = ci;
            Szerzo = sz;
            Oldalszam = os;
            Ar = ar;
            KiadasEve = ke;
        }

        public override string ToString()
        {
            return $"{Szerzo}: {Cim}, {Oldalszam} oldal, {Ar} Ft, megjelent: {KiadasEve}";
        }

        public int CompareTo(Konyv other)
        {
            return Ar.CompareTo(other.Ar);
        }

        public int Evszazad => KiadasEve / 100 + 1;   // read-only property

        public virtual XElement ToXML()
        {
            XElement node = new XElement("Könyv"); // új node létrehozása
            node.Add(new XElement("Cím", Cim));  // alternatíva: node.Add(new XAttribute("Cím", Cim));
            node.Add(new XElement("Szerző", Szerzo));
            node.Add(new XElement("Oldalszám", Oldalszam));
            node.Add(new XElement("Ár", Ar));
            node.Add(new XElement("KiadásÉve", KiadasEve));
            return node;
        }
    }
}

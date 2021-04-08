using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Iskolak
{
    enum IskolaTipus
    {
        altalanos,
        gimnazium
    }

    abstract class Iskola : IComparable<Iskola> 
    {
        internal int IID { get; set; }  

        private string megnevezes;

        public string Megnevezes
        {
            get { return megnevezes; }
            set { if (value != "") { megnevezes = value; } }
        }

        private int aktivtanuloszam;

        public int Aktivtanuloszam
        {
            get { return aktivtanuloszam; }
            set { if (value >= 25) { aktivtanuloszam = value; } }
        }

        private int maxtanuloszam;

        public int Maxtanuloszam
        {
            get { return maxtanuloszam; }
            set { if (value >= 25 && value <= 2000) { maxtanuloszam = value; } }
        }

        private string cim;

        public string Cim
        {
            get { return cim; }
            set { if (value != "") { cim = value; } }
        }

        private string igazgato;

        public string Igazgato
        {
            get { return igazgato; }
            set { if (value != "") { igazgato = value; } }
        }

        
        

        public Iskola(string mn, int atsz, int mtsz, string c, string ignev)
        {
            Megnevezes = mn;
            Aktivtanuloszam = atsz;
            Maxtanuloszam = mtsz;
            Cim = c;
            Igazgato = ignev;
        }

        
        public override string ToString()
        {
            return $"{Megnevezes}, {Cim}, igazgato neve: {Igazgato}, {Aktivtanuloszam} aktiv tanulo, maximum {Maxtanuloszam} tanulo";
        }
        

        public int CompareTo(Iskola other)
        {
            return Aktivtanuloszam.CompareTo(other.Aktivtanuloszam);
        }

        public abstract int FenntartasiKoltseg();

        public virtual XElement ToXML()
        {
            XElement node = new XElement("Iskola"); 
            node.Add(new XElement("Megnevezes", Megnevezes));
            node.Add(new XElement("Aktiv tanuloszam", Aktivtanuloszam));
            node.Add(new XElement("Maximalis tanuloszam", Maxtanuloszam));
            node.Add(new XElement("Cím", Cim)); 
            node.Add(new XElement("Igazgato neve", Igazgato));
            return node;
        }
    }



}

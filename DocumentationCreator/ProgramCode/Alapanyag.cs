using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyartmanylapKeszito
{
    public class Alapanyag
    {
        private string megnevezes;

        public string Megnevezes
        {
            get { return megnevezes; }
            private set { if (value != "") { megnevezes = value; } }
        }

        private double feherje;
        public double Feherje
        {
            get { return feherje; }
            set { if (value >= 0) { feherje = value; } }
        }

        private double zsir;
        public double Zsir
        {
            get { return zsir; }
            set { if (value >= 0) { zsir = value; } }
        }

        private double so;
        public double So
        {
            get { return so; }
            set { if (value >= 0) { so = value; } }
        }

        private double cukor;
        public double Cukor
        {
            get { return cukor; }
            set { if (value >= 0) { cukor = value; } }
        }

        public bool Gluten { get; set; }
        public bool Rakfelek { get; set; }
        public bool Tojas { get; set; }
        public bool Halak { get; set; }
        public bool Foldimogyoro { get; set; }
        public bool Szoja { get; set; }
        public bool Tej { get; set; }
        public bool Diofelek { get; set; }
        public bool Zeller { get; set; }
        public bool Mustar { get; set; }
        public bool Szezammag { get; set; }
        public bool Kendioxid { get; set; }
        public bool Csillagfurt { get; set; }
        public bool Puhatestuek { get; set; }

        public Alapanyag(string megn, double ft, double zst, double st, double ct, bool gl, bool rak, bool toj, bool hal, bool foldm, bool szoj, bool te, bool diof, bool zel, bool must, bool szezm, bool kend, bool csill, bool puhat)
        {
            Megnevezes = megn;
            Feherje = ft;
            Zsir = zst;
            So = st;
            Cukor = ct;
            Gluten = gl;
            Rakfelek = rak;
            Tojas = toj;
            Halak = hal;
            Foldimogyoro = foldm;
            Szoja = szoj;
            Tej = te;
            Diofelek = diof;
            Zeller = zel;
            Mustar = must;
            Szezammag = szezm;
            Kendioxid = kend;
            Csillagfurt = csill;
            Puhatestuek = puhat;
        }

        public Alapanyag(string CSV)
        {
            string[] cella = CSV.Split(';');
            Megnevezes = cella[0];
            Feherje = double.Parse(cella[1]);
            Zsir = double.Parse(cella[2]);
            So = double.Parse(cella[3]);
            Cukor = double.Parse(cella[4]);
            Gluten = bool.Parse(cella[5]);
            Rakfelek = bool.Parse(cella[6]);
            Tojas = bool.Parse(cella[7]);
            Halak = bool.Parse(cella[8]);
            Foldimogyoro = bool.Parse(cella[9]);
            Szoja = bool.Parse(cella[10]);
            Tej = bool.Parse(cella[11]);
            Diofelek = bool.Parse(cella[12]);
            Zeller = bool.Parse(cella[13]);
            Mustar = bool.Parse(cella[14]);
            Szezammag = bool.Parse(cella[15]);
            Kendioxid = bool.Parse(cella[16]);
            Csillagfurt = bool.Parse(cella[17]);
            Puhatestuek = bool.Parse(cella[18]);
            
        }

        public string ToCSV()
        {
            return $"{Megnevezes};{Feherje};{Zsir};{So};{Cukor};{Gluten};{Rakfelek};{Tojas};{Halak};{Foldimogyoro};{Szoja};{Tej};{Diofelek};{Zeller};{Mustar};{Szezammag};{Kendioxid};{Csillagfurt};{Puhatestuek}";
        }

        public override string ToString()
        {
            return $"{Megnevezes}";
        }
    }
}

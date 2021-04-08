using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyartmanylapKeszito
{
    public class Gyartmanylap
    {
        private string gymegnevezes;

        public string GyMegnevezes
        {
            get { return gymegnevezes; }
            private set { if (value != "") { gymegnevezes = value; } }
        }

        public string Cim1 { get; set; }
        public string Cim2 { get; set; }
        public string Leiras3 { get; set; }
        public string Leiras4 { get; set; }
        public string Leiras5 { get; set; }
        public string Biztonsag1 { get; set; }
        public string Biztonsag2 { get; set; }


        private double feherjesz;
        public double Feherjesz
        {
            get { return feherjesz; }
            set { if (value >= 0) { feherjesz = value; } }
        }

        private double zsirsz;
        public double Zsirsz
        {
            get { return zsirsz; }
            set { if (value >= 0) { zsirsz = value; } }
        }

        private double sosz;
        public double Sosz
        {
            get { return sosz; }
            set { if (value >= 0) { sosz = value; } }
        }

        private double cukorsz;
        public double Cukorsz
        {
            get { return cukorsz; }
            set { if (value >= 0) { cukorsz = value; } }
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


        public string Megjelenes { get; set; }
        public string Szin { get; set; }
        public string Iz { get; set; }
        public string Illat { get; set; }
        public string Allomany { get; set; }
        public string Minosegi4 { get; set; }
        public string Fogyido { get; set; }
        public string Tarolas { get; set; }
        public DateTime ErvKezdete { get; set; }
        public DateTime ErvVege { get; set; }
        public DateTime ModositasDatuma { get; set; }
        public string FelelosSzemely { get; set; }
        public string Adalek { get; set; }


        public Gyartmanylap(string megn, string c1, string c2, string le3, string le4, string le5, string bizt1, string bizt2, bool gl, bool rak, bool toj, 
            bool hal, bool foldm, bool szoj, bool te, bool diof, bool zel, bool must, bool szezm, bool kend, bool csill, bool puhat, string megj, string szin,
            string iz, string illat, string all, string min4, string fogyi, string tarol, DateTime ekezd, DateTime evege, DateTime moddatum, string felelos,
            double fsz, double zssz, double ssz, double csz, string ad)
        {
            GyMegnevezes = megn;
            Cim1 = c1;
            Cim2 = c2;
            Leiras3 = le3;
            Leiras4 = le4;
            Leiras5 = le5;
            Biztonsag1 = bizt1;
            Biztonsag2 = bizt2;
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
            Megjelenes = megj;
            Szin = szin;
            Iz = iz;
            Illat = illat;
            Allomany = all;
            Minosegi4 = min4;
            Fogyido = fogyi;
            Tarolas = tarol;
            ErvKezdete = ekezd;
            ErvVege = evege;
            ModositasDatuma = moddatum;
            FelelosSzemely = felelos;
            Feherjesz = fsz;
            Zsirsz = zssz;
            Sosz = ssz;
            Cukorsz = csz;
            Adalek = ad;
            
        }

        public Gyartmanylap(string CSV)
        {
            string[] cella = CSV.Split(';');
            GyMegnevezes = cella[0];
            Cim1 = cella[1];
            Cim2 = cella[2];
            Leiras3 = cella[3];
            Leiras4 = cella[4];
            Leiras5 = cella[5];
            Biztonsag1 = cella[6];
            Biztonsag2 = cella[7];
            Gluten = bool.Parse(cella[8]);
            Rakfelek = bool.Parse(cella[9]);
            Tojas = bool.Parse(cella[10]);
            Halak = bool.Parse(cella[11]);
            Foldimogyoro = bool.Parse(cella[12]);
            Szoja = bool.Parse(cella[13]);
            Tej = bool.Parse(cella[14]);
            Diofelek = bool.Parse(cella[15]);
            Zeller = bool.Parse(cella[16]);
            Mustar = bool.Parse(cella[17]);
            Szezammag = bool.Parse(cella[18]);
            Kendioxid = bool.Parse(cella[19]);
            Csillagfurt = bool.Parse(cella[20]);
            Puhatestuek = bool.Parse(cella[21]);
            Megjelenes = cella[22];
            Szin = cella[23];
            Iz = cella[24];
            Illat = cella[25];
            Allomany = cella[26];
            Minosegi4 = cella[27];
            Fogyido = cella[28];
            Tarolas = cella[29];
            ErvKezdete = DateTime.Parse(cella[30]);
            ErvVege = DateTime.Parse(cella[31]);
            ModositasDatuma = DateTime.Parse(cella[32]);
            FelelosSzemely = cella[33];
            Feherjesz = double.Parse(cella[34]);
            Zsirsz = double.Parse(cella[35]);
            Sosz = double.Parse(cella[36]);
            Cukorsz = double.Parse(cella[37]);
            Adalek = cella[38];

        }

        public string ToCSV()
        {
            return $"{GyMegnevezes};{Cim1};{Cim2};{Leiras3};{Leiras4};{Leiras5};{Biztonsag1};{Biztonsag2};{Gluten};{Rakfelek};{Tojas};{Halak};{Foldimogyoro};" +
                $"{Szoja};{Tej};{Diofelek};{Zeller};{Mustar};{Szezammag};{Kendioxid};{Csillagfurt};{Puhatestuek};{Megjelenes};{Szin};{Iz};{Illat};{Allomany};{Minosegi4};" +
                $"{Fogyido};{Tarolas};{ErvKezdete};{ErvVege};{ModositasDatuma};{FelelosSzemely};{Feherjesz};{Zsirsz};{Sosz};{Cukorsz};{Adalek}";
        }

        public override string ToString()
        {
            return $"{GyMegnevezes}";
        }
    }
}

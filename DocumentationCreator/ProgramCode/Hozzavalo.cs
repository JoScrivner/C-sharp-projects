using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyartmanylapKeszito
{
    public class Hozzavalo : Alapanyag
    {
        public double Mennyiseg { get; set; }

        public Hozzavalo(string megn, double ft, double zst, double st, double ct, bool gl, bool rak, bool toj, bool hal, bool foldm, bool szoj, bool te, bool diof, bool zel, bool must, bool szezm, bool kend, bool csill, bool puhat, double menny)
            : base(megn, ft, zst, st, ct, gl, rak, toj, hal, foldm, szoj, te, diof, zel, must, szezm, kend, csill, puhat)
        {
            Mennyiseg = menny;
        }

        public Hozzavalo(string CSV) : base(CSV)
        {
            string[] cella = CSV.Split(';');
            Mennyiseg = double.Parse(cella[19]);


        }

        public double Feherjetart()
        {
            return Feherje / 100 * Mennyiseg;
        }

        public double Zsirtart()
        {
            return Zsir / 100 * Mennyiseg;
        }

        public double Sotart()
        {
            return So / 100 * Mennyiseg;
        }

        public double Cukortart()
        {
            return Cukor / 100 * Mennyiseg;
        }

        public override string ToString()
        {
            return $"{Megnevezes}, {Mennyiseg} kg";
        }

        public new string ToCSV()
        {
            return $"{Megnevezes};{Feherje};{Zsir};{So};{Cukor};{Gluten};{Rakfelek};{Tojas};{Halak};{Foldimogyoro};{Szoja};{Tej};{Diofelek};{Zeller};{Mustar};{Szezammag};{Kendioxid};{Csillagfurt};{Puhatestuek};{Mennyiseg}";
        }
    }
}


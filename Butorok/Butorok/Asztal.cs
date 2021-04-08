using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorok
{
    class Asztal : Butor
    {
        
        public bool Kinyithato { get; private set; }

        private int ferohely;

        public int Ferohely
        {
            get { return ferohely; }
            private set { if (value >= 2) { ferohely = value; }; }

        }

        public bool Csuszasgatlos { get; private set; }

        public Asztal(string mn, int mx, int my, int mz, AnyagTipus a, ElhelyezesTipus elh, int darab, bool kiny, int fo, bool csg) : base(mn, mx, my, mz, a, elh, darab)
        {
            Kinyithato = kiny;
            Ferohely = fo;
            Csuszasgatlos = csg;
        }

        public override int Ar()
        {
            return Meret.x * Meret.y * Meret.z * 100;
        }


        public Asztal(string CSV) : base(CSV)
        {
            string[] db = CSV.Split(';');
            Kinyithato = bool.Parse(db[8]);
            Ferohely = int.Parse(db[9]);
            Csuszasgatlos = bool.Parse(db[10]);
        }

        public override string ToCSV()
        {
            return $"{(int)ButorTipus.asztal};{Megnevezes};{Meret.x};{Meret.y};{Meret.z};{(int)Anyag};{(int)Elhelyezes};{DB};{Kinyithato};{Ferohely};{Csuszasgatlos}";
        }

        public override string ToString()
        {
            return base.ToString() + $", {Ar()} Ft, {Ferohely} fő, {(Kinyithato ? "" : "nem ") + "kinyitható"}, {(Csuszasgatlos ? "" : "nem ") + "csúszásgátlós"}";
        }
    }
}

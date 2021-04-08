using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorok
{
    struct MeretTipus
    {
        public int x, y, z;
    }

    enum AnyagTipus
    {
        fa, fem, egyeb
    }

    enum ElhelyezesTipus
    {
        furdo, konyha, nappali
    }

    enum ButorTipus
    {
        asztal, szekreny
    }

    abstract class Butor
    {
        private string megnevezes;

        public string Megnevezes
        {
            get { return megnevezes; }
            private set { if (value != "") { megnevezes = value; } } //nem modosithato, nem lehet ures!
        }

        private MeretTipus meret;

        public MeretTipus Meret
        {
            get { return meret; }
            private set { if (value.x >= 10 && value.y >= 10 && value.z >= 10) { meret = value; } }
        }


        public AnyagTipus Anyag { get; private set; }
        public ElhelyezesTipus Elhelyezes { get; private set; }


        private int db;
        public int DB
        {
            get { return db; }
            set { if (value >= 0) { db = value; } }
        }

        //public ButorTipus Tipus { get; private set; }


        public Butor(string mn, int mx, int my, int mz, AnyagTipus a, ElhelyezesTipus elh, int darab)
        {
            Megnevezes = mn;
            Meret = new MeretTipus() { x = mx, y = my, z = mz };
            Anyag = a;
            Elhelyezes = elh;
            DB = darab;

        }

        public Butor(string CSV)
        {
            string[] db = CSV.Split(';');
            Megnevezes = db[1];
            //Meret.x = int.Parse(db[2]);
            Meret = new MeretTipus() { x = int.Parse(db[2]), y = int.Parse(db[3]), z = int.Parse(db[4]) };
            Anyag = (AnyagTipus)int.Parse(db[5]);
            Elhelyezes = (ElhelyezesTipus)int.Parse(db[6]);
            DB = int.Parse(db[7]);
        }

        public abstract int Ar();

        public abstract string ToCSV();

        public override string ToString()
        {
            return $"{Megnevezes}, {Meret.x} cm * {Meret.y} cm * {Meret.z} cm, {Anyag}, {Elhelyezes}, {DB} db";
        }
    }
}


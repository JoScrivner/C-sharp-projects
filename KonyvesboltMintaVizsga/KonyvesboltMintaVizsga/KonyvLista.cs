using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvesboltMintaVizsga
{
    class KonyvLista : List<Konyv>  // származtatás a beépített lista osztályból
    {
        public delegate void EsemenyKezelo(Konyv k);
        // public delegate void EsemenyKezelo2();  // paraméter nélküli delegált

        public event EsemenyKezelo UjElem, ElemTorolve; // két új esemény
        // public event EsemenyKezelo2 ElemTorolve;  // ha a másik esemény paraméter nélküli

        public new void Add(Konyv k)  // az ősosztály metódusának felüldefiniálása
        {
            base.Add(k);  // az ősosztály metódusának meghívása
            UjElem?.Invoke(k);
        }

        public new bool Remove(Konyv k)
        {
            bool ok = base.Remove(k);
            if (ok)  // csak akkor, ha sikerült az eltávolítás
            {
                ElemTorolve?.Invoke(k);
            }
            return ok;
        }

        public new void RemoveAt(int index)
        {
            ElemTorolve?.Invoke(this[index]);
            base.RemoveAt(index);
        }
    }
}

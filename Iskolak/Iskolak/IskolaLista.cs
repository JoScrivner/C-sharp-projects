using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskolak
{
    class IskolaLista : List<Iskola>
    {
        public delegate void EsemenyKezelo(Iskola i);
        // public delegate void EsemenyKezelo2();  // paraméter nélküli delegált

        public event EsemenyKezelo UjElem, ElemTorolve; // két új esemény
        // public event EsemenyKezelo2 ElemTorolve;  // ha a másik esemény paraméter nélküli

        public new void Add(Iskola i)  // az ősosztály metódusának felüldefiniálása
        {
            base.Add(i);  // az ősosztály metódusának meghívása
            UjElem?.Invoke(i);
        }

        public new bool Remove(Iskola i)
        {
            bool ok = base.Remove(i);
            if (ok)  // csak akkor, ha sikerült az eltávolítás
            {
                ElemTorolve?.Invoke(i);
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

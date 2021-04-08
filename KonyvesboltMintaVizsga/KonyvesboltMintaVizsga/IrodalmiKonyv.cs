using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KonyvesboltMintaVizsga
{
    class IrodalmiKonyv : Konyv
    {
        public KategoriaTipus Kategoria { get; set; }

        public IrodalmiKonyv(string ci, string sz, int os, int ar, int ke, KategoriaTipus ka) : base(ci, sz, os, ar, ke)
        {
            Kategoria = ka;
        }

        public override string ToString()
        {
            return base.ToString() + $", {Kategoria}";
        }

        public override XElement ToXML()
        {
            XElement node = base.ToXML();  // felhasználjuk az ős által létrehozott objektumot!
            node.Add(new XElement("Kategória", Kategoria));
            return node;
        }
    }
}

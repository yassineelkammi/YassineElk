using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_yassineElkammi
{
    class Disque:Culturel
    {
        private double _tva = 0.2;
        public double TVA { get { return _tva; } }


        public Disque() : base()
        {
            
        }
        public Disque(Disque d):base(d)
        {

        }
        public Disque(string desg, double ht,string genre) : base(desg, ht,genre)
        {
             
        }

        public override double prixTTC()
        {
            return PrixHT+(TVA*PrixHT);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("PrixTTC : {0:0.00} MAD", prixTTC());
        }

    }
}

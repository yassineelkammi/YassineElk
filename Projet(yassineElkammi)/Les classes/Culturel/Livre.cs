using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_yassineElkammi
{
    class Livre:Culturel
    {
        private double _tva = 0.055;

        public double TVA { get { return _tva; } }


        public Livre() : base()
        {
            
        }
        public Livre(Livre i):base(i)
        {

        }
        public Livre(string desg, double ht,string genre) : base(desg, ht ,genre)
        {
            
        }

        public override double prixTTC()
        {
            return PrixHT + (TVA * PrixHT);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("PrixTTC : {0:0.00} MAD", prixTTC());
        }


    }
}

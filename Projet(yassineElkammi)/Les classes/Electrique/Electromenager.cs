using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_yassineElkammi 
{
    class Electromenager : Electrique
    {
        public override int DureeGarantie { get { return 1; } }


        public Electromenager() : base()
        {

        }
        public Electromenager(string desig, double ht, int consommation, double h, double l, double poid, double prof) : base(desig, ht, consommation, h, l, poid, prof)
        {
            
        }
        public Electromenager(Electromenager e) : base(e)
        {

        }

        public override double fraisPort()
        {
            double maj=0.1;
            double livraisionSansMajoration;
            livraisionSansMajoration = ((Poid * 2) / 3) ;
            if (Volume > 0.1)
            {
                
                return livraisionSansMajoration + livraisionSansMajoration*maj;
            }
            else
            {
                return livraisionSansMajoration;
            }
            
        }

        public override double prixTTC()
        {
            return PrixHT + TVA * PrixHT + fraisPort();
        }

        public override string ToString()
        {
            return base.ToString()+ string.Format("PrixTTC : {0:0.00} MAD", prixTTC());
        }






    }
}

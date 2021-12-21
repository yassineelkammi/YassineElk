using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_yassineElkammi
{
    class VideoHiFi : Electrique
    {
        public override int DureeGarantie { get { return 2; } }

        public VideoHiFi() : base()
        {

        }
        public VideoHiFi(string desig, double ht, int consommation, double h, double l, double poid, double prof) : base(desig, ht, consommation, h, l, poid, prof)
        {
           
        }
        public VideoHiFi(VideoHiFi v) : base(v)
        {

        }

        public override double fraisPort()
        {
            return (Poid*2)/3;
        }

        public override double prixTTC()
        {
            return PrixHT+TVA*PrixHT+fraisPort();
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("PrixTTC : {0:0.00} MAD", prixTTC());
        }




    }
}

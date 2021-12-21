using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_yassineElkammi
{
    abstract class Electrique : Article
    {
        protected int _consom;
        protected double _h;
        protected double _l;
        protected double _p;
        protected double _poid;

        public int Consommation { get { return _consom; } set { _consom = value; } }
        public double Hauteur { get { return _h; } set { _h = value; } }
        public double Largeur { get { return _l; } set { _l = value; } }
        public double Poid { get { return _poid; } set { _poid = value; } }
        public double Profondeur { get { return _p; } set { _p = value; } }
        public double TVA { get { return 0.2; } }
        public abstract int DureeGarantie { get; }
        public double Volume { get { return (Hauteur * Largeur * Profondeur);  } }

        public Electrique() : base()
        {

        }
        public Electrique(string desig,double ht,int consommation,double h,double l,double poid ,double prof) : base(desig, ht)
        {
            Consommation = consommation;
            Hauteur = h;
            Largeur = l;
            Poid = poid;
            Profondeur = prof;
            
            

        }
        public Electrique(Electrique e) : base(e)
        {
            Consommation = e.Consommation;
            Hauteur = e.Hauteur;
            Largeur = e.Largeur;
            Poid = e.Poid;
            Profondeur = e.Profondeur;

        }

        public override double fraisPort()
        {
            
            return 0;
        }

        public override double prixTTC()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Consommation : {0} \n Durée de Garantie : {1} an \n Largeur x Hauteur x Profondeur = {2:0.00} x {3:0.00} x {4:0.00} (cm) \n  Volume : {5:0.00} \n ", Consommation, DureeGarantie, Largeur,Hauteur, Profondeur, Volume);
        }


    }
}

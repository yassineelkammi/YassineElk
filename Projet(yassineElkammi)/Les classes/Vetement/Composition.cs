using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_yassineElkammi
{
    public enum MatiereP
    {
        Cotton,
        Acrylic,
        Nylon
    }
    class Composition
    {
        private MatiereP _mat;
        private double _proportion;

        public MatiereP Matiere { get {return _mat; } set {_mat=value; } }
        public double Proportion { get { return _proportion; } set { _proportion = value; } }

        public Composition()
        {

        }
        public Composition(Composition c)
        {
            Matiere = c.Matiere;
            Proportion = c.Proportion;
        }
        public Composition(MatiereP m,double p)
        {
            Matiere = m;
            Proportion = p;
        }

        public override string ToString()
        {
            return string.Format( " Matière :{0}  \t Proportion : {1} %",Matiere,Proportion*100);
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Composition)) return false;
            Composition c = (Composition)obj;
            return this.Matiere == c.Matiere;
        }
        public override int GetHashCode()
        {
            return Matiere.ToString().GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_yassineElkammi
{

    class Vetement : Article
    {


        private static int _nc = 1;
        private List<Composition> _comp=new List<Composition>();



        public double TVA { get { return 0.196; } }
        public List<Composition> Compositions { get { return _comp; } set { _comp = value; } }

        

        public Vetement() : base()
        {
            _nc++;
        }
        public Vetement(Vetement v): base(v)
        {
            _nc++;
            Compositions = v.Compositions;
            
        }
        public Vetement(string desg, double ht,List<Composition> matiere) : base(desg, ht)
        {
            Compositions = matiere;
            _nc++;
        }


        public override double fraisPort()
        {
            return 1;
        }

        public override double prixTTC()
        {
            return PrixHT + (TVA * PrixHT)+fraisPort();
        }

        public void AjouterMatière(MatiereP mat,double p)
        {
            Composition c = new Composition(mat,p);
            double cpt = 0;
            
            foreach(Composition t in Compositions)
            {
                cpt += t.Proportion; 
            }
            if(!Compositions.Contains(c) && cpt+p <=1)
            {
                Compositions.Add(c);

            }   
        }
        public void RetirerMatiere(MatiereP mat)
        {
            for (int i = 0; i < Compositions.Count; i++)
            {
                if(Compositions[i].Matiere == mat)
                {
                    Compositions.RemoveAt(i);
                    break;
                }
            }
        }
        public override string ToString()
        {
            string compositionsToString = "";
            foreach (Composition item in Compositions)
            {
                compositionsToString += item.ToString() + "\n";
            }
            return base.ToString()+($"{compositionsToString} \n PrixTTC : {prixTTC()} MAD") ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_yassineElkammi
{
    abstract class Culturel : Article
    {
        protected string _genre;

        public string Genre { get { return _genre; } set { _genre = value; } }

        public Culturel():base()
        {
        
        }
        public Culturel(Culturel c):base(c)
        {
            Genre = c.Genre;
        }
        public Culturel(string desg, double ht,string genre):base(desg , ht)
        {
            Genre = genre;
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
            return base.ToString()+string.Format(" Genre : {0} \n",Genre);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace Projet_yassineElkammi
{
    abstract class Article
    {
        

        protected string _desig;
        protected double _ht;
        public static int _n=0;
        protected int _ref;
        protected Image _img;

        

        public string Designation { get { return _desig.ToUpper(); } set { _desig = value; } }
        public double PrixHT
        {
            get
            {
                return _ht;
            }
            set
            {
                if (value >= 0)
                {
                    _ht = value;
                }
                else
                {
                    throw new PrixException();
                }

            }
        }
        public int Reference { get { return _ref; } }
        public Image Images { get { return _img; } }
        
        public Article()
        {
            _n++;
            _ref = _n;
        }
        public Article(Article a):this()
        {
            Designation = a.Designation;
            PrixHT = a.PrixHT;
            
        }
        public Article(string desg,double ht):this()
        {
            Designation = desg;
            PrixHT = ht;
            
        }


        public abstract double fraisPort();
        public abstract double prixTTC();

        public override string ToString()
        {
            return string.Format("Désignation :{0} \n Référence : {1} \n PrixHT : {2:0.00} MAD \n ", Designation,Reference,PrixHT);
        }

        public void ChoisirImage (Image img)
        {
            _img = img;
        }
        public void ChoisirImage(string chemin)
        {
            Image photo = new Bitmap(chemin);
            _img = photo;
        }
    }
}

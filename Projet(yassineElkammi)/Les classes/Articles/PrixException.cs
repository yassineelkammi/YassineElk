using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_yassineElkammi
{
    class PrixException:Exception
    {
        public PrixException():base("Le prix hors taxe ne doit pas être négative !! ")
        {

        }
        public PrixException(string message) : base(message)
        {
            
        }
    }
}

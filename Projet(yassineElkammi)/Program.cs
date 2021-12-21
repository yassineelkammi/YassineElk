using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Projet_yassineElkammi
{
    static class Program
    {
        public static  List<Article> Articles = new List<Article>();
        public static List<Article> Panier = new List<Article>();
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gestiondesarticles());
        }
    }
}

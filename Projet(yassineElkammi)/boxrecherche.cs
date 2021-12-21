using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_yassineElkammi
{
    public partial class Box_recherche : Form
    {
        public static int indice=0;

        public Box_recherche()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (txtrecherche.Text != "" && int.TryParse(txtrecherche.Text,out int r))
            {
                indice = Rechercher(r);
            }
            
            this.Close();
            

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de Quitter?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private int Rechercher(int refer)
        {
            for (int i = 0; i < Program.Articles.Count; i++)
            {
                if (refer==Program.Articles[i].Reference)
                {
                    return i;
                }
            }
            return -1;

        }

        private void Box_recherche_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#7EC8E3");
        }
    }
}

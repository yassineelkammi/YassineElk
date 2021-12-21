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
    public partial class FormDetails : Form
    {
        Image img = null;

        
        
        public FormDetails()
        {
            InitializeComponent();
        }

        private void btn_ajouterpanier_Click(object sender, EventArgs e)
        {
            int indice;
            indice = Recherche(ListeArticles.reference);
            if (indice == -1) return;
            Article c = Program.Articles[indice];
            Program.Panier.Add(c);
            this.Close();

        }
        private int Recherche(int refer)
        {
            int i = 0;
            foreach (Article item in Program.Articles)
            {
                if (item.Reference == refer)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#7EC8E3");
            int indice;
            indice = Recherche(ListeArticles.reference);
            if (indice == -1) return;
            Article c = Program.Articles[indice];
            lbl_info.Text = c.ToString();
            if (c.Images != null)
            {

                picture.Image = new Bitmap( c.Images, new Size(100,100));
                img = c.Images;
            }
            

        }

        private void tb_zoom_Scroll(object sender, EventArgs e)
        {
            int percent = tb_zoom.Value;
            int width = (percent * picture.Width) / 100 +40;
            int height = (percent * picture.Width) / 100 +40;

            picture.Image = new Bitmap(img, new Size(width, height));
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Etes vous sûr de fermer ??", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        


    }
}

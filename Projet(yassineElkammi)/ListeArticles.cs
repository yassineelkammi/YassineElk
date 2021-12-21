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
    public partial class ListeArticles : Form
    {
        public static int reference = 0;
        

        ImageList imgL = new ImageList();
        ImageList imgS = new ImageList();

        public ListeArticles()
        {
            InitializeComponent();
        }

        private void rb_view_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_details.Checked)
            {
                lv1.View = View.Details;
            }
            else if (rb_grand.Checked)
            {
                lv1.View = View.LargeIcon;
            }
            else if (rb_petit.Checked)
            {
                lv1.View = View.SmallIcon;
            }
            else if (rb_liste.Checked)
            {
                lv1.View = View.List;
            }
            else
            {
                lv1.View = View.Tile;
            }
        }

        private void ListeArticles_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#7EC8E3");
            double totalprix=0;
            foreach (Article item in Program.Panier)
            {
                totalprix += item.prixTTC();

            }

            lbl_panier.Text = string.Format("Panier ({0}) : {1:0.00} MAD", Program.Panier.Count, totalprix);
            
            imgL.ColorDepth = ColorDepth.Depth32Bit;
            imgS.ColorDepth = ColorDepth.Depth32Bit;
            imgL.ImageSize = new Size(64, 64);
            imgS.ImageSize = new Size(24, 24);

            lv1.Columns.Add("Désignation", 200);
            lv1.Columns.Add("PrixTTC",150);
            lv1.Columns.Add("PrixHT",150);
            lv1.Columns.Add("Consommation");
            lv1.Columns.Add("Genre");
            lv1.Columns.Add("Réf.");
            lv1.View = View.Details;
            rb_details.Checked = true;
            lv1.GridLines = true;
            lv1.FullRowSelect = true;
            lv1.SmallImageList = imgS;
            lv1.LargeImageList = imgL;
            btn_vtm.PerformClick();
            lv1.Columns[3].Width = 0;
            lv1.Columns[4].Width = 0;
            

        }

        private void btn_type_Click(object sender, EventArgs e)
        {
            

            lv1.Items.Clear();
            imgL.Images.Clear();
            imgS.Images.Clear();
            int i = 0;
            ListViewGroup ElectromenagerGroup = new ListViewGroup("Electroménager", HorizontalAlignment.Left);
            ListViewGroup VideoHiFiGroup = new ListViewGroup("Vidéo / HiFi", HorizontalAlignment.Left);
            ListViewGroup LivreGroup = new ListViewGroup("Livres", HorizontalAlignment.Left);
            ListViewGroup DisqueGroup = new ListViewGroup("Disques", HorizontalAlignment.Left);
            foreach(Article article in Program.Articles)
            {
                ListViewItem lvi = new ListViewItem();

                if (((Button)sender).Equals(btn_vtm) && article is Vetement)
                {
                    
                    lv1.Groups.Clear();
                    lv1.GridLines = false;
                    lv1.Columns[3].Width = 0;
                    lv1.Columns[4].Width = 0;

                    lvi.Text = article.Designation;
                    lvi.SubItems.Add(string.Format("{0:0.00} MAD", ((Vetement)article).prixTTC()));
                    lvi.SubItems.Add((string.Format("{0:0.00} MAD", ((Vetement)article).PrixHT)));
                    lvi.SubItems.Add("");
                    lvi.SubItems.Add("");
                    lvi.SubItems.Add(((Vetement)article).Reference.ToString());
                    if(((Vetement)article).Images != null)
                    {
                        imgL.Images.Add(((Vetement)article).Images);
                        imgS.Images.Add(((Vetement)article).Images);
                        lvi.ImageIndex = i;
                        
                        i++;
                    }

                    lv1.Items.Add(lvi);

                }
                if (((Button)sender).Equals(btn_elect) && article is Electrique)
                {
                    lv1.Columns[4].Width = 0;
                    lv1.Columns[3].Width = 150;
                    if (article is Electromenager)
                    {

                        lvi.Group = ElectromenagerGroup;
                        lvi.Text = article.Designation;
                        lvi.SubItems.Add(string.Format("{0:0.00} MAD",((Electromenager)article).prixTTC()));
                        lvi.SubItems.Add((string.Format("{0:0.00} MAD", ((Electromenager)article).PrixHT)));
                        lvi.SubItems.Add(((Electromenager)article).Consommation.ToString());
                        lvi.SubItems.Add("");
                        lvi.SubItems.Add(((Electromenager)article).Reference.ToString());
                        if (((Electromenager)article).Images != null)
                        {
                            imgL.Images.Add(((Electromenager)article).Images);
                            imgS.Images.Add(((Electromenager)article).Images);
                            lvi.ImageIndex = i;

                            i++;
                        }
                        
                        lv1.Items.Add(lvi);
                        
                    }
                    else
                    {

                        if (article is VideoHiFi)
                        {

                            lvi.Group = VideoHiFiGroup;
                            lvi.Text = article.Designation;
                            lvi.SubItems.Add(string.Format("{0:0.00} MAD", ((VideoHiFi)article).prixTTC()));
                            lvi.SubItems.Add((string.Format("{0:0.00} MAD", ((VideoHiFi)article).PrixHT)));
                            lvi.SubItems.Add(((VideoHiFi)article).Consommation.ToString());
                            lvi.SubItems.Add("");
                            lvi.SubItems.Add(((VideoHiFi)article).Reference.ToString());

                            if (((VideoHiFi)article).Images != null)
                            {
                                imgL.Images.Add(((VideoHiFi)article).Images);
                                imgS.Images.Add(((VideoHiFi)article).Images);
                                lvi.ImageIndex = i;

                                i++;
                            }
                            
                            lv1.Items.Add(lvi);
                            

                        }

                    
                    }
                    lv1.Groups.Add(ElectromenagerGroup);
                    lv1.Groups.Add(VideoHiFiGroup);
                }
                if (((Button)sender).Equals(btn_cult) && article is Culturel)
                {
                    lv1.Columns[3].Width = 0;
                    lv1.Columns[4].Width = 150;
                    
                    if (article is Livre)
                    {

                        lvi.Group = LivreGroup;
                        lvi.Text = article.Designation;
                        lvi.SubItems.Add(string.Format("{0:0.00} MAD", ((Livre)article).prixTTC()));
                        lvi.SubItems.Add(string.Format("{0:0.00} MAD", ((Livre)article).PrixHT));
                        lvi.SubItems.Add("");
                        lvi.SubItems.Add(((Livre)article).Genre.ToString());
                        lvi.SubItems.Add(((Livre)article).Reference.ToString());

                        if (((Livre)article).Images != null)
                        {
                            imgL.Images.Add(((Livre)article).Images);
                            imgS.Images.Add(((Livre)article).Images);
                            lvi.ImageIndex = i;

                            i++;
                        }
                        
                        lv1.Items.Add(lvi);
                        
                    }
                    else
                    {

                        if (article is Disque)
                        {
                            lvi.Group = DisqueGroup;
                            lvi.Text = article.Designation;
                            lvi.SubItems.Add(string.Format("{0:0.00} MAD", ((Disque)article).prixTTC()));
                            lvi.SubItems.Add(string.Format("{0:0.00} MAD", ((Disque)article).PrixHT));
                            lvi.SubItems.Add("");
                            lvi.SubItems.Add(((Disque)article).Genre.ToString());
                            lvi.SubItems.Add(((Disque)article).Reference.ToString());

                            if (((Disque)article).Images != null)
                            {
                                imgL.Images.Add(((Disque)article).Images);
                                imgS.Images.Add(((Disque)article).Images);
                                lvi.ImageIndex = i;

                                i++;
                            }

                            
                            lv1.Items.Add(lvi);
                            

                        }


                    }
                    lv1.Groups.Add(LivreGroup);
                    lv1.Groups.Add(DisqueGroup);
                }





            }
        }

        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double totalprix = 0;
            if (lv1.SelectedItems.Count > 0)
            {
                reference = int.Parse(lv1.SelectedItems[0].SubItems[5].Text);
                FormDetails f = new FormDetails();
                f.ShowDialog();
                foreach (Article item in Program.Panier)
                {
                    totalprix += item.prixTTC();

                }

                lbl_panier.Text = string.Format("Panier ({0}) : {1:0.00} MAD", Program.Panier.Count, totalprix);
            }

        }



        private void lbl_panier_Click(object sender, EventArgs e)
        {
            FormPanier fr = new FormPanier();
            fr.ShowDialog();
            double totalprix = 0;
            foreach (Article item in Program.Panier)
            {
                totalprix += item.prixTTC();

            }

            lbl_panier.Text = string.Format("Panier ({0}) : {1:0.00} MAD", Program.Panier.Count, totalprix);

        }

        
    }
}

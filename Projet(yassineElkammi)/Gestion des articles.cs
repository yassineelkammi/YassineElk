using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Projet_yassineElkammi
{
    public partial class Gestiondesarticles : Form
    {
        Box_recherche fm = null;
        private List<Composition> Comp = new List<Composition>();
        private ErrorProvider EP = new ErrorProvider();
        private int articleCourant = 0;

        public Gestiondesarticles()
        {
            
            InitializeComponent();
        }

        private void Gestiondesarticles_Load(object sender, EventArgs e)
        {
            
            Chargement charge = new Chargement();
            charge.ShowDialog();
            
            MesArticles();
            this.BackColor = ColorTranslator.FromHtml("#7EC8E3");

            gb_principal.Hide();
            gb_principal.Enabled = false;

            btn_vetement.Focus();
            btn_ajouter.Enabled = false;
            btn_enregistrer.Enabled = false;
            btn_annuler.Enabled = false;

            panel_culturel.Enabled = false;
            panel_electronique.Enabled = false;
            panel_vetement.Enabled = false;
            foreach (var item in Enum.GetValues(typeof(MatiereP)))
            {
                cmb_matiere.Items.Add(item.ToString());
            }
            Afficher(0);

        }

        private void btn_vetement_Click(object sender, EventArgs e)
        {
            gb_principal.Show();
            gb_principal.Text = "Vêtement ";
            panel_vetement.Visible = true;
            panel_electronique.Visible = false;
            panel_culturel.Visible = false;


        }

        private void btn_electronique_Click(object sender, EventArgs e)
        {
            gb_principal.Show();
            gb_principal.Text = "Electroménager Vidéo / HiFi ";
            panel_vetement.Visible = false;
            panel_electronique.Visible = true;
            panel_culturel.Visible = false;
        }

        private void btn_culturel_Click(object sender, EventArgs e)
        {
            gb_principal.Show();
            gb_principal.Text = "Culturel ";
            panel_vetement.Visible = false;
            panel_electronique.Visible = false;
            panel_culturel.Visible = true;
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            Comp.Clear();
            lv_vetement.Items.Clear();
            btn_ajouter.Enabled = true;
            btn_annuler.Enabled = true;
            btn_editer.Enabled = false;
            btn_enregistrer.Enabled = false;
            btn_supprimer.Enabled = false;
            btn_rechercher.Enabled = false;
            btn_lister.Enabled = false;
            btn_fermer.Enabled = false;
            gb_navigation.Enabled = false;
            btn_vetement.Enabled = true;
            btn_culturel.Enabled = true;
            btn_electronique.Enabled = true;
            panel_vetement.Enabled = true;
            panel_culturel.Enabled = true;
            panel_electronique.Enabled = true;
            EffacerZone();
            txt_ref.Text = (Article._n+ 1).ToString();
            gb_principal.Enabled = true;

        }

        private void btn_ajouterlst_Click(object sender, EventArgs e)
        {
            double cpt = 0;
            double prop;
            double.TryParse(txt_proportion.Text, out prop);
            if (cmb_matiere.SelectedIndex != -1 && txt_proportion.Text!="" && prop>0 && prop<=100)
            {

                Composition c = new Composition((MatiereP)cmb_matiere.SelectedIndex, prop/100);
                foreach (Composition t in Comp)
                {
                    cpt += t.Proportion;
                }
                if (!Comp.Contains(c) && cpt + (prop / 100) <= 1)
                {
                    Comp.Add(c);
                    Chargerlv();

                }
                else
                {
                    MessageBox.Show("La matière ou la proportion non valide!!");
                }
            }
        }

        private void Chargerlv()
        {
            lv_vetement.Items.Clear();
            foreach (Composition item in Comp)
            {
                ListViewItem l = new ListViewItem();
                l.Text = item.Matiere.ToString();
                l.SubItems.Add(string.Format("{0:0.00} %", item.Proportion*100));
                lv_vetement.Items.Add(l);
            }
        }

        private void btn_supprimerlst_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de supprimer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lv_vetement.Items.Count > 0 && lv_vetement.SelectedIndices.Count > 0)
                {
                    foreach (ListViewItem item in lv_vetement.SelectedItems)
                    {
                        if (!Supprimer(item.Text))
                        {
                            MessageBox.Show("la supression a échoué!!");
                            break;
                        }
                    }
                    Chargerlv();
                }else
                {
                    MessageBox.Show("Votre liste est vide");
                
                }
            }
        }

        private int Rechercher(string mat)
        {

            for (int i = 0; i < Comp.Count; i++)
            {
                if (mat.CompareTo(Comp[i].Matiere.ToString()) == 0)
                {
                    return i;
                }
            }
            return -1;

        }

        private bool Supprimer(string mat)
        {
            int i = Rechercher(mat);
            if (i != -1)
            {
                Comp.RemoveAt(i);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txt_Volume_TextChanged(object sender, EventArgs e)
        {
            double haut, larg, prof;
            EP.SetError(txt_hauteur, "");
            EP.SetError(txt_largeur, "");
            EP.SetError(txt_profondeur, "");
            if (txt_hauteur.Text!="" && txt_largeur.Text!="" && txt_profondeur.Text != "")
            {
                if (!double.TryParse(txt_hauteur.Text, out haut))
                {
                    EP.SetError(txt_hauteur, "Le contenu doit être numérique!!");
                }
                if (!double.TryParse(txt_largeur.Text, out larg))
                {
                    EP.SetError(txt_largeur, "Le contenu doit être numérique!!");
                }
                if (!double.TryParse(txt_profondeur.Text, out prof))
                {
                    EP.SetError(txt_profondeur, "Le contenu doit être numérique!!");
                }

                lbl_volume.Text = ((haut * larg * prof)/1000000).ToString()+"m²";
            }
        }

        private void txt_proportion_Validating(object sender, CancelEventArgs e)
        {
            double prop;
            EP.SetError(txt_proportion, "");
            if (txt_proportion.Text != "")
            {
                if(!double.TryParse(txt_proportion.Text, out prop))
                {
                    EP.SetError(txt_proportion, "Le contenu doit être numérique!!");
                    e.Cancel = true;
                }
                else
                {
                    if(prop < 0 || prop > 100)
                    {
                        EP.SetError(txt_proportion, "La valeur est compris entre 0 et 100");
                        e.Cancel = true;

                    }
                }
                
            }
        }

        private void btn_parcourrir_Click(object sender, EventArgs e)
        {
            parcourir.Filter = "Image Files(*.JPG)|*.JPG";
            if (parcourir.ShowDialog()== DialogResult.OK)
            {
                Image img = new Bitmap(parcourir.FileName);
                pb_principal.Image = img;

            }
        }

        private void Afficher(int indice)
        {

            if (indice < 0 || indice > Program.Articles.Count - 1)
            { return; }
            btn_suivant.Enabled = true;
            btn_precedant.Enabled = true;
            btn_premier.Enabled = true;
            btn_dernier.Enabled = true;

            articleCourant = indice;

            if (articleCourant == 0)
            {
                btn_premier.Enabled = false;
                btn_precedant.Enabled = false;
            }
            else if (articleCourant == Program.Articles.Count - 1)
            {
                btn_dernier.Enabled = false;
                btn_suivant.Enabled = false;
            }
            btn_vetement.Enabled = true;
            btn_culturel.Enabled = true;
            btn_electronique.Enabled = true;

            txt_ref.Text = Program.Articles[indice].Reference.ToString();
            txt_desig.Text = Program.Articles[indice].Designation;
            txt_prixht.Text = Program.Articles[indice].PrixHT.ToString();
            lbl_prixttc.Text = Program.Articles[indice].prixTTC().ToString();
            pb_principal.Image = Program.Articles[indice].Images;

            if (Program.Articles[indice] is Vetement)
            {
                btn_vetement.PerformClick() ;
                
                lv_vetement.Items.Clear();
                Comp.Clear();

                foreach (Composition item in ((Vetement)Program.Articles[indice]).Compositions)
                {
                    
                    Comp.Add(item);
                    ListViewItem l = new ListViewItem();
                    l.Text = item.Matiere.ToString();
                    l.SubItems.Add(string.Format("{0:0.00} %", item.Proportion*100));
                    lv_vetement.Items.Add(l);
                }
                btn_electronique.Enabled = false;
                btn_culturel.Enabled = false;
            }
            else if (Program.Articles[indice] is Electrique)
            {
                btn_electronique.PerformClick();
                
                txt_largeur.Text = ((Electrique)Program.Articles[indice]).Largeur.ToString();
                txt_hauteur.Text= ((Electrique)Program.Articles[indice]).Hauteur.ToString();
                txt_profondeur.Text = ((Electrique)Program.Articles[indice]).Profondeur.ToString();
                txt_consomation.Text = ((Electrique)Program.Articles[indice]).Consommation.ToString();
                txt_poid.Text = ((Electrique)Program.Articles[indice]).Poid.ToString();
                if(Program.Articles[indice] is Electromenager)
                {
                    rb_electromenager.Checked = true;
                }
                else
                {
                    rb_videohifi.Checked = true;
                }
                btn_vetement.Enabled = false;
                btn_culturel.Enabled = false;
            }
            else if(Program.Articles[indice] is Culturel)
            {
                btn_culturel.PerformClick();
                
                txt_genre.Text = ((Culturel)Program.Articles[indice]).Genre;
                if(Program.Articles[indice] is Livre)
                {
                    rb_livre.Checked = true;
                }
                else
                {
                    rb_disque.Checked = true;

                }
                btn_electronique.Enabled = false;
                btn_vetement.Enabled = false;
            }
            

        }

        private void Naviguer(string tag)
        {
            btn_dernier.Enabled = true;
            btn_suivant.Enabled = true;
            btn_premier.Enabled = true;
            btn_precedant.Enabled = true;
            btn_electronique.Enabled = true;
            btn_culturel.Enabled = true;
            btn_vetement.Enabled = true;
            switch (tag)
            {
                case "start":
                    Afficher(0);
                    break;
                case "prev":
                   
                    Afficher(articleCourant-1);
                    break;
                case "next":
                    Afficher(articleCourant +1);
                    break;
                case "last":
                    Afficher(Program.Articles.Count-1);
                    break;

            }
        }

        private void btn_naviguer_Click(object sender, EventArgs e)
        {
            Naviguer(((Button)sender).Tag.ToString());
        }

        private void EffacerZone()
        {
            foreach (Control x in gb_principal.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
            foreach (Control x in panel_vetement.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
            foreach (Control x in panel_electronique.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
            foreach (Control x in panel_culturel.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
            lbl_prixttc.Text = "";
            lbl_volume.Text = "";
            lv_vetement.Items.Clear();
            pb_principal.Image = null;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Article art=null;
            if (txt_desig.Text == "" || txt_prixht.Text == "")
            {
                MessageBox.Show("Vous devez remplir tout les champs!");
                return;
            }
            
            if (panel_vetement.Visible && Comp.Count !=0)
            {
                
                art = new Vetement(txt_desig.Text, int.Parse(txt_prixht.Text),new List<Composition>(Comp));
            }
            
            if (panel_electronique.Visible)
            {
                if(txt_consomation.Text == "" || txt_hauteur.Text == "" || txt_hauteur.Text == "" || txt_largeur.Text == "" || txt_poid.Text == "" || txt_profondeur.Text == "")
                {
                    MessageBox.Show("Vous devez remplir tout les champs!");
                    return;
                }
                if (rb_electromenager.Checked)
                {
                    art = new Electromenager(txt_desig.Text, int.Parse(txt_prixht.Text), int.Parse(txt_consomation.Text), double.Parse(txt_hauteur.Text), double.Parse(txt_largeur.Text), double.Parse(txt_poid.Text), double.Parse(txt_profondeur.Text));
                }
                else if(rb_videohifi.Checked)
                {
                    art = new VideoHiFi(txt_desig.Text, int.Parse(txt_prixht.Text), int.Parse(txt_consomation.Text), double.Parse(txt_hauteur.Text), double.Parse(txt_largeur.Text), double.Parse(txt_poid.Text), double.Parse(txt_profondeur.Text));
                }
            }

            if(panel_culturel.Visible)
            {     
                if (txt_genre.Text == "")
                {
                    MessageBox.Show("Vous devez remplir tout les champs!");
                    return;
                }
                if (rb_livre.Checked)
                {
                    art = new Livre(txt_desig.Text, int.Parse(txt_prixht.Text), txt_genre.Text);

                }
                else
                {
                    art = new Disque(txt_desig.Text, int.Parse(txt_prixht.Text), txt_genre.Text);
                }
                
            }

            if (art != null)
            {
                if(pb_principal.Image != null)
                {
                    art.ChoisirImage(pb_principal.Image);
                }
                Program.Articles.Add(art);
                
                btn_ajouter.Enabled = false;
                btn_annuler.Enabled = false;
                btn_enregistrer.Enabled = false;
                btn_editer.Enabled     = true;
                btn_supprimer.Enabled  = true;
                btn_rechercher.Enabled = true;
                btn_lister.Enabled     = true;
                btn_fermer.Enabled     = true;
                gb_navigation.Enabled = true;
                gb_principal.Enabled = false;
                panel_culturel.Enabled = false;
                panel_electronique.Enabled = false;
                panel_vetement.Enabled = false;
                Comp.Clear();
                EffacerZone();
                Afficher(Program.Articles.Count-1);
            }else
            {
                MessageBox.Show("Vous devez remplir tout les champs!");
            }
        }

        private void btn_editer_Click(object sender, EventArgs e)
        {
            gb_principal.Enabled = true;
            gb_type.Enabled = false;
            gb_navigation.Enabled = false;
            btn_ajouter.Enabled = false;
            btn_annuler.Enabled = true;
            btn_enregistrer.Enabled = true;
            btn_editer.Enabled = true;
            btn_supprimer.Enabled = false;
            btn_rechercher.Enabled = false;
            btn_lister.Enabled = false;
            btn_fermer.Enabled = false;
            btn_nouveau.Enabled = false;
            btn_editer.Enabled = false;
            panel_vetement.Enabled = true;
            panel_culturel.Enabled = true;
            rb_disque.Enabled = false;
            rb_livre.Enabled = false;
            rb_electromenager.Enabled = false;
            rb_videohifi.Enabled = false;
            panel_electronique.Enabled = true;
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            Article art = Program.Articles[articleCourant];
            if (art is Vetement)
            {
                art.Designation = txt_desig.Text;
                art.PrixHT = double.Parse(txt_prixht.Text);
                art.ChoisirImage(pb_principal.Image);
                ((Vetement)art).Compositions.Clear();
                foreach (Composition item in Comp)
                {
                    ((Vetement)art).AjouterMatière(item.Matiere, item.Proportion);
                }
                
            }
            if(art is Electromenager)
            {
                art.Designation = txt_desig.Text;
                art.PrixHT = double.Parse(txt_prixht.Text);
                art.ChoisirImage(pb_principal.Image);
                ((Electromenager)art).Consommation = int.Parse(txt_consomation.Text);
                ((Electromenager)art).Hauteur = int.Parse(txt_hauteur.Text);
                ((Electromenager)art).Largeur = int.Parse(txt_largeur.Text);
                ((Electromenager)art).Poid = int.Parse(txt_poid.Text);
                ((Electromenager)art).Profondeur = int.Parse(txt_profondeur.Text);
            } 
            if(art is VideoHiFi)
            {
                art.Designation = txt_desig.Text;
                art.PrixHT = double.Parse(txt_prixht.Text);
                art.ChoisirImage(pb_principal.Image);
                ((Electromenager)art).Consommation = int.Parse(txt_consomation.Text);
                ((Electromenager)art).Hauteur = int.Parse(txt_hauteur.Text);
                ((Electromenager)art).Largeur = int.Parse(txt_largeur.Text);
                ((Electromenager)art).Poid = int.Parse(txt_poid.Text);
                ((Electromenager)art).Profondeur = int.Parse(txt_profondeur.Text);
            }
            if(art is Livre)
            {
                art.Designation = txt_desig.Text;
                art.PrixHT = double.Parse(txt_prixht.Text);
                art.ChoisirImage(pb_principal.Image);
                ((Livre)art).Genre = txt_genre.Text;
            }
            if(art is Disque)
            {
                art.Designation = txt_desig.Text;
                art.PrixHT = double.Parse(txt_prixht.Text);
                art.ChoisirImage(pb_principal.Image);
                ((Disque)art).Genre = txt_genre.Text;
            }
            Program.Articles[articleCourant] = art;
            gb_principal.Enabled = false;
            Afficher(articleCourant);
            btn_ajouter.Enabled = false;
            btn_enregistrer.Enabled = false;
            btn_nouveau.Enabled = true;
            btn_editer.Enabled = true;
            btn_supprimer.Enabled = true;
            btn_rechercher.Enabled = true;
            btn_annuler.Enabled = false;
            btn_lister.Enabled = true;
            btn_fermer.Enabled = true;
            gb_navigation.Enabled = true;
            gb_type.Enabled = true;

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            
            btn_annuler.Enabled = false;
            btn_ajouter.Enabled = false;
            btn_enregistrer.Enabled = false;
            btn_nouveau.Enabled = true;
            btn_editer.Enabled = true;
            btn_supprimer.Enabled = true;
            btn_rechercher.Enabled = true;
            btn_lister.Enabled = true;
            btn_fermer.Enabled = true;
           
            gb_type.Enabled = true;
            gb_principal.Enabled = false;
            panel_culturel.Enabled = false;
            panel_electronique.Enabled = false;
            panel_vetement.Enabled = false;
            Afficher(0);
            gb_navigation.Enabled = true;
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Etes vous sur de supprimer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Program.Articles.Count != 0)
                {
                    btn_vetement.Enabled = true;
                    btn_culturel.Enabled = true;
                    btn_electronique.Enabled = true;
                    EffacerZone();
                    Program.Articles.RemoveAt(articleCourant);
                    Afficher(0);
                }
            }
            gb_navigation.Enabled = true;
        }

        private void txt_all_validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            EP.SetError(t, "");
            if (t.Text == string.Empty)
            {
                EP.SetError(t, "Le champ est vide!!");
                e.Cancel = true;
            }
            if(t.Name.CompareTo("txt_desig") == 0 && double.TryParse(t.Text, out double test))
            {
                EP.SetError(t, "Vous ne devez pas saisir les chiffres seulement!!");
                e.Cancel = true;
            }

            if(t.Name.CompareTo("txt_prixht") == 0 && !double.TryParse(t.Text, out double test1))
            {
                EP.SetError(t, "Le champ contient des valeurs non numériques!!");
                e.Cancel = true;

            }
            if (t.Name.CompareTo("txt_genre") == 0 && double.TryParse(t.Text, out double test2))
            {
                EP.SetError(t, "Vous ne devez pas saisir les chiffres seulement!!");
                e.Cancel = true;
            }
            if (t.Name.CompareTo("txt_hauteur") == 0 && !double.TryParse(t.Text, out double test3))
            {
                EP.SetError(t, "Le champ contient des valeurs non numériques!!");
                e.Cancel = true;
            }
            if (t.Name.CompareTo("txt_largeur") == 0 && !double.TryParse(t.Text, out double test4))
            {
                EP.SetError(t, "Le champ contient des valeurs non numériques!!");
                e.Cancel = true;
            }
            if (t.Name.CompareTo("txt_profondeur") == 0 && !double.TryParse(t.Text, out double test5))
            {
                EP.SetError(t, "Le champ contient des valeurs non numériques!!");
                e.Cancel = true;
            }
            if (t.Name.CompareTo("txt_poid") == 0 && !double.TryParse(t.Text, out double test6))
            {
                EP.SetError(t, "Le champ contient des valeurs non numériques!!");
                e.Cancel = true;
            }
            if (t.Name.CompareTo("txt_consomation") == 0 && !double.TryParse(t.Text, out double test7))
            {
                EP.SetError(t, "Le champ contient des valeurs non numériques!!");
                e.Cancel = true;
            }
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de Quitter?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            
            fm = new Box_recherche();
            fm.ShowDialog();
            if (Box_recherche.indice == -1)
            {
                MessageBox.Show("La reference introuvable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Box_recherche.indice = 0;
                return;
            }
            else
            {
                Afficher(Box_recherche.indice);
                
                
                
                    
            }   
        }

        private void btn_lister_Click(object sender, EventArgs e)
        {
            ListeArticles f = new ListeArticles();
            f.ShowDialog();

        }

        private void Gestiondesarticles_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void MesArticles()
        {
            //Vetement
            Vetement v1 = new Vetement("T-Shirt bleu ciel  ", 100, new List<Composition>() { new Composition(MatiereP.Acrylic, 0.1), new Composition(MatiereP.Cotton, 0.5) });
            Vetement v2 = new Vetement("T-Shirt en rose pour Femme ", 100, new List<Composition>() { new Composition(MatiereP.Cotton, 0.5) , new Composition(MatiereP.Nylon, 0.5) });
            Vetement v3 = new Vetement("T-Shirt mauve pour Homme", 100, new List<Composition>() { new Composition(MatiereP.Cotton, 0.5), new Composition(MatiereP.Nylon, 0.25), new Composition(MatiereP.Acrylic, 0.25) });
            Vetement v4 = new Vetement("T-Shirt blanc ", 100, new List<Composition>() { new Composition(MatiereP.Cotton, 0.5), new Composition(MatiereP.Nylon, 0.5) });
            Vetement v5 = new Vetement("T-Shirt Jaune pour Femme", 100, new List<Composition>() { new Composition(MatiereP.Cotton, 0.5) });
            Vetement v6 = new Vetement("Pantalon jeans Baggy Pour Femme ",200, new List<Composition>() { new Composition(MatiereP.Cotton, 1) });
            Vetement v7 = new Vetement("Pantalon Noir", 150, new List<Composition>() { new Composition(MatiereP.Cotton, 0.5), new Composition(MatiereP.Nylon, 0.5) });
            Vetement v8 = new Vetement("Pantalon jeans Slim Pour Femme", 300, new List<Composition>() { new Composition(MatiereP.Cotton, 0.5), new Composition(MatiereP.Nylon, 0.5) });

            //Electromenager
            Electrique e1 = new Electromenager("Réfrigérateur - Beko (Gris) ", 3000, 300000, 178.1, 90.5, 200, 74.6);
            Electrique e2 = new Electromenager("Réfrigérateur - SAMSUNG (Blanc) ", 2500, 200000, 178.1, 90.5, 140, 74.6);
            Electrique e3 = new Electromenager("Réfrigérateur - Whirpools (Blanc) ", 2500, 350000, 178.1, 90.5, 119, 74.6);
            Electrique e4 = new Electromenager("DW60M5070FS Lave-vaisselle en pose libre de taille standard à 14 couverts  ", 2500, 350000, 90.5, 55, 58, 125);
            Electrique e5 = new Electromenager("Lave-Linge Addwash 7 kg - WW70T554DAN ", 5299, 350000, 85, 60, 67, 55);

            //VideoHIFI
            VideoHiFi vh1 =new VideoHiFi("Lecteur DVD - SONY DVP-SR760H ", 200, 39600, 36, 4.5, 0.016, 20.7);
            VideoHiFi vh2 = new VideoHiFi("Samsung 32\" Smart Tv Rapide + Récepteur - TNT et WI - FI + Screen Mirroring - S5 32N5300 ", 2800, 350000, 115, 190, 7.32, 19);
            VideoHiFi vh3 = new VideoHiFi("LG NANO75UP 55\" Class HDR 4K UHD Smart NanoCell LED TV ", 6960.75 , 100, 125, 220, 7, 14);
            VideoHiFi vh4 = new VideoHiFi("Canon EOS M50 Mirrorless Digital Camera avec 24-105mm f/4L Lens (Black) ", 28990 , 350000, 10.16, 12.9, 0.436, 7.7);

            //Livre
            Livre l1 = new Livre("Pour les Nuls - 3ème édition : Programmer Pour les Nuls 3ed ", 760.30, "Informatique ");
            Livre l2 = new Livre("Du C au C++ de la programmation procédurale à l'objet (2ième édition) ", 400.83, "Informatique ");
            Livre l3 = new Livre("La programmation orientée objet ", 360.75, "Informatique ");

            //Disque
            Disque d1 = new Disque("Eternals Film", 200,"Science Fiction");
            Disque d2 = new Disque("Max Steel Film", 200, "Science Fiction");



            //affectation du photo:

            //vetement
            v1.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\tshirt_blue.jpg"));
            v2.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\tshirt_pink.jpg"));
            v3.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\tshirt_purpl.jpg"));
            v4.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\tshirt_white.jpg"));
            v5.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\tshirt_yellew.jpg"));
            v6.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\pants3.jpg"));
            v7.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\pants1.jpg"));
            v8.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\pants2.jpg"));

            //Electro
            e1.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\refrigerateur1.jpg"));
            e2.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\refrigerateur2.jpg"));
            e3.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\refrigerateur3.jpg"));
            e4.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\lavevesselle1.jpg"));
            e5.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\machinealaver1.jpg"));

            //videhifi
            vh1.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\lecteurDVD.png"));
            vh2.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\tv2.jpg"));
            vh3.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\tv1.jpg"));
            vh4.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\cam1.jpg"));

            //livre
            l1.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\livre1.jpg"));
            l2.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\livre2.jpg"));
            l3.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\livre3.jpg"));

            //disque
            d1.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\movie1.jpg"));
            d2.ChoisirImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"pictures\movie2.jpg"));




            Program.Articles.AddRange(new List<Article>() { v1,v2,v3,v4,v5,v6,v7,v8,e1,e2,e3,e4,e5,vh1,vh2,vh3,vh4,l1,l2,l3,d1,d2 });
        }





    }
}













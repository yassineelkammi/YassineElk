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
    public partial class FormPanier : Form
    {
        double som;
        List<Article> PanierTemp = new List<Article>(Program.Panier);
        public FormPanier()
        {
            InitializeComponent();
        }

        private void FormPanier_Load(object sender, EventArgs e)
        {
            lst_panier.Columns.Add("Référence",80);
            lst_panier.Columns.Add("Désignation",150);
            lst_panier.Columns.Add("PrixTTC",100);

            lst_panier.FullRowSelect = true;
            lst_panier.Items.Clear();
           
            Chargerlv();
            AfficherLabel();
        }
        private string AfficherLabel()
        {
            lbl_somme.Text = "";

            lbl_somme.Text = string.Format("Panier({0}) : {1:0.00} MAD",lst_panier.Items.Count,som);
            return lbl_somme.Text;

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de fermer ??", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private int Rechercher(int indice)
        {

            for (int i = 0; i < PanierTemp.Count; i++)
            {
                if (indice== PanierTemp[i].Reference)
                {
                    return i;
                }
            }
            return -1;

        }
        private bool Supprimer(int obj)
        {
            int i = Rechercher(obj);
            if (i != -1)
            {
                PanierTemp.RemoveAt(i);
                return true;
            }
            else
            {
                return false;
            }
        }
        
       
        private void btn_retirer_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Etes vous sur de supprimer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lst_panier.Items.Count > 0 && lst_panier.SelectedIndices.Count > 0)
                {
                    foreach (ListViewItem item in lst_panier.SelectedItems)
                    {

                        if (!Supprimer(int.Parse(item.Text)))
                        {
                            MessageBox.Show("la supression a échoué!!");
                            break;
                            
                        }
                      
                        
                    }
                    Chargerlv();
                }
                else
                {
                    MessageBox.Show("Votre liste est vide");

                }
            }
            
            AfficherLabel();
        }
        private void Chargerlv()
        {
            lst_panier.Items.Clear();
            som = 0;
            foreach (Article achat in PanierTemp)
            {
                ListViewItem l = new ListViewItem();
                l.Text = achat.Reference.ToString();
                l.SubItems.Add(achat.Designation);
                l.SubItems.Add(string.Format("{0:0.00} MAD",achat.prixTTC()));
                lst_panier.Items.Add(l);
                som += achat.prixTTC();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Etes vous sûr de sauvegarder les modification?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.Panier = PanierTemp;
                
                this.Close();
            }
        }
    }
}

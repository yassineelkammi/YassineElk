namespace Projet_yassineElkammi
{
    partial class Gestiondesarticles
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestiondesarticles));
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.btn_culturel = new System.Windows.Forms.Button();
            this.btn_electronique = new System.Windows.Forms.Button();
            this.btn_vetement = new System.Windows.Forms.Button();
            this.gb_boite = new System.Windows.Forms.GroupBox();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.btn_lister = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_editer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.gb_principal = new System.Windows.Forms.GroupBox();
            this.panel_vetement = new System.Windows.Forms.Panel();
            this.lv_vetement = new System.Windows.Forms.ListView();
            this.Matiere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proportion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_supprimerlst = new System.Windows.Forms.Button();
            this.btn_ajouterlst = new System.Windows.Forms.Button();
            this.txt_proportion = new System.Windows.Forms.TextBox();
            this.cmb_matiere = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_principal = new System.Windows.Forms.PictureBox();
            this.txt_prixht = new System.Windows.Forms.TextBox();
            this.txt_desig = new System.Windows.Forms.TextBox();
            this.txt_ref = new System.Windows.Forms.TextBox();
            this.lbl_prixttc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_parcourrir = new System.Windows.Forms.Button();
            this.gb_navigation = new System.Windows.Forms.GroupBox();
            this.btn_dernier = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedant = new System.Windows.Forms.Button();
            this.btn_premier = new System.Windows.Forms.Button();
            this.panel_electronique = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_poid = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.rb_videohifi = new System.Windows.Forms.RadioButton();
            this.rb_electromenager = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_consomation = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_hauteur = new System.Windows.Forms.TextBox();
            this.txt_profondeur = new System.Windows.Forms.TextBox();
            this.txt_largeur = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_culturel = new System.Windows.Forms.Panel();
            this.rb_livre = new System.Windows.Forms.RadioButton();
            this.rb_disque = new System.Windows.Forms.RadioButton();
            this.txt_genre = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.parcourir = new System.Windows.Forms.OpenFileDialog();
            this.gb_type.SuspendLayout();
            this.gb_boite.SuspendLayout();
            this.gb_principal.SuspendLayout();
            this.panel_vetement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_principal)).BeginInit();
            this.gb_navigation.SuspendLayout();
            this.panel_electronique.SuspendLayout();
            this.panel_culturel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_type
            // 
            this.gb_type.Controls.Add(this.btn_culturel);
            this.gb_type.Controls.Add(this.btn_electronique);
            this.gb_type.Controls.Add(this.btn_vetement);
            this.gb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_type.Location = new System.Drawing.Point(25, 25);
            this.gb_type.Name = "gb_type";
            this.gb_type.Size = new System.Drawing.Size(616, 62);
            this.gb_type.TabIndex = 0;
            this.gb_type.TabStop = false;
            this.gb_type.Text = "Type d\'article";
            // 
            // btn_culturel
            // 
            this.btn_culturel.BackColor = System.Drawing.Color.Blue;
            this.btn_culturel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_culturel.Location = new System.Drawing.Point(412, 22);
            this.btn_culturel.Name = "btn_culturel";
            this.btn_culturel.Size = new System.Drawing.Size(150, 26);
            this.btn_culturel.TabIndex = 2;
            this.btn_culturel.Text = "Culturel";
            this.btn_culturel.UseVisualStyleBackColor = false;
            this.btn_culturel.Click += new System.EventHandler(this.btn_culturel_Click);
            // 
            // btn_electronique
            // 
            this.btn_electronique.BackColor = System.Drawing.Color.Blue;
            this.btn_electronique.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_electronique.Location = new System.Drawing.Point(234, 22);
            this.btn_electronique.Name = "btn_electronique";
            this.btn_electronique.Size = new System.Drawing.Size(150, 26);
            this.btn_electronique.TabIndex = 1;
            this.btn_electronique.Text = "Electronique";
            this.btn_electronique.UseVisualStyleBackColor = false;
            this.btn_electronique.Click += new System.EventHandler(this.btn_electronique_Click);
            // 
            // btn_vetement
            // 
            this.btn_vetement.BackColor = System.Drawing.Color.Blue;
            this.btn_vetement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_vetement.Location = new System.Drawing.Point(56, 23);
            this.btn_vetement.Name = "btn_vetement";
            this.btn_vetement.Size = new System.Drawing.Size(150, 26);
            this.btn_vetement.TabIndex = 0;
            this.btn_vetement.Text = "Vêtement";
            this.btn_vetement.UseVisualStyleBackColor = false;
            this.btn_vetement.Click += new System.EventHandler(this.btn_vetement_Click);
            // 
            // gb_boite
            // 
            this.gb_boite.Controls.Add(this.btn_fermer);
            this.gb_boite.Controls.Add(this.btn_lister);
            this.gb_boite.Controls.Add(this.btn_rechercher);
            this.gb_boite.Controls.Add(this.btn_supprimer);
            this.gb_boite.Controls.Add(this.btn_annuler);
            this.gb_boite.Controls.Add(this.btn_enregistrer);
            this.gb_boite.Controls.Add(this.btn_editer);
            this.gb_boite.Controls.Add(this.btn_ajouter);
            this.gb_boite.Controls.Add(this.btn_nouveau);
            this.gb_boite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_boite.Location = new System.Drawing.Point(687, 25);
            this.gb_boite.Name = "gb_boite";
            this.gb_boite.Size = new System.Drawing.Size(249, 575);
            this.gb_boite.TabIndex = 1;
            this.gb_boite.TabStop = false;
            this.gb_boite.Text = "Boîte à Outils";
            // 
            // btn_fermer
            // 
            this.btn_fermer.BackColor = System.Drawing.Color.Blue;
            this.btn_fermer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_fermer.Location = new System.Drawing.Point(56, 519);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(150, 44);
            this.btn_fermer.TabIndex = 8;
            this.btn_fermer.Text = "&Fermer";
            this.btn_fermer.UseVisualStyleBackColor = false;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // btn_lister
            // 
            this.btn_lister.BackColor = System.Drawing.Color.Blue;
            this.btn_lister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_lister.Location = new System.Drawing.Point(56, 457);
            this.btn_lister.Name = "btn_lister";
            this.btn_lister.Size = new System.Drawing.Size(150, 44);
            this.btn_lister.TabIndex = 7;
            this.btn_lister.Text = "&Lister";
            this.btn_lister.UseVisualStyleBackColor = false;
            this.btn_lister.Click += new System.EventHandler(this.btn_lister_Click);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.BackColor = System.Drawing.Color.Blue;
            this.btn_rechercher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_rechercher.Location = new System.Drawing.Point(56, 395);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(150, 44);
            this.btn_rechercher.TabIndex = 6;
            this.btn_rechercher.Text = "&Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = false;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.Blue;
            this.btn_supprimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_supprimer.Location = new System.Drawing.Point(56, 333);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(150, 44);
            this.btn_supprimer.TabIndex = 5;
            this.btn_supprimer.Text = "&Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.Blue;
            this.btn_annuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_annuler.Location = new System.Drawing.Point(56, 271);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(150, 44);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "&Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.BackColor = System.Drawing.Color.Blue;
            this.btn_enregistrer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_enregistrer.Location = new System.Drawing.Point(56, 209);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(150, 44);
            this.btn_enregistrer.TabIndex = 3;
            this.btn_enregistrer.Text = "&Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = false;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // btn_editer
            // 
            this.btn_editer.BackColor = System.Drawing.Color.Blue;
            this.btn_editer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editer.Location = new System.Drawing.Point(56, 147);
            this.btn_editer.Name = "btn_editer";
            this.btn_editer.Size = new System.Drawing.Size(150, 44);
            this.btn_editer.TabIndex = 2;
            this.btn_editer.Text = "&Editer";
            this.btn_editer.UseVisualStyleBackColor = false;
            this.btn_editer.Click += new System.EventHandler(this.btn_editer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.Blue;
            this.btn_ajouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ajouter.Location = new System.Drawing.Point(56, 85);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(150, 44);
            this.btn_ajouter.TabIndex = 1;
            this.btn_ajouter.Text = "&Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.BackColor = System.Drawing.Color.Blue;
            this.btn_nouveau.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nouveau.Location = new System.Drawing.Point(56, 23);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(150, 44);
            this.btn_nouveau.TabIndex = 0;
            this.btn_nouveau.Text = "&Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = false;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // gb_principal
            // 
            this.gb_principal.Controls.Add(this.panel_vetement);
            this.gb_principal.Controls.Add(this.pb_principal);
            this.gb_principal.Controls.Add(this.txt_prixht);
            this.gb_principal.Controls.Add(this.txt_desig);
            this.gb_principal.Controls.Add(this.txt_ref);
            this.gb_principal.Controls.Add(this.lbl_prixttc);
            this.gb_principal.Controls.Add(this.label4);
            this.gb_principal.Controls.Add(this.label3);
            this.gb_principal.Controls.Add(this.label2);
            this.gb_principal.Controls.Add(this.label1);
            this.gb_principal.Controls.Add(this.btn_parcourrir);
            this.gb_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_principal.Location = new System.Drawing.Point(25, 110);
            this.gb_principal.Name = "gb_principal";
            this.gb_principal.Size = new System.Drawing.Size(644, 406);
            this.gb_principal.TabIndex = 2;
            this.gb_principal.TabStop = false;
            this.gb_principal.Text = "Vêtement";
            // 
            // panel_vetement
            // 
            this.panel_vetement.Controls.Add(this.lv_vetement);
            this.panel_vetement.Controls.Add(this.btn_supprimerlst);
            this.panel_vetement.Controls.Add(this.btn_ajouterlst);
            this.panel_vetement.Controls.Add(this.txt_proportion);
            this.panel_vetement.Controls.Add(this.cmb_matiere);
            this.panel_vetement.Controls.Add(this.label6);
            this.panel_vetement.Controls.Add(this.label5);
            this.panel_vetement.Location = new System.Drawing.Point(50, 194);
            this.panel_vetement.Name = "panel_vetement";
            this.panel_vetement.Size = new System.Drawing.Size(583, 200);
            this.panel_vetement.TabIndex = 19;
            // 
            // lv_vetement
            // 
            this.lv_vetement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Matiere,
            this.Proportion});
            this.lv_vetement.HideSelection = false;
            this.lv_vetement.Location = new System.Drawing.Point(274, 18);
            this.lv_vetement.Name = "lv_vetement";
            this.lv_vetement.Size = new System.Drawing.Size(292, 166);
            this.lv_vetement.TabIndex = 71;
            this.lv_vetement.UseCompatibleStateImageBehavior = false;
            this.lv_vetement.View = System.Windows.Forms.View.Details;
            // 
            // Matiere
            // 
            this.Matiere.Text = "Matière";
            this.Matiere.Width = 134;
            // 
            // Proportion
            // 
            this.Proportion.Text = "Proportion (%)";
            this.Proportion.Width = 122;
            // 
            // btn_supprimerlst
            // 
            this.btn_supprimerlst.Location = new System.Drawing.Point(95, 161);
            this.btn_supprimerlst.Name = "btn_supprimerlst";
            this.btn_supprimerlst.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimerlst.TabIndex = 70;
            this.btn_supprimerlst.Text = "<<<";
            this.btn_supprimerlst.UseVisualStyleBackColor = true;
            this.btn_supprimerlst.Click += new System.EventHandler(this.btn_supprimerlst_Click);
            // 
            // btn_ajouterlst
            // 
            this.btn_ajouterlst.Location = new System.Drawing.Point(95, 132);
            this.btn_ajouterlst.Name = "btn_ajouterlst";
            this.btn_ajouterlst.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouterlst.TabIndex = 69;
            this.btn_ajouterlst.Text = ">>>";
            this.btn_ajouterlst.UseVisualStyleBackColor = true;
            this.btn_ajouterlst.Click += new System.EventHandler(this.btn_ajouterlst_Click);
            // 
            // txt_proportion
            // 
            this.txt_proportion.Location = new System.Drawing.Point(50, 89);
            this.txt_proportion.Multiline = true;
            this.txt_proportion.Name = "txt_proportion";
            this.txt_proportion.Size = new System.Drawing.Size(121, 26);
            this.txt_proportion.TabIndex = 68;
            this.txt_proportion.Validating += new System.ComponentModel.CancelEventHandler(this.txt_proportion_Validating);
            // 
            // cmb_matiere
            // 
            this.cmb_matiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_matiere.FormattingEnabled = true;
            this.cmb_matiere.Location = new System.Drawing.Point(50, 37);
            this.cmb_matiere.Name = "cmb_matiere";
            this.cmb_matiere.Size = new System.Drawing.Size(121, 24);
            this.cmb_matiere.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Proportion :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Matière :";
            // 
            // pb_principal
            // 
            this.pb_principal.Location = new System.Drawing.Point(463, 22);
            this.pb_principal.Name = "pb_principal";
            this.pb_principal.Size = new System.Drawing.Size(141, 146);
            this.pb_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_principal.TabIndex = 18;
            this.pb_principal.TabStop = false;
            // 
            // txt_prixht
            // 
            this.txt_prixht.Location = new System.Drawing.Point(152, 129);
            this.txt_prixht.Multiline = true;
            this.txt_prixht.Name = "txt_prixht";
            this.txt_prixht.Size = new System.Drawing.Size(117, 26);
            this.txt_prixht.TabIndex = 12;
            this.txt_prixht.Validating += new System.ComponentModel.CancelEventHandler(this.txt_all_validating);
            // 
            // txt_desig
            // 
            this.txt_desig.Location = new System.Drawing.Point(152, 62);
            this.txt_desig.Multiline = true;
            this.txt_desig.Name = "txt_desig";
            this.txt_desig.Size = new System.Drawing.Size(284, 59);
            this.txt_desig.TabIndex = 11;
            this.txt_desig.Tag = "desig";
            this.txt_desig.Validating += new System.ComponentModel.CancelEventHandler(this.txt_all_validating);
            // 
            // txt_ref
            // 
            this.txt_ref.Enabled = false;
            this.txt_ref.Location = new System.Drawing.Point(152, 22);
            this.txt_ref.Multiline = true;
            this.txt_ref.Name = "txt_ref";
            this.txt_ref.Size = new System.Drawing.Size(117, 26);
            this.txt_ref.TabIndex = 10;
            // 
            // lbl_prixttc
            // 
            this.lbl_prixttc.AutoSize = true;
            this.lbl_prixttc.ForeColor = System.Drawing.Color.Red;
            this.lbl_prixttc.Location = new System.Drawing.Point(154, 174);
            this.lbl_prixttc.Name = "lbl_prixttc";
            this.lbl_prixttc.Size = new System.Drawing.Size(52, 17);
            this.lbl_prixttc.TabIndex = 7;
            this.lbl_prixttc.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "PrixTTC :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(80, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "PrixHT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Désignation :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Référence :";
            // 
            // btn_parcourrir
            // 
            this.btn_parcourrir.BackColor = System.Drawing.Color.Blue;
            this.btn_parcourrir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_parcourrir.Location = new System.Drawing.Point(286, 22);
            this.btn_parcourrir.Name = "btn_parcourrir";
            this.btn_parcourrir.Size = new System.Drawing.Size(150, 26);
            this.btn_parcourrir.TabIndex = 2;
            this.btn_parcourrir.Text = "...";
            this.btn_parcourrir.UseVisualStyleBackColor = false;
            this.btn_parcourrir.Click += new System.EventHandler(this.btn_parcourrir_Click);
            // 
            // gb_navigation
            // 
            this.gb_navigation.Controls.Add(this.btn_dernier);
            this.gb_navigation.Controls.Add(this.btn_suivant);
            this.gb_navigation.Controls.Add(this.btn_precedant);
            this.gb_navigation.Controls.Add(this.btn_premier);
            this.gb_navigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_navigation.Location = new System.Drawing.Point(25, 538);
            this.gb_navigation.Name = "gb_navigation";
            this.gb_navigation.Size = new System.Drawing.Size(656, 62);
            this.gb_navigation.TabIndex = 3;
            this.gb_navigation.TabStop = false;
            this.gb_navigation.Text = "Navigation";
            // 
            // btn_dernier
            // 
            this.btn_dernier.BackColor = System.Drawing.Color.Blue;
            this.btn_dernier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_dernier.Location = new System.Drawing.Point(494, 24);
            this.btn_dernier.Name = "btn_dernier";
            this.btn_dernier.Size = new System.Drawing.Size(122, 26);
            this.btn_dernier.TabIndex = 3;
            this.btn_dernier.Tag = "last";
            this.btn_dernier.Text = ">>|";
            this.btn_dernier.UseVisualStyleBackColor = false;
            this.btn_dernier.Click += new System.EventHandler(this.btn_naviguer_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.BackColor = System.Drawing.Color.Blue;
            this.btn_suivant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_suivant.Location = new System.Drawing.Point(348, 24);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(122, 26);
            this.btn_suivant.TabIndex = 2;
            this.btn_suivant.Tag = "next";
            this.btn_suivant.Text = ">>";
            this.btn_suivant.UseVisualStyleBackColor = false;
            this.btn_suivant.Click += new System.EventHandler(this.btn_naviguer_Click);
            // 
            // btn_precedant
            // 
            this.btn_precedant.BackColor = System.Drawing.Color.Blue;
            this.btn_precedant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_precedant.Location = new System.Drawing.Point(202, 24);
            this.btn_precedant.Name = "btn_precedant";
            this.btn_precedant.Size = new System.Drawing.Size(122, 26);
            this.btn_precedant.TabIndex = 1;
            this.btn_precedant.Tag = "prev";
            this.btn_precedant.Text = "<<";
            this.btn_precedant.UseVisualStyleBackColor = false;
            this.btn_precedant.Click += new System.EventHandler(this.btn_naviguer_Click);
            // 
            // btn_premier
            // 
            this.btn_premier.BackColor = System.Drawing.Color.Blue;
            this.btn_premier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_premier.Location = new System.Drawing.Point(56, 24);
            this.btn_premier.Name = "btn_premier";
            this.btn_premier.Size = new System.Drawing.Size(122, 26);
            this.btn_premier.TabIndex = 0;
            this.btn_premier.Tag = "start";
            this.btn_premier.Text = "|<<";
            this.btn_premier.UseVisualStyleBackColor = false;
            this.btn_premier.Click += new System.EventHandler(this.btn_naviguer_Click);
            // 
            // panel_electronique
            // 
            this.panel_electronique.Controls.Add(this.label21);
            this.panel_electronique.Controls.Add(this.txt_poid);
            this.panel_electronique.Controls.Add(this.label22);
            this.panel_electronique.Controls.Add(this.rb_videohifi);
            this.panel_electronique.Controls.Add(this.rb_electromenager);
            this.panel_electronique.Controls.Add(this.label20);
            this.panel_electronique.Controls.Add(this.lbl_volume);
            this.panel_electronique.Controls.Add(this.label18);
            this.panel_electronique.Controls.Add(this.txt_consomation);
            this.panel_electronique.Controls.Add(this.label17);
            this.panel_electronique.Controls.Add(this.label16);
            this.panel_electronique.Controls.Add(this.txt_hauteur);
            this.panel_electronique.Controls.Add(this.txt_profondeur);
            this.panel_electronique.Controls.Add(this.txt_largeur);
            this.panel_electronique.Controls.Add(this.label15);
            this.panel_electronique.Controls.Add(this.label14);
            this.panel_electronique.Controls.Add(this.label9);
            this.panel_electronique.Controls.Add(this.label8);
            this.panel_electronique.Controls.Add(this.label7);
            this.panel_electronique.Location = new System.Drawing.Point(77, 303);
            this.panel_electronique.Name = "panel_electronique";
            this.panel_electronique.Size = new System.Drawing.Size(583, 200);
            this.panel_electronique.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(284, 161);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 15);
            this.label21.TabIndex = 76;
            this.label21.Text = "(kg)";
            // 
            // txt_poid
            // 
            this.txt_poid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_poid.Location = new System.Drawing.Point(160, 152);
            this.txt_poid.Multiline = true;
            this.txt_poid.Name = "txt_poid";
            this.txt_poid.Size = new System.Drawing.Size(117, 26);
            this.txt_poid.TabIndex = 75;
            this.txt_poid.Validating += new System.ComponentModel.CancelEventHandler(this.txt_all_validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(104, 161);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 15);
            this.label22.TabIndex = 74;
            this.label22.Text = "Poid :";
            // 
            // rb_videohifi
            // 
            this.rb_videohifi.AutoSize = true;
            this.rb_videohifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_videohifi.Location = new System.Drawing.Point(401, 157);
            this.rb_videohifi.Name = "rb_videohifi";
            this.rb_videohifi.Size = new System.Drawing.Size(99, 19);
            this.rb_videohifi.TabIndex = 73;
            this.rb_videohifi.TabStop = true;
            this.rb_videohifi.Text = "Vidéo / HiFi";
            this.rb_videohifi.UseVisualStyleBackColor = true;
            // 
            // rb_electromenager
            // 
            this.rb_electromenager.AutoSize = true;
            this.rb_electromenager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_electromenager.Location = new System.Drawing.Point(401, 99);
            this.rb_electromenager.Name = "rb_electromenager";
            this.rb_electromenager.Size = new System.Drawing.Size(127, 19);
            this.rb_electromenager.TabIndex = 72;
            this.rb_electromenager.TabStop = true;
            this.rb_electromenager.Text = "Electroménager";
            this.rb_electromenager.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(512, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 15);
            this.label20.TabIndex = 71;
            this.label20.Text = "(cm)";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.Location = new System.Drawing.Point(424, 45);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(47, 15);
            this.lbl_volume.TabIndex = 70;
            this.lbl_volume.Text = "label5";
            this.lbl_volume.TextChanged += new System.EventHandler(this.txt_Volume_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(284, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 15);
            this.label18.TabIndex = 69;
            this.label18.Text = "(watt)";
            // 
            // txt_consomation
            // 
            this.txt_consomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_consomation.Location = new System.Drawing.Point(160, 99);
            this.txt_consomation.Multiline = true;
            this.txt_consomation.Name = "txt_consomation";
            this.txt_consomation.Size = new System.Drawing.Size(117, 26);
            this.txt_consomation.TabIndex = 68;
            this.txt_consomation.Validating += new System.ComponentModel.CancelEventHandler(this.txt_all_validating);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(43, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 15);
            this.label17.TabIndex = 67;
            this.label17.Text = "Consomation :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(83, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 15);
            this.label16.TabIndex = 66;
            this.label16.Text = "Volume :";
            // 
            // txt_hauteur
            // 
            this.txt_hauteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hauteur.Location = new System.Drawing.Point(252, 42);
            this.txt_hauteur.Multiline = true;
            this.txt_hauteur.Name = "txt_hauteur";
            this.txt_hauteur.Size = new System.Drawing.Size(61, 26);
            this.txt_hauteur.TabIndex = 65;
            this.txt_hauteur.TextChanged += new System.EventHandler(this.txt_Volume_TextChanged);
            this.txt_hauteur.Validating += new System.ComponentModel.CancelEventHandler(this.txt_all_validating);
            // 
            // txt_profondeur
            // 
            this.txt_profondeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_profondeur.Location = new System.Drawing.Point(345, 42);
            this.txt_profondeur.Multiline = true;
            this.txt_profondeur.Name = "txt_profondeur";
            this.txt_profondeur.Size = new System.Drawing.Size(61, 26);
            this.txt_profondeur.TabIndex = 64;
            this.txt_profondeur.TextChanged += new System.EventHandler(this.txt_Volume_TextChanged);
            this.txt_profondeur.Validating += new System.ComponentModel.CancelEventHandler(this.txt_all_validating);
            // 
            // txt_largeur
            // 
            this.txt_largeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_largeur.Location = new System.Drawing.Point(160, 42);
            this.txt_largeur.Multiline = true;
            this.txt_largeur.Name = "txt_largeur";
            this.txt_largeur.Size = new System.Drawing.Size(61, 26);
            this.txt_largeur.TabIndex = 63;
            this.txt_largeur.TextChanged += new System.EventHandler(this.txt_Volume_TextChanged);
            this.txt_largeur.Validating += new System.ComponentModel.CancelEventHandler(this.txt_all_validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(342, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 15);
            this.label15.TabIndex = 62;
            this.label15.Text = "Profondeur";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(321, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 15);
            this.label14.TabIndex = 61;
            this.label14.Text = "x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 60;
            this.label9.Text = "Hauteur";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(228, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 59;
            this.label8.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "Largeur";
            // 
            // panel_culturel
            // 
            this.panel_culturel.Controls.Add(this.rb_livre);
            this.panel_culturel.Controls.Add(this.rb_disque);
            this.panel_culturel.Controls.Add(this.txt_genre);
            this.panel_culturel.Controls.Add(this.label27);
            this.panel_culturel.Location = new System.Drawing.Point(76, 303);
            this.panel_culturel.Name = "panel_culturel";
            this.panel_culturel.Size = new System.Drawing.Size(583, 200);
            this.panel_culturel.TabIndex = 21;
            // 
            // rb_livre
            // 
            this.rb_livre.AutoSize = true;
            this.rb_livre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_livre.Location = new System.Drawing.Point(148, 71);
            this.rb_livre.Name = "rb_livre";
            this.rb_livre.Size = new System.Drawing.Size(56, 19);
            this.rb_livre.TabIndex = 42;
            this.rb_livre.TabStop = true;
            this.rb_livre.Text = "Livre";
            this.rb_livre.UseVisualStyleBackColor = true;
            // 
            // rb_disque
            // 
            this.rb_disque.AutoSize = true;
            this.rb_disque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_disque.Location = new System.Drawing.Point(363, 71);
            this.rb_disque.Name = "rb_disque";
            this.rb_disque.Size = new System.Drawing.Size(70, 19);
            this.rb_disque.TabIndex = 41;
            this.rb_disque.TabStop = true;
            this.rb_disque.Text = "Disque";
            this.rb_disque.UseVisualStyleBackColor = true;
            // 
            // txt_genre
            // 
            this.txt_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_genre.Location = new System.Drawing.Point(148, 17);
            this.txt_genre.Multiline = true;
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(285, 26);
            this.txt_genre.TabIndex = 40;
            this.txt_genre.Validating += new System.ComponentModel.CancelEventHandler(this.txt_all_validating);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(73, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 15);
            this.label27.TabIndex = 39;
            this.label27.Text = "Genre :";
            // 
            // parcourir
            // 
            this.parcourir.FileName = "openFileDialog1";
            // 
            // Gestiondesarticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 615);
            this.Controls.Add(this.panel_culturel);
            this.Controls.Add(this.panel_electronique);
            this.Controls.Add(this.gb_navigation);
            this.Controls.Add(this.gb_principal);
            this.Controls.Add(this.gb_boite);
            this.Controls.Add(this.gb_type);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Gestiondesarticles";
            this.Text = "Gestion des articles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gestiondesarticles_FormClosing);
            this.Load += new System.EventHandler(this.Gestiondesarticles_Load);
            this.gb_type.ResumeLayout(false);
            this.gb_boite.ResumeLayout(false);
            this.gb_principal.ResumeLayout(false);
            this.gb_principal.PerformLayout();
            this.panel_vetement.ResumeLayout(false);
            this.panel_vetement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_principal)).EndInit();
            this.gb_navigation.ResumeLayout(false);
            this.panel_electronique.ResumeLayout(false);
            this.panel_electronique.PerformLayout();
            this.panel_culturel.ResumeLayout(false);
            this.panel_culturel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_type;
        private System.Windows.Forms.Button btn_vetement;
        private System.Windows.Forms.Button btn_culturel;
        private System.Windows.Forms.Button btn_electronique;
        private System.Windows.Forms.GroupBox gb_boite;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_lister;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_editer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.GroupBox gb_principal;
        private System.Windows.Forms.TextBox txt_prixht;
        private System.Windows.Forms.TextBox txt_desig;
        private System.Windows.Forms.Label lbl_prixttc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_parcourrir;
        private System.Windows.Forms.PictureBox pb_principal;
        private System.Windows.Forms.GroupBox gb_navigation;
        private System.Windows.Forms.Button btn_premier;
        private System.Windows.Forms.Button btn_dernier;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedant;
        private System.Windows.Forms.Panel panel_vetement;
        private System.Windows.Forms.Button btn_supprimerlst;
        private System.Windows.Forms.Button btn_ajouterlst;
        private System.Windows.Forms.TextBox txt_proportion;
        private System.Windows.Forms.ComboBox cmb_matiere;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_electronique;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_poid;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton rb_videohifi;
        private System.Windows.Forms.RadioButton rb_electromenager;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_consomation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_hauteur;
        private System.Windows.Forms.TextBox txt_profondeur;
        private System.Windows.Forms.TextBox txt_largeur;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_culturel;
        private System.Windows.Forms.RadioButton rb_livre;
        private System.Windows.Forms.RadioButton rb_disque;
        private System.Windows.Forms.TextBox txt_genre;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ListView lv_vetement;
        private System.Windows.Forms.ColumnHeader Matiere;
        private System.Windows.Forms.ColumnHeader Proportion;
        private System.Windows.Forms.OpenFileDialog parcourir;
        public System.Windows.Forms.TextBox txt_ref;
    }
}


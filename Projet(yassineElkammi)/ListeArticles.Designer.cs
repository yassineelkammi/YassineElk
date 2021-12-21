namespace Projet_yassineElkammi
{
    partial class ListeArticles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeArticles));
            this.gb_typeart = new System.Windows.Forms.GroupBox();
            this.lbl_panier = new System.Windows.Forms.Label();
            this.btn_cult = new System.Windows.Forms.Button();
            this.btn_elect = new System.Windows.Forms.Button();
            this.btn_vtm = new System.Windows.Forms.Button();
            this.lv1 = new System.Windows.Forms.ListView();
            this.gb_affichage = new System.Windows.Forms.GroupBox();
            this.rb_mosaique = new System.Windows.Forms.RadioButton();
            this.rb_liste = new System.Windows.Forms.RadioButton();
            this.rb_grand = new System.Windows.Forms.RadioButton();
            this.rb_petit = new System.Windows.Forms.RadioButton();
            this.rb_details = new System.Windows.Forms.RadioButton();
            this.gb_typeart.SuspendLayout();
            this.gb_affichage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_typeart
            // 
            this.gb_typeart.Controls.Add(this.lbl_panier);
            this.gb_typeart.Controls.Add(this.btn_cult);
            this.gb_typeart.Controls.Add(this.btn_elect);
            this.gb_typeart.Controls.Add(this.btn_vtm);
            this.gb_typeart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_typeart.Location = new System.Drawing.Point(12, 12);
            this.gb_typeart.Name = "gb_typeart";
            this.gb_typeart.Size = new System.Drawing.Size(776, 57);
            this.gb_typeart.TabIndex = 0;
            this.gb_typeart.TabStop = false;
            this.gb_typeart.Text = "Type d\'article";
            // 
            // lbl_panier
            // 
            this.lbl_panier.AutoSize = true;
            this.lbl_panier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_panier.ForeColor = System.Drawing.Color.Blue;
            this.lbl_panier.Location = new System.Drawing.Point(537, 24);
            this.lbl_panier.Name = "lbl_panier";
            this.lbl_panier.Size = new System.Drawing.Size(49, 15);
            this.lbl_panier.TabIndex = 3;
            this.lbl_panier.Text = "Panier";
            this.lbl_panier.Click += new System.EventHandler(this.lbl_panier_Click);
            // 
            // btn_cult
            // 
            this.btn_cult.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_cult.ForeColor = System.Drawing.Color.White;
            this.btn_cult.Location = new System.Drawing.Point(366, 19);
            this.btn_cult.Name = "btn_cult";
            this.btn_cult.Size = new System.Drawing.Size(132, 25);
            this.btn_cult.TabIndex = 2;
            this.btn_cult.Text = "Culturel";
            this.btn_cult.UseVisualStyleBackColor = false;
            this.btn_cult.Click += new System.EventHandler(this.btn_type_Click);
            // 
            // btn_elect
            // 
            this.btn_elect.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_elect.ForeColor = System.Drawing.Color.White;
            this.btn_elect.Location = new System.Drawing.Point(209, 19);
            this.btn_elect.Name = "btn_elect";
            this.btn_elect.Size = new System.Drawing.Size(132, 25);
            this.btn_elect.TabIndex = 1;
            this.btn_elect.Text = "Electronique";
            this.btn_elect.UseVisualStyleBackColor = false;
            this.btn_elect.Click += new System.EventHandler(this.btn_type_Click);
            // 
            // btn_vtm
            // 
            this.btn_vtm.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_vtm.ForeColor = System.Drawing.Color.White;
            this.btn_vtm.Location = new System.Drawing.Point(52, 19);
            this.btn_vtm.Name = "btn_vtm";
            this.btn_vtm.Size = new System.Drawing.Size(132, 25);
            this.btn_vtm.TabIndex = 0;
            this.btn_vtm.Text = "Vêtement";
            this.btn_vtm.UseVisualStyleBackColor = false;
            this.btn_vtm.Click += new System.EventHandler(this.btn_type_Click);
            // 
            // lv1
            // 
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(12, 75);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(776, 347);
            this.lv1.TabIndex = 1;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.SelectedIndexChanged += new System.EventHandler(this.lv1_SelectedIndexChanged);
            // 
            // gb_affichage
            // 
            this.gb_affichage.Controls.Add(this.rb_mosaique);
            this.gb_affichage.Controls.Add(this.rb_liste);
            this.gb_affichage.Controls.Add(this.rb_grand);
            this.gb_affichage.Controls.Add(this.rb_petit);
            this.gb_affichage.Controls.Add(this.rb_details);
            this.gb_affichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_affichage.Location = new System.Drawing.Point(12, 428);
            this.gb_affichage.Name = "gb_affichage";
            this.gb_affichage.Size = new System.Drawing.Size(776, 63);
            this.gb_affichage.TabIndex = 2;
            this.gb_affichage.TabStop = false;
            this.gb_affichage.Text = "Affichage";
            // 
            // rb_mosaique
            // 
            this.rb_mosaique.AutoSize = true;
            this.rb_mosaique.Location = new System.Drawing.Point(456, 20);
            this.rb_mosaique.Name = "rb_mosaique";
            this.rb_mosaique.Size = new System.Drawing.Size(88, 19);
            this.rb_mosaique.TabIndex = 4;
            this.rb_mosaique.TabStop = true;
            this.rb_mosaique.Text = "Mosaique";
            this.rb_mosaique.UseVisualStyleBackColor = true;
            this.rb_mosaique.CheckedChanged += new System.EventHandler(this.rb_view_CheckedChanged);
            // 
            // rb_liste
            // 
            this.rb_liste.AutoSize = true;
            this.rb_liste.Location = new System.Drawing.Point(387, 20);
            this.rb_liste.Name = "rb_liste";
            this.rb_liste.Size = new System.Drawing.Size(56, 19);
            this.rb_liste.TabIndex = 3;
            this.rb_liste.TabStop = true;
            this.rb_liste.Text = "Liste";
            this.rb_liste.UseVisualStyleBackColor = true;
            this.rb_liste.CheckedChanged += new System.EventHandler(this.rb_view_CheckedChanged);
            // 
            // rb_grand
            // 
            this.rb_grand.AutoSize = true;
            this.rb_grand.Location = new System.Drawing.Point(249, 20);
            this.rb_grand.Name = "rb_grand";
            this.rb_grand.Size = new System.Drawing.Size(125, 19);
            this.rb_grand.TabIndex = 2;
            this.rb_grand.TabStop = true;
            this.rb_grand.Text = "Grandes icones";
            this.rb_grand.UseVisualStyleBackColor = true;
            this.rb_grand.CheckedChanged += new System.EventHandler(this.rb_view_CheckedChanged);
            // 
            // rb_petit
            // 
            this.rb_petit.AutoSize = true;
            this.rb_petit.Location = new System.Drawing.Point(121, 20);
            this.rb_petit.Name = "rb_petit";
            this.rb_petit.Size = new System.Drawing.Size(115, 19);
            this.rb_petit.TabIndex = 1;
            this.rb_petit.TabStop = true;
            this.rb_petit.Text = "Petites icones";
            this.rb_petit.UseVisualStyleBackColor = true;
            this.rb_petit.CheckedChanged += new System.EventHandler(this.rb_view_CheckedChanged);
            // 
            // rb_details
            // 
            this.rb_details.AutoSize = true;
            this.rb_details.Location = new System.Drawing.Point(38, 20);
            this.rb_details.Name = "rb_details";
            this.rb_details.Size = new System.Drawing.Size(70, 19);
            this.rb_details.TabIndex = 0;
            this.rb_details.TabStop = true;
            this.rb_details.Text = "Détails";
            this.rb_details.UseVisualStyleBackColor = true;
            this.rb_details.CheckedChanged += new System.EventHandler(this.rb_view_CheckedChanged);
            // 
            // ListeArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.gb_affichage);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.gb_typeart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListeArticles";
            this.Text = "ListeArticles";
            this.Load += new System.EventHandler(this.ListeArticles_Load);
            this.gb_typeart.ResumeLayout(false);
            this.gb_typeart.PerformLayout();
            this.gb_affichage.ResumeLayout(false);
            this.gb_affichage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_typeart;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.Button btn_cult;
        private System.Windows.Forms.Button btn_elect;
        private System.Windows.Forms.Button btn_vtm;
        private System.Windows.Forms.GroupBox gb_affichage;
        private System.Windows.Forms.RadioButton rb_mosaique;
        private System.Windows.Forms.RadioButton rb_liste;
        private System.Windows.Forms.RadioButton rb_grand;
        private System.Windows.Forms.RadioButton rb_petit;
        private System.Windows.Forms.RadioButton rb_details;
        public System.Windows.Forms.Label lbl_panier;
    }
}
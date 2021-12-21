namespace Projet_yassineElkammi
{
    partial class FormPanier
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
            this.lst_panier = new System.Windows.Forms.ListView();
            this.lbl_somme = new System.Windows.Forms.Label();
            this.btn_retirer = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_panier
            // 
            this.lst_panier.HideSelection = false;
            this.lst_panier.Location = new System.Drawing.Point(0, -2);
            this.lst_panier.Name = "lst_panier";
            this.lst_panier.Size = new System.Drawing.Size(528, 326);
            this.lst_panier.TabIndex = 0;
            this.lst_panier.UseCompatibleStateImageBehavior = false;
            this.lst_panier.View = System.Windows.Forms.View.Details;
            // 
            // lbl_somme
            // 
            this.lbl_somme.AutoSize = true;
            this.lbl_somme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_somme.Location = new System.Drawing.Point(12, 349);
            this.lbl_somme.Name = "lbl_somme";
            this.lbl_somme.Size = new System.Drawing.Size(0, 17);
            this.lbl_somme.TabIndex = 1;
            // 
            // btn_retirer
            // 
            this.btn_retirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirer.Location = new System.Drawing.Point(291, 343);
            this.btn_retirer.Name = "btn_retirer";
            this.btn_retirer.Size = new System.Drawing.Size(75, 23);
            this.btn_retirer.TabIndex = 2;
            this.btn_retirer.Text = "&Retirer";
            this.btn_retirer.UseVisualStyleBackColor = true;
            this.btn_retirer.Click += new System.EventHandler(this.btn_retirer_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(372, 343);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "&OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(453, 343);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "&Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // FormPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 382);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_retirer);
            this.Controls.Add(this.lbl_somme);
            this.Controls.Add(this.lst_panier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPanier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPanier";
            this.Load += new System.EventHandler(this.FormPanier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_panier;
        private System.Windows.Forms.Label lbl_somme;
        private System.Windows.Forms.Button btn_retirer;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_annuler;
    }
}
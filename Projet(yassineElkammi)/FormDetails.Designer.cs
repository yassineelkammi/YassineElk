namespace Projet_yassineElkammi
{
    partial class FormDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetails));
            this.picture = new System.Windows.Forms.PictureBox();
            this.tb_zoom = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajouterpanier = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.gb_description = new System.Windows.Forms.GroupBox();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_zoom)).BeginInit();
            this.gb_description.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(1, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(691, 273);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // tb_zoom
            // 
            this.tb_zoom.Location = new System.Drawing.Point(59, 516);
            this.tb_zoom.Maximum = 100;
            this.tb_zoom.Minimum = 10;
            this.tb_zoom.Name = "tb_zoom";
            this.tb_zoom.Size = new System.Drawing.Size(322, 45);
            this.tb_zoom.TabIndex = 1;
            this.tb_zoom.Value = 10;
            this.tb_zoom.Scroll += new System.EventHandler(this.tb_zoom_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoom";
            // 
            // btn_ajouterpanier
            // 
            this.btn_ajouterpanier.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_ajouterpanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterpanier.ForeColor = System.Drawing.Color.White;
            this.btn_ajouterpanier.Location = new System.Drawing.Point(116, 584);
            this.btn_ajouterpanier.Name = "btn_ajouterpanier";
            this.btn_ajouterpanier.Size = new System.Drawing.Size(167, 30);
            this.btn_ajouterpanier.TabIndex = 3;
            this.btn_ajouterpanier.Text = "Ajouter au panier";
            this.btn_ajouterpanier.UseVisualStyleBackColor = false;
            this.btn_ajouterpanier.Click += new System.EventHandler(this.btn_ajouterpanier_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.Color.White;
            this.btn_annuler.Location = new System.Drawing.Point(470, 584);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(167, 30);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // gb_description
            // 
            this.gb_description.Controls.Add(this.lbl_info);
            this.gb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_description.Location = new System.Drawing.Point(1, 280);
            this.gb_description.Name = "gb_description";
            this.gb_description.Size = new System.Drawing.Size(691, 230);
            this.gb_description.TabIndex = 5;
            this.gb_description.TabStop = false;
            this.gb_description.Text = "Description";
            // 
            // lbl_info
            // 
            this.lbl_info.Location = new System.Drawing.Point(11, 19);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(670, 195);
            this.lbl_info.TabIndex = 0;
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 626);
            this.Controls.Add(this.gb_description);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ajouterpanier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_zoom);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDetails";
            this.Load += new System.EventHandler(this.FormDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_zoom)).EndInit();
            this.gb_description.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TrackBar tb_zoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ajouterpanier;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.GroupBox gb_description;
        private System.Windows.Forms.Label lbl_info;
    }
}
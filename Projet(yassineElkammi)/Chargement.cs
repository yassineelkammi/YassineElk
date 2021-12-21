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
    public partial class Chargement : Form
    {
        private static int i = 0;
        public Chargement()
        {
            InitializeComponent();
        }

        private void Chargement_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = i;
            if (i == 100)
            {
                timer.Stop();
                this.Close();
            }
            i += 20;
            
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public partial class FormGestionnaire : Form
    {
        public FormGestionnaire()
        {
            InitializeComponent();

        }
        private Form activeForm;

        private void OpenChildForm(UserControl  childForm, object btnSender)
        {
            if (activeForm != null)
            activeForm.Close();
            
            
            
            
            childForm.Dock = DockStyle.Fill;
            this.PAnelDesktop.Controls.Add(childForm);
            this.PAnelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }




     

        private void BTNEntraineur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UCgestionEntraineur(), sender);
            Panel2.BackgroundColor = Color.FromArgb(128, 0, 128);
        }

        private void BTNMembre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UCgestionMemebre(), sender);
            Panel2.BackgroundColor = Color.FromArgb(30  ,144 ,255) ;


        }

        private void BTNPackage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UCgestionPackage(), sender);
            Panel2.BackgroundColor = Color.FromArgb(255, 215, 0);


        }

        private void PAnelDesktop_Click(object sender, EventArgs e)
        {

        }

        private void BTNVendeur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UcGestionVendeur(), sender);
            Panel2.BackgroundColor = Color.FromArgb(255, 140, 0);
        }

        private void btnPaiment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UCGestionPaiment(), sender);
            Panel2.BackgroundColor = Color.FromArgb(0, 250, 154);
        }
    }
}

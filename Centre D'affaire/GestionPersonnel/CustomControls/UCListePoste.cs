﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    public partial class UCListePoste : UserControl
    {
        public UCListePoste()
        {
            InitializeComponent();
            
        }

        private void dgvListePostes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UCListePoste_Load(object sender, EventArgs e)
        {
            reloadForm();
        }
        public void reloadForm()
        {
            dgvListePostes.DataSource = Functions.getListPostes();

        }
    }
}

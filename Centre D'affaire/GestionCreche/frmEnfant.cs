﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionCreche
{
    public partial class frmEnfant : Form
    {
        public frmEnfant()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmEnfant form1 = new frmEnfant();
            form1.Show();
            this.Hide();
        }

        private void frmEnfant_Load(object sender, EventArgs e)
        {

        }

        private void gbSex_Enter(object sender, EventArgs e)
        {

        }
    }
}

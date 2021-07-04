﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Centre_D_affaire.GestionCreche
{
    public partial class frmEnfant : Form
    {
        private readonly frmEnfant Enfant = new frmEnfant();

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



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Fichiers XML (*.xml)|*.xml"
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _ = new XmlSerializer(typeof(frmEnfant));
                _ = new StreamWriter(saveFileDialog1.FileName);
                //    format.Serialize(fluxXML, frmEnfant);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Fichiers Binaire (*.bin)|*.bin"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // le using using System.Runtime.Serialization.Formatters.Binary; est nécessaire 

                _ = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                _ = new FileStream(saveFileDialog.FileName, FileMode.CreateNew);
            }
        }

        private void gbSex_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class uccPresence : UserControl
    {
        public uccPresence()
        {
            InitializeComponent();
        }

        private void uccPresence_Load(object sender, EventArgs e)
        {
            grid();
            TXTnumero.Enabled = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            
            Package p = new Package();
            Membre f= new Membre(TXTnumero.Text , Cbnom.Text, DPdate.Value ,Cbgenre.Text,"","","",p ,1 , 1,1,1, txtstatu.Text , Properties.Resources.image) ;
            f.Ajozuter(f);
            MessageBox.Show("Resultat ajouter avec succes ");
            ClassInterface i = new ClassInterface();
            i.viderform(this);
            grid();
        }
        public void grid()
        {
            GridMembre.Rows.Clear();
            for (int i = 0; i < Listes.fg.Count; i++)
            {
                GridMembre.Rows.Add();
                GridMembre.Rows[i].Cells["IDMembre"].Value = Listes.fg[i].Id;
                GridMembre.Rows[i].Cells["Nom"].Value = Listes.fg[i].NomComplet;
                GridMembre.Rows[i].Cells["Statut"].Value = Listes.fg[i].Statut;
                GridMembre.Rows[i].Cells["Date"].Value = Listes.fg[i].DateJoin;
                GridMembre.Rows[i].Cells["Prese"].Value = Listes.fg[i].Telephone;
                

            }


        }

        private void Cbnom_Click(object sender, EventArgs e)
        {
            Cbnom.DataSource = Listes.MembresListe ;
            Cbnom.ValueMember = "NomComplet";
            Cbnom.DisplayMember = "NomComplet";
        }

        private void Cbnom_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
        }

        private void Cbnom_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Listes.MembresListe.Count; i++)
            {
                if (Listes.MembresListe[i].NomComplet == Cbnom.Text)
                {
                    TXTnumero.Text = Listes.MembresListe[i].Id;
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    class Vendeur : Personne
    {
        

        //Constructure
        public Vendeur() { }

        public Vendeur(string ID, string NOmComplet, DateTime DAteREJoin, int TElephone, string EMail, string ADresse, string SEx)
            : base(ID, NOmComplet,  DAteREJoin, TElephone, EMail, ADresse, SEx)
        {

        }
        

        public int Rechercher(string id)
        {
            for (int i = 0; i < Listes.VendeursListe.Count; i++)
            {
                if (Listes.VendeursListe[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }


        public bool Ajouter(Vendeur m)
        {
            if (Rechercher(m.Id) == -1)
            {
                Listes.VendeursListe.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

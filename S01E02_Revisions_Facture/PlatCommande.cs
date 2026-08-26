using System;
using System.Collections.Generic;
using System.Text;

namespace S01E02_Revisions_Facture
{
    public class PlatCommande : ILigneFacturable
    {
        private string nom;
        private decimal prixUnitaire;
        private int quantite;

        public decimal Montant { get { return prixUnitaire * quantite; }

        public string Description { get { return nom; } }

        public 
        PlatCommande {
        } 
    }
}

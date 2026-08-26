using System;
using System.Collections.Generic;
using System.Text;

namespace S01E02_Revisions_Facture
{
    public class FraisLivraison : ILigneFacturable
    {
        private decimal distance;
        private decimal tarif;

        public decimal Montant { get { return distance * tarif;  } }
        public string Description { get { return "Montant = " + distance + "* " + tarif; } }

        FraisLivraison(decimal distance, decimal tarif)
        {
            this.distance = distance;
            this.tarif = tarif;
      
        }
    }
}

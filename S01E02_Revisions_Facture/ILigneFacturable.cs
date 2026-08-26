using System;
using System.Collections.Generic;
using System.Text;

namespace S01E02_Revisions_Facture
{
    public interface ILigneFacturable
    {
        public string Description { get; }
        public decimal Montant { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    public abstract class Commandes
    {
        private readonly string id;
        private readonly string dateCommande;
        private readonly string montant;

        public Commandes( string id, string dateCommande, string montant) 
        {
            this.id = id;
            this.dateCommande = dateCommande;
            this.montant = montant;

        }

        public string Id { get => id; } 
        public string DateCommande { get => dateCommande; }
        public string Montant { get => montant; }

    

    }
}

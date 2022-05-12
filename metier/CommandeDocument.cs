using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    public class CommandeDocument : Commandes
    {
        private readonly int nbExemplaire;
        private readonly string idStatut;
        private readonly string statut;
        private readonly string titre;
        private readonly string dateCommande;


        public CommandeDocument (int nbExemplaire, string id, string dateCommande, string montant, string idStatut, string statut, string idLivreDvd, string titre ) : base( id, dateCommande,  montant)
        {
            this.nbExemplaire = nbExemplaire;
            this.idStatut = idStatut;
            this.statut = statut;
            this.IdLivreDvd = idLivreDvd;
            this.titre = titre;
            this.dateCommande = dateCommande;




        }

        public int NbExemplaire { set;  get; }
        public string IdStatut { get => idStatut; }
        public string Statut { get => statut; }
        public string IdLivreDvd { set; get; }
        public string Titre { get => titre; }    
//     public string Genre { get => genre; }







    }
}

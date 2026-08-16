using System.Collections.Generic;

namespace GestionClubBasket
{
    public class Equipe
    {
        // Attributs
        private string nom;
        private string division;

        // Propriétés publiques
        public string Nom { get => nom; set => nom = value; }
        public string Division { get => division; set => division = value; }

        // Composition : une Equipe possède ses Joueurs (1..*)
        private List<Joueur> joueurs = new List<Joueur>();
        public List<Joueur> Joueurs => joueurs;

        // Association : une Equipe a un Entraineur (0..1)
        public Entraineur Entraineur { get; set; }

        // Comportements
        public void AjouterJoueur()
        {
            // TODO : logique à implémenter (ex. joueurs.Add(...))
        }
    }
}

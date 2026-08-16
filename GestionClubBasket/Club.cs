using System.Collections.Generic;

namespace GestionClubBasket
{
    public class Club
    {
        // Attributs
        private string nom;
        private string ville;
        private double budget;

        // Propriétés publiques
        public string Nom { get => nom; set => nom = value; }
        public string Ville { get => ville; set => ville = value; }
        public double Budget { get => budget; set => budget = value; }

        // Composition : un Club possède ses Equipes (0..*)
        private List<Equipe> equipes = new List<Equipe>();
        public List<Equipe> Equipes => equipes;

        // Association : un Club est financé par des Sponsors
        private List<Sponsor> sponsors = new List<Sponsor>();
        public List<Sponsor> Sponsors => sponsors;

        // Comportements
        public void AjouterEquipe(Equipe equipe)
        {
            // TODO : logique à implémenter (ex. equipes.Add(equipe))
        }

        public void AjouterSponsor()
        {
            // TODO : logique à implémenter
        }
    }
}

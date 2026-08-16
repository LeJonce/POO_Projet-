using System.Collections.Generic;

namespace GestionClubBasket
{
    public class Club
    {
        // 2. Attributs privés
        private string _nom;
        private string _ville;
        private double _budget;
        private List<Equipe> _equipes = new List<Equipe>();
        private List<Sponsor> _sponsors = new List<Sponsor>();

        // 3. Constructeur qui initialise les attributs
        public Club(string nom, string ville, double budget)
        {
            _nom = nom;
            _ville = ville;
            _budget = budget;
        }

        // 4. Propriétés en lecture seule
        public string Nom => _nom;
        public string Ville => _ville;
        public double Budget => _budget;

        // Composition : les listes elles-mêmes sont en lecture seule, leur
        // contenu se modifie via AjouterEquipe() / AjouterSponsor()
        public List<Equipe> Equipes => _equipes;
        public List<Sponsor> Sponsors => _sponsors;

        // 5. Squelette des méthodes — sans implémentation
        public void AjouterEquipe(Equipe equipe)
        {
            throw new System.NotImplementedException();
        }

        public void AjouterSponsor()
        {
            throw new System.NotImplementedException();
        }
    }
}

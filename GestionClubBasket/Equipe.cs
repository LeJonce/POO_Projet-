using System.Collections.Generic;

namespace GestionClubBasket
{
    public class Equipe
    {
        // 2. Attributs privés
        private string _nom;
        private string _division;
        private List<Joueur> _joueurs = new List<Joueur>();
        private Entraineur _entraineur;

        // 3. Constructeur qui initialise les attributs
        public Equipe(string nom, string division, Entraineur entraineur)
        {
            _nom = nom;
            _division = division;
            _entraineur = entraineur;
        }

        // 4. Propriétés en lecture seule
        public string Nom => _nom;
        public string Division => _division;
        public Entraineur Entraineur => _entraineur;

        // Composition : la liste elle-même est en lecture seule (pas de nouvelle liste
        // assignable de l'extérieur), mais son contenu se modifie via AjouterJoueur()
        public List<Joueur> Joueurs => _joueurs;

        // 5. Squelette des méthodes — sans implémentation
        public void AjouterJoueur()
        {
            throw new System.NotImplementedException();
        }
    }
}

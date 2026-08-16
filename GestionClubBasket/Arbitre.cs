namespace GestionClubBasket
{
    public class Arbitre : Personne
    {
        // 2. Attributs privés
        private string _niveau;
        private string _licence;

        // 3. Constructeur qui initialise les attributs (et ceux de Personne via base)
        public Arbitre(int id, string nom, string prenom, int age, string niveau, string licence)
            : base(id, nom, prenom, age)
        {
            _niveau = niveau;
            _licence = licence;
        }

        // 4. Propriétés en lecture seule
        public string Niveau => _niveau;
        public string Licence => _licence;

        // 5. Squelette des méthodes — sans implémentation
        public void Arbitrer()
        {
            throw new System.NotImplementedException();
        }

        public override string Role()
        {
            throw new System.NotImplementedException();
        }
    }
}

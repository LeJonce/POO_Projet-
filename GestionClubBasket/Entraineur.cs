namespace GestionClubBasket
{
    public class Entraineur : Personne
    {
        // 2. Attributs privés
        private int _experience;
        private string _licence;

        // 3. Constructeur qui initialise les attributs (et ceux de Personne via base)
        public Entraineur(int id, string nom, string prenom, int age, int experience, string licence)
            : base(id, nom, prenom, age)
        {
            _experience = experience;
            _licence = licence;
        }

        // 4. Propriétés en lecture seule
        public int Experience => _experience;
        public string Licence => _licence;

        // 5. Squelette des méthodes — sans implémentation
        public void Coacher()
        {
            throw new System.NotImplementedException();
        }

        public override string Role()
        {
            throw new System.NotImplementedException();
        }
    }
}

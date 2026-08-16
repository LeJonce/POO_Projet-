namespace GestionClubBasket
{
    public abstract class Personne
    {
        // 2. Attributs privés
        private int _id;
        private string _nom;
        private string _prenom;
        private int _age;

        // 3. Constructeur qui initialise les attributs
        protected Personne(int id, string nom, string prenom, int age)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _age = age;
        }

        // 4. Propriétés en lecture seule
        public int Id => _id;
        public string Nom => _nom;
        public string Prenom => _prenom;
        public int Age => _age;

        // 5. Méthode abstraite : chaque classe fille doit la redéfinir (polymorphisme)
        public abstract string Role();
    }
}

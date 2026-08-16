namespace GestionClubBasket
{
    public abstract class Personne
    {
        // Attributs
        private int id;
        private string nom;
        private string prenom;
        private int age;

        // Propriétés publiques
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }

        // Méthode abstraite : chaque classe fille doit la redéfinir (polymorphisme)
        public abstract string Role();
    }
}

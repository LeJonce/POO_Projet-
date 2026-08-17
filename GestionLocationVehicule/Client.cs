namespace GestionClubBasket
{
    public class Client
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private string _numeroPermis;

        public Client(int id, string nom, string prenom, string numeroPermis)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _numeroPermis = numeroPermis;
        }

        public int Id => _id;
        public string Nom => _nom;
        public string Prenom => _prenom;
        public string NumeroPermis => _numeroPermis;
    }
}

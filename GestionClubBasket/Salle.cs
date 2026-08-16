namespace GestionClubBasket
{
    public class Salle
    {
        // 2. Attributs privés
        private string _nom;
        private int _capacite;

        // 3. Constructeur qui initialise les attributs
        public Salle(string nom, int capacite)
        {
            _nom = nom;
            _capacite = capacite;
        }

        // 4. Propriétés en lecture seule
        public string Nom => _nom;
        public int Capacite => _capacite;
    }
}

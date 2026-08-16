namespace GestionClubBasket
{
    public class Sponsor
    {
        // 2. Attributs privés
        private string _nom;
        private double _montant;

        // 3. Constructeur qui initialise les attributs
        public Sponsor(string nom, double montant)
        {
            _nom = nom;
            _montant = montant;
        }

        // 4. Propriétés en lecture seule
        public string Nom => _nom;
        public double Montant => _montant;

        // 5. Squelette des méthodes — sans implémentation
        public void Financer()
        {
            throw new System.NotImplementedException();
        }
    }
}

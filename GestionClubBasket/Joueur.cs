namespace GestionClubBasket
{
    public class Joueur : Personne
    {
        // 2. Attributs privés
        private int _numero;
        private string _poste;

        // 3. Constructeur qui initialise les attributs (et ceux de Personne via base)
        public Joueur(int id, string nom, string prenom, int age, int numero, string poste)
            : base(id, nom, prenom, age)
        {
            _numero = numero;
            _poste = poste;
        }

        // 4. Propriétés en lecture seule
        public int Numero => _numero;
        public string Poste => _poste;

        // 5. Squelette des méthodes — sans implémentation
        public void Jouer()
        {
            throw new System.NotImplementedException();
        }

        public override string Role()
        {
            throw new System.NotImplementedException();
        }
    }
}

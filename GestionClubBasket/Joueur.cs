namespace GestionClubBasket
{
    public class Joueur : Personne
    {
        // Attributs
        private int numero;
        private string poste;

        // Propriétés publiques
        public int Numero { get => numero; set => numero = value; }
        public string Poste { get => poste; set => poste = value; }

        // Comportements
        public void Jouer()
        {
            // TODO : logique à implémenter
        }

        public override string Role()
        {
            // TODO : retourner "Joueur"
            throw new System.NotImplementedException();
        }
    }
}

namespace GestionClubBasket
{
    public class Entraineur : Personne
    {
        // Attributs
        private int experience;
        private string licence;

        // Propriétés publiques
        public int Experience { get => experience; set => experience = value; }
        public string Licence { get => licence; set => licence = value; }

        // Comportements
        public void Coacher()
        {
            // TODO : logique à implémenter
        }

        public override string Role()
        {
            // TODO : retourner "Entraineur"
            throw new System.NotImplementedException();
        }
    }
}

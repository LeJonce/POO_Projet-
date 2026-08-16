namespace GestionClubBasket
{
    public class Arbitre : Personne
    {
        // Attributs
        private string niveau;
        private string licence;

        // Propriétés publiques
        public string Niveau { get => niveau; set => niveau = value; }
        public string Licence { get => licence; set => licence = value; }

        // Comportements
        public void Arbitrer()
        {
            // TODO : logique à implémenter
        }

        public override string Role()
        {
            // TODO : retourner "Arbitre"
            throw new System.NotImplementedException();
        }
    }
}

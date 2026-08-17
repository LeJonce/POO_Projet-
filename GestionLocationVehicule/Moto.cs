namespace GestionClubBasket
{
    public class Moto : Vehicule
    {
        private int _cylindree;

        public Moto(string marque, string modele, string immatriculation, double tarifDeBase, int cylindree)
            : base(marque, modele, immatriculation, tarifDeBase)
        {
            _cylindree = cylindree;
        }

        public int Cylindree => _cylindree;

        public override double CalculerTarifJournalier()
        {
            // Une moto coûte moins cher à louer qu'une voiture (60% du tarif de base)
            return TarifDeBase * 0.6;
        }

        public override string Decrire()
        {
            return $"{Marque} {Modele}, {_cylindree}cm³";
        }
    }
}

namespace GestionClubBasket
{
    public class Voiture : Vehicule
    {
        private int _nombrePlaces;
        private string _typeCarburant;

        public Voiture(string marque, string modele, string immatriculation, double tarifDeBase, int nombrePlaces, string typeCarburant)
            : base(marque, modele, immatriculation, tarifDeBase)
        {
            _nombrePlaces = nombrePlaces;
            _typeCarburant = typeCarburant;
        }

        public int NombrePlaces => _nombrePlaces;
        public string TypeCarburant => _typeCarburant;

        public override double CalculerTarifJournalier()
        {
            // Petit supplément si le véhicule roule à l'électrique (plus cher à l'achat)
            double supplement = _typeCarburant.ToLower() == "electrique" ? 10 : 0;
            return TarifDeBase + supplement;
        }

        public override string Decrire()
        {
            return $"{Marque} {Modele}, {_nombrePlaces} places, {_typeCarburant}";
        }
    }
}

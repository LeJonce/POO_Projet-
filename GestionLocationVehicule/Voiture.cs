namespace GestionLocationVehicule
{
    // Limite le carburant aux 3 valeurs possibles, plutôt qu'un texte libre
    public enum TypeCarburant
    {
        Essence,
        Diesel,
        Electrique
    }

    public class Voiture : Vehicule
    {
        private int _nombrePlaces;
        private TypeCarburant _typeCarburant;

        public Voiture(string marque, string modele, string immatriculation, double tarifDeBase, int nombrePlaces, TypeCarburant typeCarburant)
            : base(marque, modele, immatriculation, tarifDeBase)
        {
            _nombrePlaces = nombrePlaces;
            _typeCarburant = typeCarburant;
        }

        public int NombrePlaces => _nombrePlaces;
        public TypeCarburant TypeCarburant => _typeCarburant;

        public override double CalculerTarifJournalier()
        {
            // Petit supplément si le véhicule roule à l'électrique (plus cher à l'achat)
            double supplement = _typeCarburant == TypeCarburant.Electrique ? 10 : 0;
            return TarifDeBase + supplement;
        }

        public override string Decrire()
        {
            return $"{Marque} {Modele}, {_nombrePlaces} places, {_typeCarburant}";
        }
    }
}

using System;

namespace GestionLocationVehicule
{
    public enum TypeVehicule
    {
        Voiture,
        Moto,
        Camion
    }

    // DESIGN PATTERN : Factory Method
    // -------------------------------
    // Justification : Vehicule a 3 sous-classes (Voiture, Moto, Camion) dont les
    // constructeurs ont des paramètres spécifiques différents (nombrePlaces/
    // typeCarburant, cylindree, capaciteChargement). Sans fabrique, le menu
    // (Program.cs) devrait connaître le détail de chaque constructeur et choisir
    // lui-même la bonne classe à instancier avec "new". La fabrique centralise ce
    // choix à un seul endroit : on lui donne un TypeVehicule, elle retourne le
    // Vehicule concret adéquat. Ajouter un futur type de véhicule ne changerait
    // que cette classe, jamais le code appelant (principe ouvert/fermé).
    public static class VehiculeFactory
    {
        public static Vehicule CreerVehicule(
            TypeVehicule type,
            string marque,
            string modele,
            string immatriculation,
            double tarifDeBase,
            string infoSpecifique1,
            string infoSpecifique2)
        {
            switch (type)
            {
                case TypeVehicule.Voiture:
                    TypeCarburant carburant = (TypeCarburant)Enum.Parse(typeof(TypeCarburant), infoSpecifique2);
                    return new Voiture(marque, modele, immatriculation, tarifDeBase,
                        int.Parse(infoSpecifique1), carburant);

                case TypeVehicule.Moto:
                    return new Moto(marque, modele, immatriculation, tarifDeBase,
                        int.Parse(infoSpecifique1));

                case TypeVehicule.Camion:
                    return new Camion(marque, modele, immatriculation, tarifDeBase,
                        double.Parse(infoSpecifique1));

                default:
                    throw new ArgumentException("Type de véhicule inconnu.");
            }
        }
    }
}
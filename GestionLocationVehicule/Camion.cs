using System;

namespace GestionLocationVehicule
{
    public class Camion : Vehicule
    {
        private double _capaciteChargement;
        private Chauffeur _chauffeur;

        public Camion(string marque, string modele, string immatriculation, double tarifDeBase, double capaciteChargement)
            : base(marque, modele, immatriculation, tarifDeBase)
        {
            _capaciteChargement = capaciteChargement;
            _chauffeur = null;
        }

        public double CapaciteChargement => _capaciteChargement;
        public Chauffeur Chauffeur => _chauffeur;

        public void AssignerChauffeur(Chauffeur chauffeur)
        {
            _chauffeur = chauffeur;
            Console.WriteLine($"{chauffeur.Prenom} {chauffeur.Nom} est assigné au camion {Immatriculation}.");
        }

        public override double CalculerTarifJournalier()
        {
            // Plus la capacité de chargement est grande, plus le tarif journalier augmente
            return TarifDeBase + (_capaciteChargement * 10);
        }

        public override string Decrire()
        {
            string nomChauffeur = _chauffeur != null ? $"{_chauffeur.Prenom} {_chauffeur.Nom}" : "aucun chauffeur assigné";
            return $"{Marque} {Modele}, {_capaciteChargement}t, chauffeur : {nomChauffeur}";
        }
    }
}

using System;

namespace GestionLocationVehicule
{
    public class Assurance
    {
        private string _type;
        private double _montantJournalier;

        public Assurance(string type, double montantJournalier)
        {
            _type = type;
            _montantJournalier = montantJournalier;
        }

        public string Type => _type;
        public double MontantJournalier => _montantJournalier;

        public void Souscrire()
        {
            Console.WriteLine($"  Assurance {_type} souscrite ({_montantJournalier}€/jour).");
        }
    }
}

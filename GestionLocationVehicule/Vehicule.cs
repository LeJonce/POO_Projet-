namespace GestionLocationVehicule
{
    public class Vehicule
    {
        private string _marque;
        private string _modele;
        private string _immatriculation;
        private double _tarifDeBase;
        private bool _disponible;

        public Vehicule(string marque, string modele, string immatriculation, double tarifDeBase)
        {
            _marque = marque;
            _modele = modele;
            _immatriculation = immatriculation;
            _tarifDeBase = tarifDeBase;
            _disponible = true;
        }

        public string Marque => _marque;
        public string Modele => _modele;
        public string Immatriculation => _immatriculation;
        public double TarifDeBase => _tarifDeBase;
        public bool Disponible => _disponible;

        public void MarquerLoue() => _disponible = false;
        public void MarquerDisponible() => _disponible = true;

        // Comportements par défaut, redéfinis (override) par Voiture/Moto/Camion
        // -> deux points de polymorphisme réel, tous les deux utilisés par le menu
        public virtual double CalculerTarifJournalier()
        {
            return _tarifDeBase;
        }

        public virtual string Decrire()
        {
            return $"{_marque} {_modele} ({_immatriculation})";
        }
    }
}

using System;

namespace GestionClubBasket
{
    public class Location
    {
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private double _prixTotal;
        private Vehicule _vehicule;
        private Client _client;
        private Assurance _assurance;
        private bool _terminee;

        public Location(DateTime dateDebut, DateTime dateFin, Vehicule vehicule, Client client, Assurance assurance)
        {
            _dateDebut = dateDebut;
            _dateFin = dateFin;
            _vehicule = vehicule;
            _client = client;
            _assurance = assurance;
            _prixTotal = 0;
            _terminee = false;
        }

        public DateTime DateDebut => _dateDebut;
        public DateTime DateFin => _dateFin;
        public double PrixTotal => _prixTotal;
        public Vehicule Vehicule => _vehicule;
        public Client Client => _client;
        public Assurance Assurance => _assurance;
        public bool Terminee => _terminee;

        // Calcule le prix total : nombre de jours x tarif du véhicule (polymorphique)
        // + éventuellement l'assurance
        public void CalculerPrix()
        {
            int jours = Math.Max(1, (_dateFin - _dateDebut).Days);
            double prix = jours * _vehicule.CalculerTarifJournalier();
            if (_assurance != null)
            {
                prix += jours * _assurance.MontantJournalier;
            }
            _prixTotal = prix;
        }

        public void TerminerLocation()
        {
            CalculerPrix();
            _vehicule.MarquerDisponible();
            _terminee = true;
            Console.WriteLine($"Location terminée : {_vehicule.Decrire()} rendu par {_client.Prenom} {_client.Nom}. Total : {_prixTotal}€");
        }
    }
}

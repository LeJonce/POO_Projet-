using System;

namespace GestionLocationVehicule
{
    public class Chauffeur
    {
        private string _nom;
        private string _prenom;
        private bool _permisPoidsLourd;

        public Chauffeur(string nom, string prenom, bool permisPoidsLourd)
        {
            _nom = nom;
            _prenom = prenom;
            _permisPoidsLourd = permisPoidsLourd;
        }

        public string Nom => _nom;
        public string Prenom => _prenom;
        public bool PermisPoidsLourd => _permisPoidsLourd;

        public void Conduire()
        {
            Console.WriteLine($"  {_prenom} {_nom} prend le volant.");
        }
    }
}

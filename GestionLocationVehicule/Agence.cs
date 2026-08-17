using System;
using System.Collections.Generic;

namespace GestionLocationVehicule
{
    public class Agence
    {
        private string _nom;
        private string _ville;
        private List<Vehicule> _parc = new List<Vehicule>();

        public Agence(string nom, string ville)
        {
            _nom = nom;
            _ville = ville;
        }

        public string Nom => _nom;
        public string Ville => _ville;
        public List<Vehicule> Parc => _parc;

        public void AjouterVehicule(Vehicule vehicule)
        {
            _parc.Add(vehicule);
            Console.WriteLine($"{vehicule.Decrire()} ajouté au parc de {_nom}.");
        }
    }
}
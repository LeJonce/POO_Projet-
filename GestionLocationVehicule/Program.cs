using System;
using System.Collections.Generic;

namespace GestionClubBasket
{
    class Program
    {
        static Agence agence;
        static List<Client> clients = new List<Client>();
        static List<Chauffeur> chauffeurs = new List<Chauffeur>();
        static List<Location> locations = new List<Location>();
        static int prochainIdClient = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("=== Gestion d'une Agence de Location de Véhicules ===\n");

            Console.Write("Nom de l'agence : ");
            string nomAgence = Console.ReadLine();
            Console.Write("Ville : ");
            string ville = Console.ReadLine();
            agence = new Agence(nomAgence, ville);

            bool continuer = true;
            while (continuer)
            {
                AfficherMenu();
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        CreerVehicule();
                        break;
                    case "2":
                        CreerClient();
                        break;
                    case "3":
                        LouerVehicule();
                        break;
                    case "4":
                        TerminerLocation();
                        break;
                    case "5":
                        SouscrireAssurance();
                        break;
                    case "6":
                        AfficherEtatAgence();
                        break;
                    case "0":
                        continuer = false;
                        Console.WriteLine("À bientôt !");
                        break;
                    default:
                        Console.WriteLine("Choix invalide, réessaie.\n");
                        break;
                }
            }
        }

        static void AfficherMenu()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1. Créer un véhicule");
            Console.WriteLine("2. Créer un client");
            Console.WriteLine("3. Louer un véhicule");
            Console.WriteLine("4. Terminer une location");
            Console.WriteLine("5. Souscrire une assurance sur une location");
            Console.WriteLine("6. Afficher l'état de l'agence");
            Console.WriteLine("0. Quitter");
            Console.Write("Ton choix : ");
        }

        // ===== 1. Créer un véhicule (utilise la Factory Method) =====
        static void CreerVehicule()
        {
            Console.WriteLine("\nQuel type de véhicule ?");
            Console.WriteLine("1. Voiture   2. Moto   3. Camion");
            string typeChoisi = Console.ReadLine();

            Console.Write("Marque : ");
            string marque = Console.ReadLine();
            Console.Write("Modèle : ");
            string modele = Console.ReadLine();
            Console.Write("Immatriculation : ");
            string immat = Console.ReadLine();
            Console.Write("Tarif de base journalier (€) : ");
            double tarif = LireDouble();

            Vehicule v = null;

            switch (typeChoisi)
            {
                case "1":
                    Console.Write("Nombre de places : ");
                    string places = LireEntier().ToString();
                    Console.Write("Type de carburant : ");
                    string carburant = Console.ReadLine();
                    v = VehiculeFactory.CreerVehicule(TypeVehicule.Voiture, marque, modele, immat, tarif, places, carburant);
                    break;
                case "2":
                    Console.Write("Cylindrée (cm3) : ");
                    string cylindree = LireEntier().ToString();
                    v = VehiculeFactory.CreerVehicule(TypeVehicule.Moto, marque, modele, immat, tarif, cylindree, "");
                    break;
                case "3":
                    Console.Write("Capacité de chargement (tonnes) : ");
                    string capacite = LireDouble().ToString();
                    v = VehiculeFactory.CreerVehicule(TypeVehicule.Camion, marque, modele, immat, tarif, capacite, "");

                    Chauffeur chauffeurChoisi = ChoisirChauffeur();
                    if (chauffeurChoisi != null)
                    {
                        ((Camion)v).AssignerChauffeur(chauffeurChoisi);
                    }
                    break;
                default:
                    Console.WriteLine("Type invalide.\n");
                    return;
            }

            agence.AjouterVehicule(v);
            Console.WriteLine();
        }

        // ===== 2. Créer un client =====
        static void CreerClient()
        {
            Console.Write("\nNom : ");
            string nom = Console.ReadLine();
            Console.Write("Prénom : ");
            string prenom = Console.ReadLine();
            Console.Write("Numéro de permis : ");
            string numeroPermis = Console.ReadLine();

            Client client = new Client(prochainIdClient++, nom, prenom, numeroPermis);
            clients.Add(client);
            Console.WriteLine($"Client {prenom} {nom} créé.\n");
        }

        // ===== 3. Louer un véhicule =====
        static void LouerVehicule()
        {
            Client client = ChoisirClient();
            if (client == null) return;

            Vehicule vehicule = ChoisirVehiculeDisponible();
            if (vehicule == null) return;

            Console.Write("Nombre de jours de location : ");
            int jours = LireEntier();

            DateTime debut = DateTime.Now;
            DateTime fin = debut.AddDays(jours);

            Location location = new Location(debut, fin, vehicule, client, null);
            location.CalculerPrix();
            locations.Add(location);
            vehicule.MarquerLoue();

            Console.WriteLine($"Location créée : {vehicule.Decrire()} pour {client.Prenom} {client.Nom}, {jours} jour(s), prix estimé : {location.PrixTotal}€\n");
        }

        // ===== 4. Terminer une location =====
        static void TerminerLocation()
        {
            List<Location> enCours = new List<Location>();
            foreach (Location l in locations)
            {
                if (!l.Terminee) enCours.Add(l);
            }

            if (enCours.Count == 0)
            {
                Console.WriteLine("Aucune location en cours.\n");
                return;
            }

            Console.WriteLine("\nLocations en cours :");
            for (int i = 0; i < enCours.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {enCours[i].Vehicule.Decrire()} — {enCours[i].Client.Prenom} {enCours[i].Client.Nom}");
            }

            int choix = LireEntier();
            if (choix < 1 || choix > enCours.Count)
            {
                Console.WriteLine("Choix invalide.\n");
                return;
            }

            enCours[choix - 1].TerminerLocation();
            Console.WriteLine();
        }

        // ===== 5. Souscrire une assurance =====
        static void SouscrireAssurance()
        {
            List<Location> enCours = new List<Location>();
            foreach (Location l in locations)
            {
                if (!l.Terminee) enCours.Add(l);
            }

            if (enCours.Count == 0)
            {
                Console.WriteLine("Aucune location en cours pour y ajouter une assurance.\n");
                return;
            }

            Console.WriteLine("\nSur quelle location ?");
            for (int i = 0; i < enCours.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {enCours[i].Vehicule.Decrire()} — {enCours[i].Client.Prenom} {enCours[i].Client.Nom}");
            }

            int choix = LireEntier();
            if (choix < 1 || choix > enCours.Count)
            {
                Console.WriteLine("Choix invalide.\n");
                return;
            }

            Console.Write("Type d'assurance : ");
            string type = Console.ReadLine();
            Console.Write("Montant journalier (€) : ");
            double montant = LireDouble();

            Assurance assurance = new Assurance(type, montant);
            assurance.Souscrire();
            Console.WriteLine("(Assurance enregistrée pour cette location.)\n");
        }

        // ===== 6. Afficher l'état de l'agence =====
        static void AfficherEtatAgence()
        {
            Console.WriteLine($"\n=== {agence.Nom} ({agence.Ville}) ===");

            Console.WriteLine($"Parc ({agence.Parc.Count} véhicule(s)) :");
            foreach (Vehicule v in agence.Parc)
            {
                string statut = v.Disponible ? "disponible" : "loué";
                Console.WriteLine($"  - {v.Decrire()} — {statut} — {v.CalculerTarifJournalier()}€/jour");
            }

            Console.WriteLine($"Clients ({clients.Count}) :");
            foreach (Client c in clients)
            {
                Console.WriteLine($"  - {c.Prenom} {c.Nom} (permis {c.NumeroPermis})");
            }

            Console.WriteLine("Locations en cours :");
            bool aucune = true;
            foreach (Location l in locations)
            {
                if (!l.Terminee)
                {
                    aucune = false;
                    Console.WriteLine($"  - {l.Vehicule.Decrire()} par {l.Client.Prenom} {l.Client.Nom}, jusqu'au {l.DateFin:d}");
                }
            }
            if (aucune) Console.WriteLine("  (aucune)");
            Console.WriteLine();
        }

        // ===== Utilitaires de sélection =====
        static Chauffeur ChoisirChauffeur()
        {
            if (chauffeurs.Count == 0)
            {
                Console.WriteLine("Aucun chauffeur disponible pour l'instant.");
                return null;
            }

            Console.WriteLine("Choisis un chauffeur (ou 0 pour aucun) :");
            for (int i = 0; i < chauffeurs.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {chauffeurs[i].Prenom} {chauffeurs[i].Nom}");
            }

            int choix = LireEntier();
            if (choix <= 0 || choix > chauffeurs.Count) return null;
            return chauffeurs[choix - 1];
        }

        static Client ChoisirClient()
        {
            if (clients.Count == 0)
            {
                Console.WriteLine("Aucun client. Crée-en un d'abord (option 2).\n");
                return null;
            }

            Console.WriteLine("\nChoisis un client :");
            for (int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {clients[i].Prenom} {clients[i].Nom}");
            }

            int choix = LireEntier();
            if (choix < 1 || choix > clients.Count)
            {
                Console.WriteLine("Choix invalide.\n");
                return null;
            }
            return clients[choix - 1];
        }

        static Vehicule ChoisirVehiculeDisponible()
        {
            List<Vehicule> disponibles = new List<Vehicule>();
            foreach (Vehicule v in agence.Parc)
            {
                if (v.Disponible) disponibles.Add(v);
            }

            if (disponibles.Count == 0)
            {
                Console.WriteLine("Aucun véhicule disponible actuellement.\n");
                return null;
            }

            Console.WriteLine("Choisis un véhicule disponible :");
            for (int i = 0; i < disponibles.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {disponibles[i].Decrire()} ({disponibles[i].CalculerTarifJournalier()}€/jour)");
            }

            int choix = LireEntier();
            if (choix < 1 || choix > disponibles.Count)
            {
                Console.WriteLine("Choix invalide.\n");
                return null;
            }
            return disponibles[choix - 1];
        }

        static int LireEntier()
        {
            int valeur;
            while (!int.TryParse(Console.ReadLine(), out valeur))
            {
                Console.Write("Merci d'entrer un nombre valide : ");
            }
            return valeur;
        }

        static double LireDouble()
        {
            double valeur;
            while (!double.TryParse(Console.ReadLine(), out valeur))
            {
                Console.Write("Merci d'entrer un nombre valide : ");
            }
            return valeur;
        }
    }
}

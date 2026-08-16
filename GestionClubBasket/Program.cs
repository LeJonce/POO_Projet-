using System;

namespace GestionClubBasket
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== 1. JOUEUR =====
            // Tout se passe maintenant dans le constructeur : id, nom, prenom, age (hérités
            // de Personne), puis numero, poste (propres à Joueur)
            Joueur joueur1 = new Joueur(1, "Diop", "Amara", 22, 23, "Meneur");

            Console.WriteLine("=== Joueur ===");
            Console.WriteLine($"{joueur1.Prenom} {joueur1.Nom}, #{joueur1.Numero}, poste : {joueur1.Poste}, {joueur1.Age} ans");
            Console.WriteLine();

            // ===== 2. ENTRAINEUR =====
            Entraineur entraineur1 = new Entraineur(2, "Martin", "Julien", 45, 12, "UEFA Pro Basket");

            Console.WriteLine("=== Entraineur ===");
            Console.WriteLine($"{entraineur1.Prenom} {entraineur1.Nom}, {entraineur1.Experience} ans d'expérience, licence : {entraineur1.Licence}");
            Console.WriteLine();

            // ===== 3. ARBITRE =====
            Arbitre arbitre1 = new Arbitre(3, "Lopez", "Carla", 38, "National", "FIBA-2024");

            Console.WriteLine("=== Arbitre ===");
            Console.WriteLine($"{arbitre1.Prenom} {arbitre1.Nom}, niveau : {arbitre1.Niveau}, licence : {arbitre1.Licence}");
            Console.WriteLine();

            // ===== 4. EQUIPE =====
            // nom, division et entraineur passent par le constructeur ; les joueurs
            // s'ajoutent ensuite dans la liste (composition)
            Equipe equipe1 = new Equipe("Les Aigles", "Nationale 1", entraineur1);
            equipe1.Joueurs.Add(joueur1);

            Console.WriteLine("=== Equipe ===");
            Console.WriteLine($"{equipe1.Nom} ({equipe1.Division}), entraînée par {equipe1.Entraineur.Prenom} {equipe1.Entraineur.Nom}");
            Console.WriteLine($"Effectif : {equipe1.Joueurs.Count} joueur(s)");
            Console.WriteLine();

            // ===== 5. CLUB =====
            Club club1 = new Club("Basket Club Nivelles", "Nivelles", 50000);
            club1.Equipes.Add(equipe1);

            Console.WriteLine("=== Club ===");
            Console.WriteLine($"{club1.Nom} ({club1.Ville}), budget : {club1.Budget}€");
            Console.WriteLine($"Nombre d'équipes : {club1.Equipes.Count}");
            Console.WriteLine();

            // ===== 6. SPONSOR =====
            Sponsor sponsor1 = new Sponsor("SportPlus", 5000);
            club1.Sponsors.Add(sponsor1);

            Console.WriteLine("=== Sponsor ===");
            Console.WriteLine($"{sponsor1.Nom} finance {club1.Nom} à hauteur de {sponsor1.Montant}€");
            Console.WriteLine();

            // ===== 7. SALLE =====
            Salle salle1 = new Salle("Complexe Sportif de Nivelles", 800);

            Console.WriteLine("=== Salle ===");
            Console.WriteLine($"{salle1.Nom}, capacité : {salle1.Capacite} places");
            Console.WriteLine();

            // ===== 8. MATCH =====
            Equipe equipe2 = new Equipe("Les Lions", "Nationale 1", null);

            Match match1 = new Match(DateTime.Now, "0-0", equipe1, equipe2, arbitre1, salle1);

            Console.WriteLine("=== Match ===");
            Console.WriteLine($"{match1.EquipeDomicile.Nom} vs {match1.EquipeVisiteur.Nom}");
            Console.WriteLine($"Le {match1.Date}, à la salle {match1.Salle.Nom}");
            Console.WriteLine($"Arbitré par {match1.Arbitre.Prenom} {match1.Arbitre.Nom}");
            Console.WriteLine($"Score : {match1.Score}");
            Console.WriteLine();

            Console.WriteLine("=== Fin du test : toutes les classes ont été créées avec succès ===");

            // NOTE : on n'appelle volontairement PAS les méthodes comme
            // joueur1.Jouer(), match1.Jouer(), joueur1.Role(), club1.AjouterEquipe(...)
            // car elles sont encore vides (throw new NotImplementedException())
            // et feraient planter le programme. Ce sera à coder à l'étape suivante.
        }
    }
}

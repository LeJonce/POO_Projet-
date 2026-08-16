using System;

namespace GestionClubBasket
{
    public class Match
    {
        // Attributs
        private DateTime date;
        private string score;

        // Propriétés publiques
        public DateTime Date { get => date; set => date = value; }
        public string Score { get => score; set => score = value; }

        // Associations : un Match implique 2 Equipes
        public Equipe EquipeDomicile { get; set; }
        public Equipe EquipeVisiteur { get; set; }

        // Association : un Match est dirigé par un Arbitre
        public Arbitre Arbitre { get; set; }

        // Association : un Match se joue dans une Salle
        public Salle Salle { get; set; }

        // Comportements
        public void Jouer()
        {
            // TODO : logique à implémenter
        }

        public void DefinirScore()
        {
            // TODO : logique à implémenter
        }
    }
}

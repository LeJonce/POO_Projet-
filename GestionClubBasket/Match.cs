using System;

namespace GestionClubBasket
{
    public class Match
    {
        // 2. Attributs privés
        private DateTime _date;
        private string _score;
        private Equipe _equipeDomicile;
        private Equipe _equipeVisiteur;
        private Arbitre _arbitre;
        private Salle _salle;

        // 3. Constructeur qui initialise les attributs
        public Match(DateTime date, string score, Equipe equipeDomicile, Equipe equipeVisiteur, Arbitre arbitre, Salle salle)
        {
            _date = date;
            _score = score;
            _equipeDomicile = equipeDomicile;
            _equipeVisiteur = equipeVisiteur;
            _arbitre = arbitre;
            _salle = salle;
        }

        // 4. Propriétés en lecture seule
        public DateTime Date => _date;
        public string Score => _score;
        public Equipe EquipeDomicile => _equipeDomicile;
        public Equipe EquipeVisiteur => _equipeVisiteur;
        public Arbitre Arbitre => _arbitre;
        public Salle Salle => _salle;

        // 5. Squelette des méthodes — sans implémentation
        public void Jouer()
        {
            throw new NotImplementedException();
        }

        public void DefinirScore()
        {
            throw new NotImplementedException();
        }
    }
}

# Projet C#
## Étape 2 — Liste des entités

| Entité       | Attributs                                      | Comportements                |
|-------------|-----------------------------------------------|------------------------------|
| Personne    | id:int, nom:string, prenom:string, age:int     | SePresenter()                |
| Joueur      | numero:int, poste:string                       | Jouer()                      |
| Entraineur  | experience:int, licence:string                 | Coacher()                    |
| Arbitre     | niveau:string, licence:string                  | Arbitrer()                   |
| Club        | nom:string, ville:string, budget:double        | AjouterEquipe(equipe:Equipe) |
| Equipe      | nom:string, division:string                    | AjouterJoueur()              |
| Match       | date:DateTime, score:string, adversaire:string | Jouer()                      |
| Salle       | nom:string, capacite:int                       | Ouvrir()                     |
| Sponsor     | nom:string, montant:double                     | Jouer()                      |

---

## Étape 3 — Relations

| Classe A   | Relation        | Classe B   | Justification                              |
|------------|----------------|------------|--------------------------------------------|
| Joueur     | hérite de      | Personne   | Un joueur est une personne                 |
| Entraineur | hérite de      | Personne   | Un entraîneur est une personne             |
| Arbitre    | hérite de      | Personne   | Un arbitre est une personne                |
| Club       | possède        | Equipe     | Un club contient des équipes               |
| Club       | associe        | Joueur     | Un club regroupe des joueurs               |
| Club       | associe        | Entraineur | Un club a des entraîneurs                  |
| Club       | associe        | Arbitre    | Un club peut inclure des arbitres          |
| Equipe     | participe à    | Match      | Une équipe joue des matchs                 |
| Match      | se joue dans   | Salle      | Un match se déroule dans une salle         |
| Sponsor    | finance        | Club       | Un sponsor finance un club                 |
| Sponsor    | associe        | Match      | Un sponsor peut être lié à un match        |

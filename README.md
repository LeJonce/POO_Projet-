# Projet C#
## Liste des entités

| Entité       | Attributs                                      | Comportements                |
|-------------|-----------------------------------------------|------------------------------|
| Personne    | id, nom, prenom, age     | SePresenter()                |
| Joueur      | numero, poste                       | Jouer()                      |
| Entraineur  | experience, licence                | Coacher()                    |
| Arbitre     | niveau, licence                 | Arbitrer()                   |
| Club        | nom, ville, budget        | AjouterEquipe(equipe: Equipe) |
| Equipe      | nom, division                   | AjouterJoueur()              |
| Match       | date, score, adversaire | Jouer()                      |
| Salle       | nom, capacite                     | Ouvrir()                     |


---

## Relations

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
| Match      | se joue dans   | Salle      | Un match se déroule dans une salle         |      |

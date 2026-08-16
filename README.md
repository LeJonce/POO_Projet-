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

### Héritage

- Joueur hérite de Personne  
- Entraineur hérite de Personne  
- Arbitre hérite de Personne  

### Associations

- Club possède une Equipe  
- Equipe possède des Joueurs  
- Equipe possède un Entraineur  
- Match implique une Equipe  
- Match se joue dans une Salle  
 
 ## Tableau des relations

| Classe A   | Relation        | Classe B   | Justification                              |
|------------|----------------|------------|--------------------------------------------|
| Joueur     | hérite de      | Personne   | Un joueur est une personne                 |
| Entraineur | hérite de      | Personne   | Un entraîneur est une personne             |
| Arbitre    | hérite de      | Personne   | Un arbitre est une personne                |
| Club       | possède        | Equipe     | Un club contient une ou plusieurs équipes  |
| Equipe     | possède        | Joueur     | Une équipe regroupe des joueurs            |
| Equipe     | possède        | Entraineur | Une équipe a un entraîneur                 |
| Equipe     | participe à    | Match      | Une équipe joue des matchs                 |
| Match      | associe        | Arbitre    | Un match est arbitré                       |
| Match      | se joue dans   | Salle      | Un match se déroule dans une salle         |      | 

## Schéma UML 
<img width="1160" height="1220" alt="diagramme_uml_club_basket" src="https://github.com/user-attachments/assets/aafb02ab-edb8-44be-8b83-e168c7a10ea0" />



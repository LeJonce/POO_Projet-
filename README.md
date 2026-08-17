# Projet C#
## Liste des entités

|## Liste des entités

| Entité    | Attributs                                    | Comportements              |
|-----------|-----------------------------------------------|-----------------------------|
| Vehicule  | marque, modele, immatriculation, tarifDeBase   | CalculerTarifJournalier()  |
| Voiture   | nombrePlaces, typeCarburant                    | Demarrer()                 |
| Moto      | cylindree                                      | Demarrer()                 |
| Camion    | capaciteChargement                             | AssignerChauffeur()        |
| Chauffeur | nom, prenom, permisPoidsLourd                  | Conduire()                 |
| Client    | id, nom, prenom, numeroPermis                  | —                           |
| Assurance | type, montantJournalier                        | Souscrire()                |
| Location  | dateDebut, dateFin, prixTotal                  | CalculerPrix(), TerminerLocation() |
| Agence    | nom, ville                                     | AjouterVehicule()          |

### Héritage

- Voiture hérite de Vehicule
- Moto hérite de Vehicule
- Camion hérite de Vehicule

### Associations

- Agence possède des Vehicule
- Camion associe un Chauffeur
- Location associe un Vehicule
- Location associe un Client
- Location associe une Assurance
 
 ## Tableau des relations

| Classe A   | Relation        | Classe B   | Justification                              |
|------------|----------------|------------|--------------------------------------------|
| Voiture     | hérite de      | Vehicule   | Une voiture est un véhicule          |
| Entraineur | hérite de      | Personne   | Une moto est un véhicule              |
| Arbitre    | hérite de      | Personne   | Un arbitre est une personne                |
| Club       | possède        | Equipe     | Un club contient une ou plusieurs équipes  |
| Equipe     | possède        | Joueur     | Une équipe regroupe des joueurs            |
| Equipe     | possède        | Entraineur | Une équipe a un entraîneur                 |
| Equipe     | participe à    | Match      | Une équipe joue des matchs                 |
| Match      | associe        | Arbitre    | Un match est arbitré                       |
| Match      | se joue dans   | Salle      | Un match se déroule dans une salle         |      | 

## Schéma UML 
<img width="1160" height="1220" alt="diagramme_uml_club_basket" src="https://github.com/user-attachments/assets/aafb02ab-edb8-44be-8b83-e168c7a10ea0" />



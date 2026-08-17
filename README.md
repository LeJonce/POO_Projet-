# Projet C#
## Liste des entités

|## Liste des entités

| Entité    | Attributs                                    | Comportements              |
|-----------|-----------------------------------------------|-----------------------------|
| Vehicule  | marque, modele, immatriculation, tarifDeBase   | CalculerTarifJournalier()  |
| Voiture   | nombrePlaces, typeCarburant                    | Decrire()                 |
| Moto      | cylindree                                      | Decrire()                 |
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

## Tableau des relations

| Classe A | Relation  | Classe B  | Justification                                  |
|----------|-----------|-----------|-------------------------------------------------|
| Voiture  | hérite de | Vehicule  | Une voiture est un véhicule                     |
| Moto     | hérite de | Vehicule  | Une moto est un véhicule                        |
| Camion   | hérite de | Vehicule  | Un camion est un véhicule                       |
| Agence   | possède   | Vehicule  | Une agence gère un parc de véhicules            |
| Camion   | associe   | Chauffeur | Un camion nécessite un chauffeur professionnel  |
| Location | associe   | Vehicule  | Une location porte sur un véhicule              |
| Location | associe   | Client    | Une location est faite par un client            |
| Location | associe   | Assurance | Une location peut inclure une assurance         |
## Schéma UML 



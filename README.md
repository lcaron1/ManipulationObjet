# ManipulationObjet
[toc]
Présentation du projet: le but est de réaliser un jeu de rôle permettant un jeu massivement multi joueur permettant,aux
étudiants du bts sio de se divertir pendant les heures de cantine mais surtout d'améliorer leurs compétences en 
déveleppement.

Les outils mes en oeuvre :

* git.
* Visual studio.
* mysql.
* apache.

le développement  tourne autour de 3 grandes parties

1.l'inscription en ligne
2.développement du jeu en lui même permettant l'exploration d'un labyrinthe
3.la sauvegrade des personnages et du contexte du jeu

|**développement**|**langages**|**technique de programmation**|
|-----------------|------------|------------------------------|
|inscription en ligne|php, Mysql|developpemnt web MVC avec code igniter|
|sio crawler le jeu|C#|programmation objet, tests unitaires|
|sauvegarde du contexte|C#,mysql|programmation procédural procédures stockées en mysql|

## L'inscription en ligne. ##

site web permettant à un joueur de s'inscrire en ligne le projet prévoit le principe suivant pour l'inscription en ligne

![acteurFluxInscription.png](http://image.noelshack.com/fichiers/2018/37/3/1536761964-acteurfluxinscription.png)

## sio crawler le jeu ##

le joueur possèdera les fonctionnalités suivantes.
![useCasePersonnage.png](https://image.noelshack.com/fichiers/2018/37/3/1536762099-usecasepersonnage.png)

les classes développées.

![diagrammeClassePersonnage.png](http://image.noelshack.com/fichiers/2018/37/3/1536762094-diagrammeclassepersonnage.png)

## Sauvegarde du contexte ##

La sauvegarde du contexte se fera dans la base de données.
![mcdSauvegarde.png](http://image.noelshack.com/fichiers/2018/37/3/1536762097-mcdsauvegarde.png)

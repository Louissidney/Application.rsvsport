
Application rvsport app crypto:

Application éducative moderne sous Electron, conçue pour motiver l’apprentissage par un système de points et d’interaction avec des activités externes (ex. réservations sportives).
Objectif : rendre l’éducation plus engageante, concrète et connectée à la vie réelle.

⸻

Fonctionnalités principales
• Système de connexion sécurisé (auth déjà intégrée)
• Tableau de bord personnalisé avec progression, récompenses et contenu à débloquer
• Système de points :
• Gagnés via des modules éducatifs ou des réservations sur un site partenaire
• Modules éducatifs interactifs (textes, quiz, défis à compléter)
• Historique de progression par utilisateur
• Notifications discrètes et gratifiantes (type “point gagné”, “contenu débloqué”)

⸻

Objectifs
• Rendre l’apprentissage addictif et gratifiant
• Créer un lien entre apprentissage numérique et activités physiques
• Offrir un espace personnel d’évolution

⸻

Stack technique
• Frontend/Backend : Electron + React (ou vanilla JS selon ton avancement)
• Base de données : SQLite / Firebase / autre (à préciser selon ton choix)
• Intégration externe : API du site de réservation (manuelle ou automatisée ?)
• Notifications locales (Electron)
• Système de fichiers local pour persistance si pas encore connecté à une BDD

L'executable se trouve dans le fichier /src/bin/x64/rsvsport/net6.0-windows/rsvsport_logiciel.exe


Prérequis
--------------
 Packages :

 - DB Browser SQLITE
 - npm
 - Git
 - node.js
 - System.Security.Cryptography.Cng 5.0.0

Compilation
-------------

Installation paquet
 
  - apt install Apache2 php mariadb-server

Suite compilation

  - npm install (installe les dépendances)
  - npm start (lance le projet en mode dev)
  - npm run logs (remettre a zero app supprimee les info dans la bdd)
    

Import de la base de donnée

  - DB Browser > create database 
  - SQlite < C:\Users\Louis\CryptoAPP\database
  
Connexion à la base de donnée 

services/db.js.
  

  Lancer la compilation via npm start

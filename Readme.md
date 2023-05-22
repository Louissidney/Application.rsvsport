
Reservation de Salles
======================

Application lourdes dans le but de fournir aux administrateurs une gestion de réservation de salle.
Les sport proposés sont le tennis, le rugby et le foot.

L'executable se trouve dans le fichier /src/bin/x64/rsvsport/net6.0-windows/rsvsport_logiciel.exe


Prérequis
--------------
 Packages :

 - MySql.Data 8.0.33
 - System.Security.Cryptography.Algorithms 4.3.1
 - System.Security.Cryptography.Cng 5.0.0

Nécessite l'installation d'une base de donnée via l'application web :
https://github.com/gilbertenzo/Web_Rsvsport


  
Compilation
-------------

Installation paquet
 
  - apt install Apache2 php mariadb-server

Import de la base de donnée

  - mysql> create database rsvsport
  - mysql -b rsvsport < doc/rsvsport.sql
  
Connexion à la base de donnée 

  Renommer tous les ficher *.cs.exmaple  en *.cs .
  
  Et indiquer les informations de connextion à la base de donnée dans ses fichiers *.cs 

  Lancer la compilation via Visual Studio 2022.

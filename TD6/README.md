Author : Berro Andréa

# Rendu Serveur SOAP ET REST  
  
Le rendu est disponible dans "Rendu_Final".  
Il est séparé en trois projets différents :  
- MathsLibrarySOAP
- MathsLibraryREST
- ClientSOAP
  
Quand on lance la solution de "Rendu_Final" les trois projets sont lancés en même temps.  
Une fois le ClientSOAP fermé les serveurs se ferment aussi (donc il faut laisser le client ouvert pour tester le serveur REST).  
Les projets peuvent etre lancés individuellement a partir des solutions dans "src".

## Partie SOAP  
MathsLibrarySOAP est un serveur SOAP qui permet de faire des opérations mathématiques.  
Le ClientSOAP est un client SOAP qui permet de tester le serveur SOAP.  
Le serveur SOAP doit etre lancé avant le ClientSOAP.  

## Partie REST
MathsLibraryREST est un serveur REST qui permet de faire des opérations mathématiques (même méthodes chose que SOAP).  
  
Les routes GET pour tester le serveur REST sont:  
- http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/Add?a=1&b=2  
- http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/Sub?a=4&b=3  
- http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/Mult?a=2&b=2  
Author : Berro Andréa

## Rendu Serveur SOAP ET REST  
  
Le rendu est séparé en trois solutions différentes :  
- MathsLibrairySOAP
- MathsLibrairyREST
- ClientSOAP

# Partie SOAP  
MathsLibrarySOAP est un serveur SOAP qui permet de faire des opérations mathématiques.  
Le clientSOAP est un client SOAP qui permet de test le serveur SOAP.  
Le serveur SOAP doit etre lancé avant le clientSOAP.  

# Partie REST
MathsLibraryREST est un serveur REST qui permet de faire des opérations mathématiques (meme chose que SOAP).  
  
Les routes get pour tester le serveur REST sont:  
- http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/Add?a=1&b=2  
- http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/Sub?a=4&b=3  
- http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/Mult?a=2&b=2  
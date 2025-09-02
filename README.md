# AutomateS

Projet réalisé dans le cadre du cours **Mathématiques pour informaticiens 2 (PIF1006)**.  
Ce projet implémente un **automate fini déterministe** en C# permettant de valider ou rejeter des chaînes binaires (`0` et `1`).

# Contexte

Un automate fini est une machine théorique utilisée pour reconnaître des langages formels.  
Ce projet applique la théorie des automates en la traduisant dans une application console :  
- Chargement d’un automate à partir d’un fichier texte (`automate.txt`) contenant ses **états** et **transitions**.  
- Vérification de la validité de l’automate (présence d’un seul état initial, au moins un état final, déterminisme, etc.).  
- Validation de chaînes binaires saisies par l’utilisateur.  

# Fonctionnalités

- Chargement d’un automate depuis un fichier externe (`automate.txt`).  
- Détection et rejet des automates incorrects :  
  - Aucun état défini  
  - Pas d’état initial ou plus d’un état initial  
  - Pas d’état final  
  - Transitions non déterministes (même entrée menant à plusieurs états)  
- Affichage clair du **diagramme états-transitions** en console.  
- Validation de chaînes binaires (`0` et `1`) saisies par l’utilisateur.  
- Messages explicites pour indiquer si la chaîne est **acceptée** ou **rejetée** .

# Pour l'execution

Assurez-vous d’avoir le SDK .NET installé. Puis exécutez :

git clone https://github.com/joy843/AutomateS.git
cd AutomateS
dotnet run 

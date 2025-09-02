
using System;
namespace PIF1006_tp1
{
   
    public class Program
    {
        static void Main(string[] args)
        {

            // Spécifie le chemin relatif directement
            Automate automate = new Automate("./automate.txt");


            if (automate.IsValid)
            {
                Console.WriteLine("Automate chargé avec succès !");

                Console.WriteLine(automate.ToString()); // Affiche la pseudo-table d'action


                // Boucle pour tester plusieurs chaînes
                while (true)
                {
                    Console.WriteLine("\nEntrez une chaîne composée uniquement de 0 et de 1 (ou tapez 'q' pour fermer) :");
                    string entree = Console.ReadLine();

                    // Permet de quitter la boucle
                    if (entree.ToLower() == "q")
                    {
                        Console.WriteLine("Fin de l'application. Appuyez sur ENTER pour fermer.");
                        Console.ReadLine(); // Attend que l'utilisateur appuie sur ENTER
                        break;
                    }

                    // Vérifie que l'entrée est valide (contient uniquement 0 et 1)
                    bool isValidInput = true;

                    foreach (char c in entree)
                    {
                        if (c != '0' && c != '1')
                        {
                            isValidInput = false;
                            break; // Arrête la vérification dès qu'un caractère invalide est trouvé
                        }
                    }

                    if (!isValidInput)
                    {
                        Console.WriteLine("Erreur : La chaîne doit être composée uniquement de 0 et de 1.");
                        continue; // Redemande une nouvelle entrée
                    }

                    // Valider l'entrée avec l'automate
                    bool resultat = automate.Validate(entree);

                    // Affiche le résultat
                    if (resultat)
                        Console.WriteLine("Résultat : Chaîne ACCEPTÉE.");
                    else
                        Console.WriteLine("Résultat : Chaîne REJETÉE.");
                }
            }
            else
            {

                Console.WriteLine("Votre automate est invalide, taper sur ENTRER pour fermer");
                Console.ReadLine();


            }
          
        }
    }
}

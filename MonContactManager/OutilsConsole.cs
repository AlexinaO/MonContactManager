using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MonContactManager
{
    class OutilsConsole
    {
        //Méthode pour afficher le Menu Principal
        public static string AfficherMenuPrincipal()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.
            CentrerTexte("CONTACT MANAGER");
            Console.WriteLine("\n\n");
            CentrerTexte("Menu");
            Console.WriteLine("1. Liste des contacts");
            Console.WriteLine("2. Ajouter un contact");
            Console.WriteLine("3. Supprimer un contact");
            Console.WriteLine("4. Trier les contacts");
            Console.WriteLine("5. Filtrer les contacts");
            Console.WriteLine("Q. Quitter le programme");

            Console.WriteLine("\nFaites votre choix:");
            return Console.ReadLine();
        }
        
        // Methode pour sous menu Trier Contacts


        // Methode pour Trier Contacts suivant nom

        // Methode pour Trier Contacts suivant prénom


        // Méthode pour centrer le texte
        public static void CentrerTexte(string texte)
        {
            int nbEspaces = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            Console.WriteLine(texte);
        }

        
        // Méthode pour afficher les messages d'erreur

        public static void AfficherMessageErreur(string message)
        {

        }

     // écrire une méthode pour demander saisie chaine obligatoire

    //méthode pour tester le bon format Date de Naissance

     //méthode pour tester le bon format Email

        // methode pour tester le bon format Téléphone

        // méthode pour mettre nom en MAJUSCULES

        // Méthode pour mettre prénom avec 1ère lettre en MAJUSCULE et autres lettres en minuscules

    }
}

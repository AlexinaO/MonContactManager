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
        
        
        //Methode pour mettre en couleur voulue du texte
        public static void CouleurTexte(string message, ConsoleColor couleur=ConsoleColor.Gray)
        {
            Console.ForegroundColor = couleur;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
        //Methode pour mettre en couleur voulue du texte et le centrer

        
        // Methode pour Trier Contacts suivant nom

        // Methode pour Trier Contacts suivant prénom


        // Méthode pour centrer le texte
        public static void CentrerTexte(string texte)
        {
            int nbEspaces = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            Console.WriteLine(texte);
        }

        
        // Méthode pour afficher les messages Erreur en rouge

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

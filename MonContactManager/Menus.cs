using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonContactManager
{
    class Menus
    {
        //Méthode pour afficher le Menu Principal
        public static string AfficherMenuPrincipal()
        {
            Console.Clear();
            OutilsConsole.CentrerTexte("CONTACT MANAGER");
            Console.WriteLine("\n\n");
            OutilsConsole.CentrerTexte("Menu");
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
        public static string AfficherMenuTriContacts()
        {
            Console.Clear();


        }
    }
}

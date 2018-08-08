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
            Esthetisme.CouleurTexte("CONTACT MANAGER\n\n", ConsoleColor.DarkBlue, true);
            Esthetisme.CouleurTexte("Menu\n", centre:true );
            Esthetisme.CouleurTexte("\n1. Liste des contacts");
            Esthetisme.CouleurTexte("\n2. Ajouter un contact", ConsoleColor.Blue);
            Esthetisme.CouleurTexte("\n3. Supprimer un contact");
            Esthetisme.CouleurTexte("\n4. Trier les contacts", ConsoleColor.Blue);
            Esthetisme.CouleurTexte("\n5. Filtrer les contacts");
            Esthetisme.CouleurTexte("\nQ. Quitter le programme", ConsoleColor.DarkRed);

            Console.WriteLine("\n\nFaites votre choix:");
            return Console.ReadLine();
        }

        // Methode pour sous menu Trier Contacts
        /*public static string AfficherMenuTriContacts()
        {
            Console.Clear();


        }*/
    }
}

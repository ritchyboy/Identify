using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identify
{
   public class Message
    {
        public static void Greeting()
        {
            Console.WriteLine("--Bienvenue dans mon programme d'information--");
            Console.WriteLine("--------------------Menu-------------------");
            Console.WriteLine("1.Ajouter une personne");
            Console.WriteLine("2.Modifier une personne");
            Console.WriteLine("3.Effacer une personne");
            Console.WriteLine("4.Afficher les personnes");
            Console.WriteLine("0.Quitter le programme");
        }
        public static void ModifyMenu()
        {
            Console.WriteLine("--------------------Menu pour les changements-------------------");
            Console.WriteLine("1.Changer le nom de la personne");
            Console.WriteLine("2.Changer le nom de famille de la personne");
            Console.WriteLine("3.Changer l'age de la personne");
        }
        static bool CheckIfDigit(string nom)
        {
            foreach (char n in nom)
            {
                if (char.IsDigit(n))
                {
                    return true;
                }
            }
            return false;
        }
        public static string AskForName()
        {
            Console.WriteLine("Entrez votre nom: ");
            try
            { 
            string nom = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nom)||string.IsNullOrEmpty(nom)||CheckIfDigit(nom))
                {
                    Console.WriteLine("Ce nom ne peut pas etre vide ou etre un numero");
                    AskForName();
                }
            return nom;

            }
            catch
            {
                Console.WriteLine("Ce nom n'est pas valide");
            }
            return AskForName();
        }
        public static string AskForNewName()
        {
            Console.WriteLine("Entrez le nouveau nom: ");
            try
            {
                string nom = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrEmpty(nom) || CheckIfDigit(nom))
                {
                    Console.WriteLine("Ce nom ne peut pas etre vide ou etre un numero");
                    AskForNewName();
                }
                return nom;

            }
            catch
            {
                Console.WriteLine("le nouveau nom n'est pas valide");
            }
            return AskForNewName();
        }
        public static string AskForLastName()
        {
            Console.WriteLine("Entrez votre nom de famille: ");
            try
            {
                string nomDeFamille = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nomDeFamille) || string.IsNullOrEmpty(nomDeFamille) || CheckIfDigit(nomDeFamille))
                {
                    Console.WriteLine("Ce nom ne peut pas etre vide ou etre un numero");
                    AskForLastName();
                }
                return nomDeFamille;
            }
            catch
            {
                Console.WriteLine("Ce nom n'est pas valide");
            }
            return AskForLastName();
        }
        public static string AskForNewLastName()
        {
            Console.WriteLine("Entrez votre nom de famille: ");
            try
            {
                string nomDeFamille = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nomDeFamille) || string.IsNullOrEmpty(nomDeFamille) || CheckIfDigit(nomDeFamille))
                {
                    Console.WriteLine("Ce nom ne peut pas etre vide ou etre un numero");
                    AskForNewLastName();
                }
                return nomDeFamille;

            }
            catch
            {
                Console.WriteLine("Ce nom n'est pas valide");
            }
            return AskForNewLastName();
        }
        public static int AskForAge()
        {
            Console.WriteLine("Entrez votre age: ");
            try
            {
              int age = Int32.Parse(Console.ReadLine());
                return age;
            }
            catch
            {
                Console.WriteLine("Un age n'a pas ete entrer");
            }
            return AskForAge();
            
        }
        public static int AskForNewAge()
        {
            Console.WriteLine("Changer l'age de la personne: ");
            try
            {
                int age = Int32.Parse(Console.ReadLine());
                return age;
            }
            catch
            {
                Console.WriteLine("Un age n'a pas ete entrer");
            }
            return AskForNewAge();

        }
        public static int AskForIndex()
        {
            Console.WriteLine("Entrez le Id de la personne que vous voulez effacer");
            try
            {
                int index = Int32.Parse(Console.ReadLine());
                return index;
            }
            catch
            {
                Console.WriteLine("Ceci n'est pas un ID");
            }
            return AskForIndex();
        }
        public static int AskForIndexMod()
        {
            Console.WriteLine("Entrez le Id de la personne que vous voulez modifier");
            try
            {
                int index = Int32.Parse(Console.ReadLine());
                return index;
            }
            catch
            {
                Console.WriteLine("Ceci n'est pas un ID");
            }
            return AskForIndex();
        }
        public static void ConfirmationMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cette personne a ete ajouter a la liste");
            Console.ResetColor();
        }
        public static void ConfirmationDelete()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cette personne a ete effacer");
            Console.ResetColor();
        }
        public static void Goodbye()
        {
            Console.WriteLine("Merci d'avoir utiliser mon programme");
            Environment.Exit(0);
        }
        public static void MessageColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message, color);
            Console.ResetColor();
        }
        public static int MakeAChoice()
        {
            int choix = Int32.Parse(Console.ReadLine());
            try
            {
                if (choix>4)
                {
                    Console.WriteLine("Le choix est au decu de 4 ");
                    return MakeAChoice();
                }
                return choix;
            }
            catch
            {
                Console.WriteLine("Le choix n'est pas valide");
            }
            return MakeAChoice();
        }
        public static void ClearMessage()
        {
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

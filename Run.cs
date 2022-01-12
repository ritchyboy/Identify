using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identify
{
    class Run
    {
       public static void Start()
        {
            var ListePersonne = new List<Personne>();
            while (true)
            {
                Message.Greeting();
                int choice=Message.MakeAChoice();
                switch (choice)
                {
                    case 1:
                        {
                            string nom = Message.AskForName();
                            string nomDeFamille = Message.AskForLastName();
                            int age = Message.AskForAge();
                            var personne = new Personne(nom, nomDeFamille, age);
                            ListePersonne.Add(personne);
                            Message.ConfirmationMessage();
                            break;
                        }
                    case 2:
                        {
                            foreach (var pers in ListePersonne)
                            {
                                pers.Afficher();
                            }
                            foreach(var pers in ListePersonne)
                            {
                                int modifyIndex = Message.AskForIndexMod();
                                if (modifyIndex==pers.id)
                                {
                                    pers.Modify(); ;
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (var pers in ListePersonne)
                            {
                                pers.Afficher();
                            }
                            int index = Message.AskForIndex();
                            ListePersonne.RemoveAt(index);
                            Message.ConfirmationDelete();
                            break;
                        }
                    case 4:
                        {
                            foreach (var pers in ListePersonne)
                            {
                                pers.Afficher();
                            }
                            break;
                        }
                    case 0:
                        {
                            Message.Goodbye();
                            break;
                        }
                }
                Message.ClearMessage();
            }
        }
    }
}

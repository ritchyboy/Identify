using System.Collections.Generic;

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
                            Personne.AfficherListeDePersonne(ListePersonne);
                            foreach(var pers in ListePersonne)
                            {
                                int modifyIndex = Message.AskForIndexMod();
                                if (modifyIndex==pers.id)
                                {
                                    pers.Modify();
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Personne.AfficherListeDePersonne(ListePersonne);
                            int index = Message.AskForIndex();
                            ListePersonne.RemoveAt(index);
                            Message.ConfirmationDelete();
                            break;
                        }
                    case 4:
                        {
                            Personne.AfficherListeDePersonne(ListePersonne);
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

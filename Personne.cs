using System;

namespace Identify
{
    public class Personne
    {
        public static int index = 0;
        string name;
        string lastName;
        int age;
       public int id;
        public Personne(string name,string lastName,int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.id = index;
            index++;
        }
       public void Afficher()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nom: " + name);
            Console.WriteLine("Nom de famille: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("--------------------------");
        }
        public void Modify()
        {
            Message.ModifyMenu();
            int mod = Int32.Parse(Console.ReadLine());
            switch(mod)
            {
                case 1:
                    {
                        Console.WriteLine("Le nom est :"+ name);
                        name=Message.AskForNewName();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Le nom de famille est :" + lastName);
                        lastName = Message.AskForNewLastName();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("L'age est :"+ age);
                        age = Message.AskForNewAge();
                        break;
                    }
            }
        }
    }
}

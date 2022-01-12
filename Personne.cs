using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identify
{
    public class Personne
    {
        public static int index = 0;
        string name;
        string lastName;
        int age;
        int id;
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
    }
}

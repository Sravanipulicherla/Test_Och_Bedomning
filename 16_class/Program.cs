using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace _16_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first_name;
            string opponent_name;
            Random a = new Random();
            
            Console.WriteLine("Enter name for your character:");
            first_name = Console.ReadLine();
            Person Person1 = new Person(first_name, a.Next(0, 10), a.Next(0, 10), a.Next(0, 10));

            Console.WriteLine("Enter name for Opponent:");
            opponent_name = Console.ReadLine();
            Person Person2 = new Person(opponent_name, a.Next(0, 10), a.Next(0, 10), a.Next(0, 10));
            Console.WriteLine("\n");
            Console.WriteLine("Details for my character are: ");
            Console.WriteLine("-----------------------------");         
            Console.WriteLine("Name: " + Person1.Name);
            Console.WriteLine("Health: " + Person1.Health);
            Console.WriteLine("Strength: " + Person1.Strength);
            Console.WriteLine("Luck: " + Person1.Luck);

            Console.WriteLine("\n");
            Console.WriteLine("Details for Opponent are: ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Name: " + Person2.Name);
            Console.WriteLine("Health: " + Person2.Health);
            Console.WriteLine("Strength: " + Person2.Strength);
            Console.WriteLine("Luck: " + Person2.Luck);

            Console.ReadLine();
        }
    }
    public class Person
    {

        public string Name;
        public int Health;
        public int Strength;
        public int Luck;

        public Person(string Name, int Health, int Strength, int Luck)
        {
            this.Name = Name;
            this.Health = Health;
            this.Strength = Strength;
            this.Luck = Luck;
        }


    }
}

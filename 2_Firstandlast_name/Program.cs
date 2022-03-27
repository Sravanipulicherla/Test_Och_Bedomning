using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstandlast_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first;
            string Last;
            int age;

            Console.WriteLine("Enter the First name of the person is");
            first =Console.ReadLine();
            Console.WriteLine("Enter the last name of the person is");
            Last =Console.ReadLine();
            Console.WriteLine("Enter the age of the person is");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("First name: " + first + "\nLast name: " + Last + "\nAge: " + age);
            Console.ReadLine();
        }
    }
}

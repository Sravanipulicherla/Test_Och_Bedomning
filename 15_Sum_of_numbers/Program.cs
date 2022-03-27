using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddeven
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the number of values separate with comma:");
            string input = Console.ReadLine();
            Console.Write("\n");
            string[] strings = input.Split(',');
            int[] ints = Array.ConvertAll(strings, s => int.Parse(s));

            Console.WriteLine($"Sum of values entered: {ints.Sum()}");            
            Console.ReadLine();


        }
    }
}


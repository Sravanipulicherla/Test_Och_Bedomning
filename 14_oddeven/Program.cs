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

            List<int> odds = new List<int>();
            List<int> evens = new List<int>();

            for (int i = 0; i < ints.Length; i ++)
            {
                if (ints[i] % 2 == 0)
                    evens.Add(ints[i]);                
                else
                    odds.Add(ints[i]);
            }            

            Console.WriteLine($"Even values: {String.Join(",", evens)}");
            Console.WriteLine($"Odd values: {String.Join(",", odds)}");
            Console.ReadLine();


        }
    }
 }


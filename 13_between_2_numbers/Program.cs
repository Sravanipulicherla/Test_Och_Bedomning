using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_between_2_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First input Number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second input Number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
       
            if (first_number > second_number)
              
            { 
               first_number = first_number + second_number;
               second_number = first_number - second_number;
               first_number = first_number - second_number;
            }

            int[] all_numbers = new int[second_number - first_number - 1];
            for (int i = 0; i < all_numbers.Length; ++i)
                all_numbers[i] = first_number + i+1;

            Console.WriteLine($"The numbers in between {first_number} and {second_number} are: {String.Join(", ", all_numbers)}" );
            Console.ReadLine();
        }
    }
}

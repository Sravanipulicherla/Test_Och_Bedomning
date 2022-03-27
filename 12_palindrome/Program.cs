using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the string:");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string rev_input = new string(charArray);
            

            if (rev_input.Equals(input, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Hurray!!! Its a palindrome string");
            else
                Console.WriteLine("Its not palindrome string");

            Console.ReadLine();
            }
    }
}

using System;
namespace Randomnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            int number = a.Next(0, 100);
            
            int b;
            int count = 1;
            
            while (true)
            {
                Console.WriteLine("Try to guess the number: ");
                b = Convert.ToInt32(Console.ReadLine());
                if (number == b)
                { 
                    Console.WriteLine("Hurry its a match!!!!. It took "+ count+" attempts");
                    break;
                }

                else
                {
                    if (number > b)
                        Console.WriteLine("The Random number is greater than the guessed number ( > "+ b + " )\n");
                    else
                        Console.WriteLine("The Random number is less than the guessed number ( < " + b + " )\n");
                }
                count++;
                
            }
            Console.ReadLine();

        }
    }
}
using System;

namespace Printlargest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value: ");
            int b= Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Math.Max(a, b));
            Console.WriteLine("The largest of both values is: " + c);
            Console.ReadLine();


        }
    }
}

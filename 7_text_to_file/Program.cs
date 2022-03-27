using System;
using System.Text;
using System.IO;

namespace storehardisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the message");
            String message = (Console.ReadLine());
            Console.WriteLine("The message is " + message);           
            File.WriteAllText(@"C:\Users\pulis\OneDrive\Documents\dummy.txt", message);

        }
    }
}

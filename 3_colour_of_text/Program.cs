using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_colour_of_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "This funtion changes colour of text on console";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(txt);            
            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(txt);
            Console.ReadLine();
        }
    }
}

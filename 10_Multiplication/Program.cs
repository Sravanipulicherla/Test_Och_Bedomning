using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j, i;
            Console.Write("\n\n");
            Console.Write("Multiplication table from 1 to 10:\n");
            Console.Write("-------------------------------------");
            Console.Write("\n\n");

           

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    if (j <= 9)
                        Console.Write("{0}x{1} = {2} \t ", j, i, i * j);
                    else
                        Console.Write("{0}x{1} = {2}", j, i, i * j);

                }
                Console.Write("\n");                
            }
            Console.ReadLine();
        }
    }

}
   

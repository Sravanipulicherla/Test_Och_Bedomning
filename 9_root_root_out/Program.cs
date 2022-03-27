using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareroot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1;
            Console.WriteLine("Please enter the decimal number to calculate square root:");
            value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square root of the number is:" + Math.Sqrt(value1));

            double value2= Math.Pow(value1, (1.0 / 10.0));//10th root of 125
            Console.WriteLine("The 10th root of the number is:" + Math.Sqrt(value2));
            Console.ReadLine();
        }
    }
}

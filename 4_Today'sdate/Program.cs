using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_sdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today's date: "+ DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            Console.ReadLine();
        }
    }
}

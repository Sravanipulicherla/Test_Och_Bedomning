using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twoarrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] first_array = new int[10];
            int[] second_array = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < first_array.Length; i++)
            {
                first_array[i] = randNum.Next(0, 100);
            }
            Console.WriteLine("First Array with random numbers: [{0}]",  string.Join(", ", first_array));

            second_array = first_array;

            for (int i = 0; i < second_array.Length - 1; i++)
            {
                for (int j = i + 1; j < second_array.Length; j++)
                {
                    if(second_array[i]> second_array[j])
                    {
                        int temp = second_array[i];
                        second_array[i] = second_array[j];
                        second_array[j] = temp;
                    }

                }
            }
            Console.WriteLine("Second Array with ascending order: [{0}]", string.Join(", ", second_array));
            Console.ReadLine();
        }
    }
}

using System;
using System.Text;
using System.IO;

namespace openfile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\pulis\OneDrive\Documents\dummy.txt";
            FileStream fs = File.OpenRead(path);
            
            StreamReader sr = new StreamReader(fs);
            string fileContent = sr.ReadToEnd();
            Console.WriteLine(fileContent);
            sr.Close();
            fs.Close();
            //  Console.WriteLine(fs.ToString());
            Console.ReadLine();

        }
    }
}

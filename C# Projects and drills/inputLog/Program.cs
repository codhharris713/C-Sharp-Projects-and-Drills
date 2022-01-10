using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace inputLog
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            using (StreamWriter number = new StreamWriter(@"C:\Users\Cody\OneDrive\Documents\LogTest.txt", true))
            {
                number.WriteLine(Console.ReadLine());
            }
            string readBack = File.ReadAllText(@"C:\Users\Cody\OneDrive\Documents\LogTest.txt");
            Console.WriteLine("\nYou have entered the number(s):\n" + readBack);
            Console.ReadLine();

        }
    }
}
using System;
using System.Collections.Generic;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Mr.Nice";

            Console.WriteLine("{0}", name);

            var names = new List<string>() { "Mr.Nice", "Mr.Clean", "Mr.Mean" };
            Console.WriteLine(names[0]);

            Start x = new Start("Mr.Nice");






            Console.ReadLine();
        }

    }
}


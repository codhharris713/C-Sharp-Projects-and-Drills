using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method5
{
    class Program
    {
        static void Main(string[] args)
        {
            Math n = new Math();
            Console.WriteLine("Pick a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int a;
            int b;
            n.Division(num1);
            n.Division(out a, out b);
            Math.Print();

            Console.WriteLine("Your first number is " + a);
            Console.WriteLine("Your second number is " + b);
            Console.WriteLine("The number in the static class is " + Math.Print());

            Console.ReadLine();
        }
    }
}
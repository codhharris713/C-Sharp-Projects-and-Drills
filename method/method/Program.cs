using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace method1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for some math fun!");
            int a = Convert.ToInt32(Console.ReadLine());
            int return1;
            int return2;
            int return3;
            Class1 i = new Class1();

            return1 = i.Addition1(a);
            return2 = i.Addition2(a);
            return3 = i.Addition3(a);
            Console.WriteLine("Your number plus 30 = " + return1);
            Console.WriteLine("Your number plus 40 = " + return2);
            Console.WriteLine("Your number plus 50 = " + return3);
            Console.ReadLine();
        }
    }
}

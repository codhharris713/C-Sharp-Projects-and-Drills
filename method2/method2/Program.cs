using System;

namespace method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Main i = new Main();

            Console.WriteLine("Please enter number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may choose another number or one will be provide for you.");
            string num2 = Console.ReadLine();
            if (num2 == "") //if user inputs nothing
            {
                Console.WriteLine(i.Method1(num1));//user input times 10
            }
            else
            {
                int num3 = Convert.ToInt32(num2);//user input number
                Console.WriteLine(i.Method1(num1, num3));//both user numbers times
            }
            Console.ReadLine();
        }

    }
}

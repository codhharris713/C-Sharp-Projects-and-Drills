using System;

namespace overloadOpps
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { ID = 10 };
            Employee employee2 = new Employee() { ID = 10 };

            if (employee1 == employee2)
            {
                Console.WriteLine("ID's match");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ID's do not match");
                Console.ReadLine();
            }
        }
    }
}
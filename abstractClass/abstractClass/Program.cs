using System;

namespace abstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee() { FirstName = "Sample", LastName = "Student" };
            name.SayName();
            

            
            IQuittable employee1 = new Employee();
            employee1.Quit();
            Console.ReadLine();

        }
    }
}

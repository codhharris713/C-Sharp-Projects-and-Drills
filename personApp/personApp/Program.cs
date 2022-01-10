using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace personApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee() { FirstName = "Sample", LastName = "Student" }; // instantiate and initialize employee object
            person.SayName(); //super class method
            Console.ReadLine();
        }
    }
}

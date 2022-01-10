using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>() 
            {
                new Employee() { FirstName = "Bob", LastName = "Jackson", Id = 1 },
                new Employee() { FirstName = "Rob", LastName = "Dunken", Id = 2 },
                new Employee() { FirstName = "Tom", LastName = "Roberts", Id = 3 },
                new Employee() { FirstName = "Cody", LastName = "Harris", Id = 4 },
                new Employee() { FirstName = "Bill", LastName = "Hill", Id = 5 },
                new Employee() { FirstName = "Jerry", LastName = "Merry", Id = 6 },
                new Employee() { FirstName = "Joe", LastName = "Doe", Id = 7} ,
                new Employee() { FirstName = "Mike", LastName = "Hike", Id = 8 },
                new Employee() { FirstName = "Joe", LastName = "Dirt", Id = 9 },
                new Employee() { FirstName = "Spock", LastName = "Mock", Id = 10 },

            };

            List<Employee> JoeName = new List<Employee>(); //foreach loop adds FirstName Joe to new list
            
            foreach (Employee name in Employees)
            {
                if (name.FirstName == "Joe")
                {
                    JoeName.Add(name);
                    Console.WriteLine(name.FirstName);
                }
            }

            List<Employee> JoeNameX = new List<Employee>();
            JoeNameX = Employees.Where(x => x.FirstName == "Joe").ToList(); // lambda expression add FirstName Joe to new List
            foreach (Employee SameJoe in JoeNameX)
            {
                Console.WriteLine(SameJoe.FirstName);
            }

            List<Employee> GreaterFive = new List<Employee>();
            GreaterFive = Employees.Where(x => (x.Id > 5)).ToList(); //lambda expression new list of Ids Greater then 5
            foreach (Employee FiveId in GreaterFive)
            {
                Console.WriteLine(FiveId.Id);
            }
            Console.ReadLine();
        }
    }
}

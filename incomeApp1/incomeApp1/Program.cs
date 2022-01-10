using System;

namespace incomeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal hourlyPay;
            int weeklyHours;
            decimal yearlySalary;
            decimal yearlySalary1;

            
            
            
            Console.WriteLine("Anonymous Income Comparison Program");
            
            //prompt user to assign variables
            Console.WriteLine("Person 1");
            Console.Write("Hourly pay: $");
            hourlyPay = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Hours worked each week: ");
            weeklyHours = Convert.ToInt32(Console.ReadLine());

            //calculate salaries and displays salaries
            yearlySalary = hourlyPay * weeklyHours * 52;
            Console.WriteLine("Annual salary of Person 1: {0:C}", yearlySalary);

            Console.WriteLine("Person 2");
            Console.Write("Hourly pay: $");
            hourlyPay = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Hours worked each week: ");
            weeklyHours = Convert.ToInt32(Console.ReadLine());

            yearlySalary1 = hourlyPay * weeklyHours * 52;
            Console.WriteLine("Annual salary of Person 2: {0:C}", yearlySalary1);

            //Comparing person1 and person2 inputs
            Console.WriteLine("Does Person 1 make more money then Person 2?");
            bool compare = yearlySalary > yearlySalary1;
            Console.WriteLine(compare);
            Console.ReadLine();

            


        }
    }
}

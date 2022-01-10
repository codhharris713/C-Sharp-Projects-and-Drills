using System;

namespace DateTimeNow
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime theTime = DateTime.Now; //prints current date and time to console
            Console.WriteLine(theTime);

            Console.WriteLine("Please enter a number");
            TimeSpan hours = TimeSpan.FromHours(Convert.ToDouble(Console.ReadLine())); 
            DateTime Xhours = theTime + hours;
            Console.WriteLine(Xhours); //prints the time it will be in hours from user input number
            Console.ReadLine();

        }
    }
}

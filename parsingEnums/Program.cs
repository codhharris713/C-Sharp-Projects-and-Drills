using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the current day of the week.");

            try
            {
                
                string todayInput = Console.ReadLine();
                DaysOftheWeek day = (DaysOftheWeek)Enum.Parse(typeof(DaysOftheWeek), todayInput);
                Console.WriteLine("The day is {0}", day);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        public enum DaysOftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thrusday,
            Friday,
            Saturday,
            Sunday,
        }
    }
}

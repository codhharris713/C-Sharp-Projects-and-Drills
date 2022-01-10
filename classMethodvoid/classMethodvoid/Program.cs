using System;

namespace classMethodvoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); //instantiate class

            Console.WriteLine("Input Number");
            int input = Convert.ToInt32(Console.ReadLine()); //input from user
            math.Divide(input); // call first method
            Math.Divide(input, out input); // calls second method
        }
      
        
            
           
        
    }
}

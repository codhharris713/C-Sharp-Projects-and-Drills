using System;
using System.Collections.Generic;
using System.Text;

namespace classMethodvoid
{
    class Math
    {
        public void Divide(int a)
        {
            int sum = a / 2;
            Console.WriteLine(sum); //void method outputs integer divide passed data by 2
        }
        
        public static void Divide (int x, out int y) // overloading method, out parameter
        {
            int sum = y = x / 2;
            

        }
        
        public static class None //static class
        { }
    
    
    
    
    }

}

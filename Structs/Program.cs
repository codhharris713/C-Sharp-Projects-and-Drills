using System;

namespace Structs
{
    class Program
    {

        public struct Number // encapsulates related data types
        {
            public decimal Amount;

        }

        static void Main(string[] args)
        {
            Number price;
            price.Amount = 50.00m;
            Console.WriteLine(price.Amount);
            Console.ReadLine();
        }
    }
}

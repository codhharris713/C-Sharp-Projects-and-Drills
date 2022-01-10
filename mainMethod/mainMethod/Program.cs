using System;

namespace mainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Main i = new Main();
            Console.WriteLine(i.method(5)); 
            Console.WriteLine(i.method(15.55m)); 
            Console.WriteLine(i.method("5"));
        }
    }
}

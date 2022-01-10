using System;
using System.Collections.Generic;
using System.Text;

namespace personApp
{
    class Person
    {
        public string FirstName; //two properties of data type string
        public string LastName;

        public void SayName()//superclass with no parameters
        {
            Console.WriteLine("Name: [{0} {1}]", FirstName, LastName); // writes full name to console
        }
    }
}

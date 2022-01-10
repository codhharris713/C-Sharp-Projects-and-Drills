using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace abstractClass
{
    public class Employee : Person, IQuittable //inherit from Person class and IQuittable
    {
        public int ID { get; set; }
        public override void SayName() //abstract method 'SayName' declare here with override keyword
        {
            Console.WriteLine("Name {0} {1}", FirstName, LastName);
        }
        public void Quit()
        {
            Console.WriteLine("Take this job and shove it");
        }
        
        
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace overloadOpps
{
    class Employee
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool match = false;
            if (employee1.ID == employee2.ID)
            {
                match = true;
            }
            return match;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool match = false;
            if (employee1.ID != employee2.ID)
            {
                match = true;
            }
            return match;
        }
    }
}
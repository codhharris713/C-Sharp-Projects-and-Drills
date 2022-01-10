using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace method1
{
    public class Class1
    {   //class Class1 has data property int Addition
        public int Addition1(int num1) //public access modifier specifies variable is accessible for other classes
        {
            int result = num1 + 30;
            return result;
        }

        public int Addition2(int num1)
        {
            int result2 = num1 + 40;
            return result2;
        }

        public int Addition3(int num1)
        {
            int result3 = num1 + 50;
            return result3;
        }
    }
}

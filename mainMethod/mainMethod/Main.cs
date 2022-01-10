using System;
using System.Collections.Generic;
using System.Text;

namespace mainMethod
{
     public class Main
    {
        public int method(int num1) //method for integer
        {
            int resultOne = num1 + 5;
            return resultOne;

        }

        public int method(decimal num2) //method for decimal
        {
            decimal result2 = num2 - 5;
            int resultTwo = Convert.ToInt32(result2);
            return resultTwo;
        }

        public int method(string num3) //method for string
        {
            int numThree = Convert.ToInt32(num3);
            int result3 = numThree + 5;
            return result3;
        }

    }
}

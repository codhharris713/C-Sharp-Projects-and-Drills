using System;
using System.Collections.Generic;
using System.Text;

namespace method2
{
    public class Main

    {
        public int Method1(int x, int y = 10)
        {
            int result = x * y;
            return result;
        }
    }
}

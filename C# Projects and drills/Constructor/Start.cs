using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Start
    {
        string name1 = "";
        string id = "";
        public Start(string name, string idx)
        {
            name1 = name;
            id = idx;
            Console.WriteLine("Hello {0}, {1}", name, idx);
        }

        public Start(string name) : this(name, "111") { }
    }
}

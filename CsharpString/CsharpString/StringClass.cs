using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpString
{
    class StringClass
    {
        public StringClass(string mystr)
        {
            string str = "Hello";

            for (int i = 0; i < 10000; i++)
            {
                str += mystr;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringClass sc = new StringClass("Vinay");  //Immutable

            StringBuilderClass sb = new StringBuilderClass("Vinay"); //Mutable
        }
    }
}

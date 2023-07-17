using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.arrList();

            Class2 c2 = new Class2();
            c2.aList();

            Class3 c3 = new Class3();
            c3.aStack();

            Class4 c4 = new Class4();
            c4.aQ();
        }
    }
}

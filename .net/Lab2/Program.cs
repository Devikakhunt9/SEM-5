using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.getDetails();
            c1.bmi();

            Class2 c2 = new Class2();
            c2.getDetails();
            c2.grade();

            Class3 c3 = new Class3();
            c3.prime();


            Class4 c4 = new Class4();
            c4.leapYear();

            Class5 c5 = new Class5();
            c5.fibbonaci();

            Class6 c6 = new Class6();
            c6.binary();

            Class7 c7 = new Class7();
            c7.permutation();
        }
    }
}

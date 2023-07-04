using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.getError();

            Class2 c2 = new Class2();
            c2.raiseError();

            Class3 c3 = new Class3();
            c3.raiseError();

            Calculate c4 = new Calculate();
            c4.SumOfTwo(4, 5);
            c4.SumOfThree(4, 5, 6);

            Class5 c5 = new Class5();
            c5.getDetails();
            c5.addition();
            c5.substraction();


            Class6 c6 = new Class6();
            c6.getDetails();
            c6.Circle();
            c6.Triangle();
            c6.Square();

            Class7 c7 = new Class7();
            c7.stringMethod("DEvika");

            Class8 c8 = new Class8();
            c8.toUpper("devika khunt 123 456");
            c8.toLower("DEVIKA");

            Class9 c9 = new Class9();
            c9.getString();
            c9.findMaxWord();

            Class10 c10 = new Class10();
            c10.invert("DeViKa");


        }
    }
}

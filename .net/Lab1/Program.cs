using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   internal class Program
    {
        static void Main(string[] args)

        {

            Class1 c1 = new Class1();
            c1.getDetails();
            c1.printDetails();



            Class2 c2 = new Class2();
            c2.getDetail();
            c2.setDetail();

            Class3 c3 = new Class3(2, 3);
            Class3 c31 = new Class3();
            c31.areaRectangular();
            c3.areaRectangular();


            Class4 c4 = new Class4();
            c4.getDetils();
            c4.areaOfRactangle();
            c4.areaOfCircle();
            c4.areaOfSquare();


            Class5 c5 = new Class5();
            c5.getDetails();
            c5.ctof();
            c5.ftoc();

            Class6 c6 = new Class6();
            c6.getDetails();
            c6.intrest();

            Class7 c7 = new Class7();
            c7.getDetails();
            c7.calci();

            Class8 c8 = new Class8();
            c8.getDetail();
            c8.maxOf3();


            Class9 c9 = new Class9();
            c9.getDetail();
            c9.swap();



            Console.WriteLine("Devika Khunt\nRajkot,Gujrat\n1234567890");
        }
    }
}

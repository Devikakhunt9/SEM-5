using System;

namespace ConsoleApp1
{
    internal class Class4
    {
        double lr, wr, rc, ls;
        public Class4()
        {
        }
        public void getDetils()
        {
            Console.WriteLine("Enter Lenght for Ractangle::");
            lr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width for Ractangle :");
            wr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Radius For Circle:");
            rc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Length for Square :");
            ls = Convert.ToDouble(Console.ReadLine());
        }
        public void areaOfRactangle()
        {
            Console.WriteLine("Area OF Ractangle :{0}", lr * wr);
        }
        public void areaOfCircle()
        {
            Console.WriteLine("Area OF Circle :{0}",3.14 * rc * rc );
        }
        public void areaOfSquare()
        {
            Console.WriteLine("Area OF Square :{0}",ls*ls);
        }
    }
}
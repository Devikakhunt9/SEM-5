using System;

namespace ConsoleApp5
{
    internal class Class3
    {
        public Class3()
        {
        }

        internal void area(int v1, int v2)
        {
            Console.WriteLine(v1 + v2);
        }

        internal void area(string v1, int v2)
        {
            if (v1 == "Circle") Console.WriteLine("Area : {0}", 3.14 * v2 * v2);
            else Console.WriteLine("Ans : {0}", v2 * v2);
        }

        internal void area(double v1, double v2)
        {
            Console.WriteLine("Ans:{0}",v1* v2);
        }
    }
}
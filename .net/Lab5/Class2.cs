using System;

namespace ConsoleApp5
{
    internal class Class2
    {
        public Class2()
        {
        }

        internal void area(int v)
        {
            Console.WriteLine("Area Of Square : {0}", v * v);
        }

        internal void area(int v1, int v2)
        {
            Console.WriteLine("Area OF Triangle : {0}", 0.5 * v1 * v2);
        }
    }
}
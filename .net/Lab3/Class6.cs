using System;

namespace ConsoleApp3
{
    internal class Class6
    {
        double d1, d2, d3;
        public Class6(double d1,double d2)
        {
            this.d1 = d1;
            this.d2 = d2;
        }
        public void displayAddition()
        {
            d3 = d1 + d2;
            Console.WriteLine(d3);
        }
    }
}
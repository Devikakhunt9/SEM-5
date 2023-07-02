using System;

namespace ConsoleApp1
{
    internal class Class3
    {
        double l, w;
        public Class3(double l, double w)
        {
            this.l = l; 
            this.w = w;
        }

        public Class3()
        {
            this.l = 1;
            this.w = 1;
        }
        public void areaRectangular()
        {
            Console.WriteLine(l * w);
        }
    }
}
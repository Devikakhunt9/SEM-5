using System;

namespace ConsoleApp3
{
    internal class Class7
    {
        double l, w;
        public Class7(double l,double w)
        {
            this.l = l; 
            this.w = w;
        }

        public void area()
        {
            Console.WriteLine(l*w);
        }
    }
}
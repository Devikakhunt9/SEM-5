using System;

namespace ConsoleApp3
{
    internal class Class5
    {
        double da, ta, hra;
        public Class5()
        {
            this.da = 1.0;
            this.ta = 1.0;
            this.hra = 1.0;
        }
        public Class5(double da, double ta, double hra)
        {
            this.da = da;
            this.ta = ta;
            this.hra = hra;
        }

        public void salary()
        {
            Console.WriteLine(ta+hra+da);
        }
    }
}
using System;

namespace ConsoleApp5
{
    public class Class4
    {
        public double i, p, r;
        public Class4()
        {
            i = 1;
            p = 1;
            r = 1;
        }

        public void calculateInterest()
        {
            Console.WriteLine("Interst : {0}", (i + p + r) / 100);
        }
    }
    public class HDFC : Class4
    {
        public HDFC() 
        {
            i = 1;
            p = 1;
            r = 1;
        }
        public void calculateInterest()
        {
            Console.WriteLine("Interst  in HDFC: {0}", (i + p + r) / 100);
        }
    }
    public class SBI : Class4
    {
        public SBI()
        {
            i = 2; p = 2;r= 2;
        }
        public void calculateInterest()
        {
            Console.WriteLine("Interst in SBI : {0}", (i + p + r) / 100);
        }
    }
    public class ICICI : Class4
    {
        public ICICI()
        {
            i = 3;p = 3;r = 3;
        }
        public void calculateInterest()
        {
            Console.WriteLine("Interst in ICICI : {0}", (i + p + r) / 100);
        }
    }
}
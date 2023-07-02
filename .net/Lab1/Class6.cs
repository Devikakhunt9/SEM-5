using System;

namespace ConsoleApp1
{
    internal class Class6
    {
        double p, r, n;
        public Class6()
        {
            
        }
        public void getDetails()
        {
            Console.WriteLine("Enter P :");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter R :");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter N :");
            n = Convert.ToDouble(Console.ReadLine());
        }

        public void intrest() 
        {
            Console.WriteLine("Simple Intrest : {0}", (p * r * n) / 100);
        }
    }
}
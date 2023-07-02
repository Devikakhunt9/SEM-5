using System;

namespace ConsoleApp3
{
    internal class Class9
    {
         public  static double p, r, n;
        public Class9()
        {
         
        }

        public void getDetail()
        {
            Console.WriteLine("Enter P:");
            p  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter R :");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter N :");
            n = Convert.ToDouble(Console.ReadLine());
        }
    }
    class Intrest : Class9 { 
        public Intrest()
        {

        }
        public  void displayDetail()
        {
            Console.WriteLine("P : {0}\nR : {1}\nN : {2}",p,r,n);
        }

        public void intrest()
        {
            Console.WriteLine("Intrest : {0}", (p * r *n)/100);
        }
    }
}
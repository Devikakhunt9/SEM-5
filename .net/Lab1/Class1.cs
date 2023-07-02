using System;

namespace ConsoleApp1
{
    internal class Class1
    {
        static int a, b;
        public Class1()
        {
        }
        public void getDetails()
        {
            Console.WriteLine("Enter NO:");
             a  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter NO:");
             b  = Convert.ToInt32(Console.ReadLine());   
        }
        public void printDetails()
        {
            Console.WriteLine("{0},{1}",a,b);
        }
    }
}
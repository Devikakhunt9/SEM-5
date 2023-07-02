using System;

namespace ConsoleApp1
{
    internal class Class8
    {
        int a, b, c;
        public Class8()
        {
        }
        public void getDetail()
        {
            Console.WriteLine("Enetr A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr C:");
            c = Convert.ToInt32(Console.ReadLine());
        }
        public void maxOf3()
        {
            if (a > b && a>c)
            {
                Console.WriteLine("Maximum :{0}",a);
            }
            else if(b > c && b>a)
            {
                Console.WriteLine("Maximum :{0}", b);
            }
            else
            {
                Console.WriteLine("Maximum:{0}", c);
            }
        }
    }
}
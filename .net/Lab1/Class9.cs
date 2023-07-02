using System;

namespace ConsoleApp1
{
    internal class Class9
    {
        int a, b;
        public Class9()
        {
        }
        public void getDetail()
        {
            Console.WriteLine("Enetr A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr B:");
            b = Convert.ToInt32(Console.ReadLine());
            
        }
        public void swap()
        {
            Console.WriteLine("Before Swapping : {0},{1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping : {0},{1}",a,b);
        }

       
    }
}
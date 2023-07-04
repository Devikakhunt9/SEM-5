using System;

namespace ConsoleApp4
{
    public interface Calculate2
    {
         void addition();
        void substraction();
    }
    internal class Class5 : Calculate2
    {
        public static int a, b;
        public Class5()
        {
        }
        public void getDetails()
        {
            Console.WriteLine("Enter A :");
             a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B :");
             b = Convert.ToInt32(Console.ReadLine());
        }
       public  void addition()
        {
           
            Console.WriteLine("ANS(addition) : {0}", a + b);
        }

         public void substraction()
        {

            Console.WriteLine("ANS(substraction) : {0}", a - b);
        }
    }
}
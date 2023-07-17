using System;
namespace ConsoleApp5
{
    public  class Class6
    {
        public delegate void factorial (int a);
        int mul = 1;
        public Class6()
        {
        }
        public void fact(int a)
        {
            for(int i = 1;i<= a; i++)
            {
                mul *= i;
            }
            Console.WriteLine("Factorial : {0}", mul);
        }
    }
}
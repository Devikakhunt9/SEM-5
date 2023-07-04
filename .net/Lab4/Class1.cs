using System;

namespace ConsoleApp4
{
    internal class Class1
    {
        public Class1()
        {
        }
        public void getError()
        {
            try
            {
                Console.WriteLine("Enter A :");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter B :");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b!=0)
                {
                    Console.WriteLine("ANS :{0}", a / b);
                }
                else
                {
                    throw new DivideByZeroException();
                }

            }
            catch (DivideByZeroException e) {
            Console.WriteLine(e.ToString());
            }
        }
    }
}
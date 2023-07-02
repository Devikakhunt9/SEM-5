using System;

namespace ConsoleApp1
{
    internal class Class2
    {
       static String n, c;
        public Class2()
        {
           
        }
        public void getDetail()
        {
            Console.WriteLine("Enter Your Name :");
            n = Console.ReadLine();
            Console.WriteLine("Enter Your Contry Name :");
            c = Console.ReadLine();

        }
        public void setDetail()
        {
            Console.WriteLine("Hello {0} from {1}", n, c);
        }
    }
}
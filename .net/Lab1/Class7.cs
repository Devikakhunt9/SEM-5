using System;

namespace ConsoleApp1
{
    internal class Class7
    {
        double a, b;
        string op;
        public Class7()
        {
        }
        public void getDetails()
        {
            Console.WriteLine("Enter A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Opration :");
            op = Console.ReadLine();
            Console.WriteLine("Enter B:");
            b = Convert.ToDouble(Console.ReadLine());

        }
        public void calci()
        {
            if (op == "+")
            {
                Console.WriteLine("ANS : {0}",a+b);
            }
            else if (op == "-")
            {
                Console.WriteLine("ANS : {0}", a - b);
            }
            else if(op == "*")
            {
                Console.WriteLine("ANS : {0}", a * b);
            }
            else if (op == "/")
            {
                if (b != 0)
                {
                    Console.WriteLine("ANS : {0}", a / b);
                }
                else
                {
                    Console.WriteLine("Can't divide by ZERO");
                }
            }
            else
            {
                Console.WriteLine("Please Enter Valid Opration ( +,-,,*,/)");
            }
        }
    }
}
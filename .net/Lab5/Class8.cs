using System;
namespace ConsoleApp5
{
    internal class Class8
    {
        //public delegate T calculate<T>(T a, T b );
        public delegate T calculate<T>(params object[] parameters );
        public Class8()
        {
        }
        //public void add(int a,int b)
        //{
        //    Console.WriteLine("SUM : {0}", a + b);
        //}
        //public void add(double a,double b)
        //{ Console.WriteLine("SUM : {0}",a + b); }
        public void all(params object[] parameters)
        {
            if (parameters == null || parameters.Length == 0)
            {
                Console.WriteLine("Enter a Parameter like <Value> <operrtor> <value>");
            }
            else if (parameters[0] is int && parameters[1] is string && parameters[2] is int )
            {
                if ((string)parameters[1] == "+")
                {
                    Console.WriteLine("SUM : {0}", (int)parameters[0] + (int)parameters[1]);
                }
                else if ((string)parameters[1] == "-")
                {
                    Console.WriteLine("SUB : {0}", (int)parameters[0] - (int)parameters[1]);
                }
                else if ((string)parameters[1] == "*")
                {
                    Console.WriteLine("MUL : {0}", (int)parameters[0] * (int)parameters[1]);
                }
                else if ((string)parameters[1] == "/")
                {
                    Console.WriteLine("DIV : {0}", (int)parameters[0] / (int)parameters[1]);
                }
                else
                {
                    Console.WriteLine("Enter a Parameter like <Value> <operrtor> <value>");
                }
            }
            else
            {
                Console.WriteLine("Enter a Parameter like <Value> <operrtor> <value>");
            }
        }
    }
}
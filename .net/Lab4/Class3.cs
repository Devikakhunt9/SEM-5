using System;

namespace ConsoleApp4
{
    public class NotEven : Exception
    {
        public NotEven(String msg):base(msg) { }
    }
    internal class Class3
    {
        public Class3()
        {
        }

        public void raiseError()
        {
            Console.WriteLine("Enter Even No :");
            int a = Convert.ToInt32(Console.ReadLine());
            try { 
                if(a%2!=0)
                {
                    throw new NotEven("NotEvenNo: the number you enter is not even no.");
                }
                else
                {
                    Console.WriteLine("Even no");
                }
            }
            catch(NotEven e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }
    }
}
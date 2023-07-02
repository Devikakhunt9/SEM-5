using System;

namespace ConsoleApp2
{
    internal class Class3
    {
        int a;
        bool b = true;
        public Class3()
        {
        }
        public void prime()
        {
            Console.WriteLine("Enter No:");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i < a/2; i++) 
            { 
                if(a%i == 0)
                {
                    b = !b; ;
                    break;
                }
            }
            if (b)
            {
                Console.WriteLine("Prime");
            }
            else Console.WriteLine("Not Prime");
        }
    }
}
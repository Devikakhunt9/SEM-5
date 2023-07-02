using System;

namespace ConsoleApp2
{
    internal class Class4
    {
        public Class4()
        {
        }
        public void leapYear()
        {
            Console.WriteLine("Enter Year");
            int y = Convert.ToInt32(Console.ReadLine());
            if(((y%4 == 0 )&&(y%100 != 0)) || (y % 400 == 0))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
        }
    }
}
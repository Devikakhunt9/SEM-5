using System;

namespace ConsoleApp1
{
    internal class Class5
    {
        double c, f;
        public Class5()
        {
        }
        public void getDetails()
        {
            Console.WriteLine("Enter Celcius:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Fehranhit:");
            f = Convert.ToDouble(Console.ReadLine());
        }
        public void ctof()
        {
            Console.WriteLine("Fehranhit:{0}",(c * 9 / 5) + 32);
        }
        public void ftoc()
        {
            Console.WriteLine("Celcius :{0}", ((f - 32) * 5) / 9);
        }
    }
}
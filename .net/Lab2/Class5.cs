using System;

namespace ConsoleApp2
{
    internal class Class5
    {
        int sum = 0,temp1 =0,temp2 = 1;
        public Class5()
        {
        }
        public void fibbonaci()
        {
            Console.WriteLine("Enter Term of Fibbonacci Series : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0},{1},",temp1,temp2);
            for(int i = 2; i < n; i++)
            {
                sum = temp1 + temp2;
                Console.Write("{0},",sum);
                temp1 = temp2;
                temp2 = sum;

            }
            Console.WriteLine("...");
        }


    }
}
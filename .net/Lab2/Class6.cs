using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class Class6
    {
        public Class6()
        {
        }
        public void binary()
        {
            Console.WriteLine("Enter NO:");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            string rem="";
            while (temp != 0)
            {
                rem = rem +Convert.ToString(temp%2); 
                temp = temp / 2;
            }
            char[] arr = rem.ToCharArray();
            Array.Reverse(arr);
            string rev = new string(arr);
            Console.WriteLine(rev);
        }
    }
}
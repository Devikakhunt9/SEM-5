using System;

namespace ConsoleApp2
{
    internal class Class7
    {
        public Class7()
        {
        }
        public int numenetor(int n )
        {
            int mul = 1;
            for(int i = 1; i <=n; i++)
            {
                mul *= i;
            }
            return ( mul );
        }
        public int denomenetor(int n ,int r) 
        { 
            int mul = 1;
            int m = n - r;
            for(int i = 1; i <= m; i++)
            {
                mul *= i;
            }
            return mul ;
        }
        public void permutation()
        {
            Console.WriteLine("Enter n(nPr):");
            int n = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Enter r(nPr):");
            int r = Convert.ToInt32( Console.ReadLine() );
            int a = numenetor( n );
            int b = denomenetor(n,r);
            Console.WriteLine("ANS:{0}",(a/b));
        }
    }
}
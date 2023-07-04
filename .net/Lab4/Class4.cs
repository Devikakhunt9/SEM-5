using System;

namespace ConsoleApp4
{
    internal abstract class Class4
    {
        public Class4()
        {
        }

        public abstract void SumOfThree(int v1, int v2, int v3);


        public abstract void SumOfTwo(int v1, int v2);
    }

     class Calculate : Class4
    {
        public Calculate() { }

        public override void SumOfTwo(int a,int b)
        {
            Console.WriteLine("ANS : {0}", a + b);
        }
        public  override void SumOfThree(int a,int b,int c) {
            Console.WriteLine("ANS : {0}", a + b + c);
        }
    }
}
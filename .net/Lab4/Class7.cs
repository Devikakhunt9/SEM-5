using System;

namespace ConsoleApp4
{
     public  class Class7
    {
        public Class7()
        {
        }

        public void stringMethod(string s)
        {
            Console.WriteLine("Original :{0}",s);
            Console.WriteLine("LOWER :{0}", s.ToLower());
            Console.WriteLine("LENGTH :{0}", s.Length);
            Console.WriteLine("REPLACE :{0}", s.Replace("a","i"));
            Console.WriteLine("UPPER :{0}", s.ToUpper());
            Console.WriteLine("Original :{0}", s);
        }
    }
}
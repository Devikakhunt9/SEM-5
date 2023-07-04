using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Class8
    {
        public Class8()
        {
        }
        public void toLower(string s)
        {

            Console.WriteLine("String:{0} ==> LowerCase : {1}",s,s.ToLower());
        }
        public void toUpper(string s)
        {
            Console.WriteLine("String : {0} ==> UpperCase : {1}", s, s.ToUpper());
            
        }
    }
}
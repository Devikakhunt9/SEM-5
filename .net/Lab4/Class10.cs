using System;

namespace ConsoleApp4
{
    internal class Class10
    {
        public Class10()
        {
        }

        public void invert(string v)
        {
            string str = "";
           var arr = v.ToCharArray();
            foreach (char c in arr)
            {
                if (Char.IsUpper(c))
                {
                    str += c.ToString().ToLower();
                }
                else
                {
                    str += c.ToString().ToUpper();
                }
            }
            Console.WriteLine("Original : {0} ==> Invert : {1}",v,str);
        }
    }
}
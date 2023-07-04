using System;

namespace ConsoleApp4
{
    internal class Class9
    {
        string s,word="";
        int max = 0;
        public Class9()
        {
        }
        public void getString()
        {
            Console.WriteLine("Enter String :");
            s = Console.ReadLine();
        }
        public void findMaxWord()
        {
            var str = s.Split(' ');
            foreach (var item in str)
            {
                if (item.Length > max)
                {
                    max = item.Length;
                    word = item;
                }
            }
            Console.WriteLine("Maximum Word: {0}", word);
        }
    }
}
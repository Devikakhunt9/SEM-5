using System;
using System.Collections.Generic;
namespace ConsoleApp6
{
    internal class Class2
    {
        public Class2()
        {
        }

        internal void aList()
        {
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            l.Add(6);
            l.Add(7);
            l.Add(8);
            l.Add(9);
            l.Add(10);
            l.Add(11);
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
            l.Remove(1);
            l.RemoveRange(1, 2);

            Console.WriteLine("CLear:{0}",l.Count);
            l.Clear();
            

        }
    }
}
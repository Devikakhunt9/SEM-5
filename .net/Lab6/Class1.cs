
using System;
using System.Collections;

namespace ConsoleApp6
{
    internal class Class1
    {
        public Class1()
        {

        }
        public void arrList()
        {
            ArrayList a = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                a.Add(i+1);
            }
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Remove 1");
            a.Remove(1);
            foreach (int i in a)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("---------------------------------------------\nRemove 2,1");
            a.RemoveRange(1,1);


            foreach (int i in a)
            {
                Console.WriteLine(i);

            }
            a.Reverse();
            Console.WriteLine("After Reverse : ");
            foreach (int i in a)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Count : {0}\nCapacity :{1} ", a.Count, a.Capacity);
        }
    }
}
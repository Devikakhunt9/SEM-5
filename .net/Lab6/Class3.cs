using System;
using System.Collections;

namespace ConsoleApp6
{
    internal class Class3
    {
        public Class3()
        {
        }

        internal void aStack()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Push(6);
            s.Push(7);
            s.Push(8);
            s.Push(9);
            s.Push(10);
            Console.WriteLine("-------------------------------------------");
            foreach (var x in s)
            {
                Console.WriteLine(x.ToString());
            }
            s.Pop();
            s.Pop();
            Console.WriteLine("-------------------------------------------");
            foreach (var x in s)
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine("Peek Element : {0}",s.Peek());
            Console.WriteLine("Contains Element : {0}",s.Contains(2));
            Console.WriteLine("Clear : {0}", s.Count);

            s.Clear();
            Console.WriteLine("Clear : {0}", s.Count);

        }
    }
}
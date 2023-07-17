using System;
using System.Collections;

namespace ConsoleApp6
{
    internal class Class4
    {
        public Class4()
        {
        }

        internal void aQ()
        {
           Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
                q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            q.Enqueue(8);
            q.Enqueue(9);
            q.Enqueue(10);

            foreach (var x in q)
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine("---------------------------------------------");
            q.Dequeue();
            q.Dequeue();
            foreach (var x in q)
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Peek Element : {0}",q.Peek());
            Console.WriteLine("Contains : {0}",q.Contains(5));
            Console.WriteLine("Count : {0}", q.Count);
            q.Clear();
            Console.WriteLine("After Clear => Count : {0}", q.Count);
        }
    }
}
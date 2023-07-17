using System;
namespace ConsoleApp5
{
    internal class Class7
    {
        public delegate void TrafficDel();
        public Class7()
        {
        }
        public  void yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }
        public  void green()
        {
            Console.WriteLine("Green Light Signal To Go");
        }
        public  void red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }

    }

}
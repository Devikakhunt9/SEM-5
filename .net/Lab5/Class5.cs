using System;

namespace ConsoleApp5
{
    internal class Class5
    {
        public Class5()
        {
        }

        internal void hospitalDetails()
        {
            Console.WriteLine("This is the Main Hospital");
        }
    }
    class Apollo : Class5 
    {
        public Apollo()
        {

        }
        public void hospitalDetails()
        {
            Console.WriteLine("This is the Apollo Hospital");
        }
    }
    class Wockhardt : Class5
    {
        public Wockhardt()
        {

        }
        public void hospitalDetails()
        {
            Console.WriteLine("This is the Wockhardt Hospital");
        }
    }

    class Gokul_Superspeciality : Class5
    {
        public Gokul_Superspeciality()
        {

        }
        public void hospitalDetails()
        {
            Console.WriteLine("This is the Gokul_Superspeciality Hospital");
        }

    }
}
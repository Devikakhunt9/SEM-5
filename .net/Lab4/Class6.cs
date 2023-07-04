using System;

namespace ConsoleApp4
{
    public interface Shape
    {
        void Circle();
        void Triangle();
        void Square();
    }
    internal class Class6:Shape
    {
        double r, b, h, l;
        public Class6()
        {
        }
        public void getDetails()
        {
            Console.WriteLine("Enter Radius of Circle :");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Base of Triangle :");
            b = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Enter Height of Triagle :");
            h = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Enter Length of Square :");
            l = Convert.ToDouble(Console.ReadLine());
        }

        public void Circle()
        {
            Console.WriteLine("Area Of Circle : {0}", 3.14 * r * r);   
        }

        public void Square()
        {
            Console.WriteLine("Area Of Square:{0}", l * l);        
        }

       public  void Triangle()
        {
            Console.WriteLine("Area Of Triangle : {0}", 0.5 * b * h);
        }
    }
}
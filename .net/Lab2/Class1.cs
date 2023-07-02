using System;

namespace ConsoleApp2
{
    internal class Class1
    {
        double height, weight;
        public Class1()
        {
        }
        public void getDetails()
        {
            Console.WriteLine("Enter Ur Height(inches) :");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Ur Weight(pounds)");
            weight = Convert.ToDouble(Console.ReadLine());
        }
        public void bmi() 
        {
            Console.WriteLine("BMI : {0}", (weight * 0.45359237)/(height * 0.0254)*(height * 0.0254));
        }
    }
}
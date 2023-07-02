using System;

namespace ConsoleApp2
{
    internal class Class2
    {
        int sum = 0;
        public Class2()
        {
        }
        public void getDetails()
        {
            int[] marks =  new int[5];
           for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Subject {0} Marks(100) : ", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
           foreach(int i in marks)
            {
                sum += i;
            }
        }

        public void grade()
        {
            if((sum / 5) >= 60)
            {
                Console.WriteLine("First Class");
            }
            else if((sum / 5) >=50 && (sum / 5) <= 59)
            {
                Console.WriteLine("Second Class");
            }
            else if((sum/5)>=40 && (sum / 5) <= 49)
            {
                Console.WriteLine("Third Class");
            }
            else
            {
                Console.WriteLine("Poor Grade");
            }
        }
    }
}
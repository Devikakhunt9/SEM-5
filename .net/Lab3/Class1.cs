using System;

namespace ConsoleApp3
{
    internal class Class1
    {
        int cID, cAge;
        string cName;
        double cHeight, cWeight;
        public Class1()
        {
        }
        public void getDetails()
        {
            Console.WriteLine("Enter Candidate ID :");
            cID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Candidate Name :");
            cName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Candidate Age :");
            cAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Candidate Height :");
            cHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Candidate Weight :");
            cWeight = Convert.ToDouble(Console.ReadLine());
        }

        public void displayDetail()
        {
            Console.WriteLine("======================================================\nID:{0}\nName:{1}\nAge:{2}\nWeight:{3}\nHeight:{4}", cID, cName, cAge, cWeight, cHeight);
        }
    }
}
using System;

namespace ConsoleApp3
{
    internal class Class3
    {
        double acNo, balance;
        string email, name, acType;
        public Class3()
        {
        }

        public void  getAccountDetails()
        {
            Console.WriteLine("Enter Account No :");
            acNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Email :");
            email = Console.ReadLine();
            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Type :");
            acType = Console.ReadLine();
            Console.WriteLine("Enter Balance :");
            balance = Convert.ToDouble(Console.ReadLine());

        }


        public void displayAccountDisplay()
        {
            Console.WriteLine("========================\nAccount NO : {0}\nEmail : {1}\nName : {2}\nAccount Type : {3}\nBalance : {4}",acNo,email,name,acType,balance);
        }
    }
}
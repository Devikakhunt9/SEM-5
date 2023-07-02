using System;

namespace ConsoleApp3
{
    internal class Class2
    {
        string name,post;
        public Class2()
        {
        }
        public  void myStart()
        {
            Class2[] c = new Class2[5];
            for (int i = 0; i < 5; i++)
            {
                c[i] = new Class2();
                c[i].getDetails(c[i]);
            }
            Console.WriteLine("==========================");
            for (int i = 0; i < 5; i++)
            {
                c[i].displayDetails(c[i]);
            }

        }
        public void getDetails(Class2 c)
        {
            
                Console.WriteLine("Enter Name :");
                c.name = Console.ReadLine();
                Console.WriteLine("Enter Post:");
                c.post = Console.ReadLine();
            
        }
        public void displayDetails(Class2 c)
        {
            if(c.post.ToLower() == "host")
            {
                Console.WriteLine("Name : "+c.name + " " +"Post :"+ c.post);
            }
        }
    }
}
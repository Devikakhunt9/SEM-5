using System;

namespace ConsoleApp3
{
    internal class Class10 : Salary,Gross
    {
        string name;
        double hra, ta, da;
        static double  salary;
        public Class10()
        {
        }
        public void get_detail()
        {
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter HRA : ");
            hra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter TA :");
            ta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter DA : ");
            da = Convert.ToDouble(Console.ReadLine());
        }
        public void basic_sel() 
        {
            salary = ta + da + hra;
            Console.WriteLine("Basic Salary : {0}", salary);
        }
        public void display_sel() {
            salary += 15;
            Console.WriteLine("NAME : {1}\nSALARY : {0}", salary, name);

        }
        public void gross_sel() {
            salary -= 10;
            Console.WriteLine("Gross Salary : {0}", salary);
        }
    }
    public interface Salary
    {
        void display_sel();
    }
    public interface Gross
    {

         void gross_sel();
      
    }
}
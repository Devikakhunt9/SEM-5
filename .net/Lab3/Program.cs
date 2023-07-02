using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.getDetails();
            c1.displayDetail();


            Class2 c2 = new Class2();
            c2.myStart();

            Class3 c3 = new Class3();
            c3.getAccountDetails();
            c3.displayAccountDisplay();


            Class4 c4 = new Class4(12345678, "devika", 5, 5.98, 6.69);
            c4.memeber();

            Class5 c5 = new Class5();
            Class5 c51 = new Class5(45, 50, 100);
            c5.salary();
            c51.salary();


            Class6 c6 = new Class6(5, 6);
            c6.displayAddition();

            Class7 c7 = new Class7(5, 4);
            c7.area();

            Class8 c8 = new Class8();
            c8.displayDetail();
            Console.WriteLine("===================");
            Table t = new Table();
            t.displayDetail();
            t.dispaly();


            Class9 c9 = new Class9();
            c9.getDetail();
            Intrest i = new Intrest();
            i.displayDetail();
            i.intrest();

            Class10 c10 = new Class10();
            c10.get_detail();
            c10.basic_sel();
            c10.display_sel();
            c10.gross_sel();
        }
    }
}

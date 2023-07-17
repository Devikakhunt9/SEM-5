using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.add(4, 5);
            c1.add(1.2, 3.4);

            Class2 c2 = new Class2();
            c2.area(5);
            c2.area(1,2);


            Class3 c3 = new Class3();
            c3.area(1, 2);
            c3.area("Circle", 5);
            c3.area("Sqaure", 5);
            c3.area(1.1, 2.2);


            Class4 c4 = new Class4();
            c4.calculateInterest();
            HDFC h = new HDFC();
            h.calculateInterest();
            SBI s = new SBI();
            s.calculateInterest();
            ICICI i = new ICICI();
            i.calculateInterest();


            Class5 c5 = new Class5();
            c5.hospitalDetails();
            Apollo a = new Apollo();
            a.hospitalDetails();
            Wockhardt w = new Wockhardt();
            w.hospitalDetails();
            Gokul_Superspeciality g = new Gokul_Superspeciality();
            g.hospitalDetails();

            Class6 c6 = new Class6();
            Class6.factorial f = new Class6.factorial(c6.fact);
            f(5);

            Class7 c7 = new Class7();
            Class7.TrafficDel t1 = new Class7.TrafficDel(c7.yellow);
            Class7.TrafficDel t2 = new Class7.TrafficDel(c7.green);
            Class7.TrafficDel t3 = new Class7.TrafficDel(c7.red);
            t1();
            t2();
            t3();

            Class8 c8 = new Class8();
            Class8.calculate<object> c = new Class8.calculate<object>(c8.all);
            c(10,"+",10);

        }
    }
}

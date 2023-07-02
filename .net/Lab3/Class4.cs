using System;

namespace ConsoleApp3
{
    internal class Class4
    {
        //Enrollment_No, Student_Name, Semester, CPI and SPI
        double ern,spi,cpi;
        string name;
            int sem;
        public Class4(double ern, string name, int sem,double spi,double cpi)
        {

            this.ern = ern;
            this.spi = spi;
            this.cpi = cpi;
            this.name = name;
            this.sem = sem;
        }

        public void memeber()
        {
            Console.WriteLine("===================================\nEnrollment No:{0}\nName : {1}\nSemester : {2}\nCPI : {3}\nSPI : {4}",ern,name,sem,cpi,spi);
        }
    }
}
using System;

namespace ConsoleApp4
{
    internal class Class2
    {
        public Class2()
        {
        }
        public void raiseError()
        {
            try
            {
                int[] arr = new int[5];
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("Enter Elemenet:");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
    
}
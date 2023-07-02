using System;

namespace ConsoleApp3
{
    public class Class8
    {
        string material;
        double prize;
        public Class8()
        {
            this.material = "abc";
            this.prize = 100;
        }
        public void displayDetail()
        {
            Console.WriteLine("Material : {0}\nPrize : {1}", material, prize);
        }
    }
    public class Table : Class8
    {
        double height;
        string surface;
        public Table() 
        {
            this.height = 100;
            this.surface = "def";
        }
        public void dispaly()
        {
            Console.WriteLine("Height : {0}\nSurface : {1}",height,surface);
        }
    }
}
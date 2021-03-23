using System;

namespace detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool isInside = (x * * + y * y <= 5) ? true : false;
            Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", x, y, isInside);
        }
    }
}

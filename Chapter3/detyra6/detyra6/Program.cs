using System;
namespace Area_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, w;
            Console.Write("Enter the length of Rectangle: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width of Rectangle: ");
            w = Convert.ToInt32(Console.ReadLine());
            int area = l * w;
            int peri = (2 * l) + (2 * w);
            Console.WriteLine("Area of Rectangle is = {0}" , area);
            Console.WriteLine("Perimeter of Rectangle is = {0}", peri);
            Console.ReadKey();

        }
    }
}

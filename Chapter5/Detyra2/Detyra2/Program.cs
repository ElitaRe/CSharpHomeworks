using System;

namespace Detyra2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number one:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number two:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number three:");
            double c = double.Parse(Console.ReadLine());

            if ((a < 0 && b > 0 && c > 0) || (b < 0 && a > 0 && c > 0) || (c < 0 && a > 0 && b > 0) || (a < 0 && b < 0 && c < 0))
            {
                Console.WriteLine("The sign of the product is - .");
            }
            else if ((a < 0 && b < 0 && c > 0) || (a < 0 && c < 0 && b > 0) || (b < 0 && c < 0 && a > 0) || (a > 0 && b > 0 && c > 0))
            {
                Console.WriteLine("The sign of the product is + .");
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The product is 0 .");
            }
        }
    }
}

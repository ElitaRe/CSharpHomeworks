using System;

namespace Detyra3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Number 1");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Number 2");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Number 3");
            int c = Int32.Parse(Console.ReadLine());

            if (a > b)
                if (a > c) Console.WriteLine("A is the biggest");
                else if (a < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("A and C are the biggest");

           else if (a < b)
                if (b > c) Console.WriteLine("B is the biggest");
                else if (b < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("B and C are the biggest");

            if (a == b)
                if (a == c) Console.WriteLine("All are equal");
                else if (a < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("First and second numbers are the biggest");
        }
    }
}

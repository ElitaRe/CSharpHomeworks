using System;

namespace Detyra5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) counter++;
            }

            Console.WriteLine("{0} numbers found.", counter);
        }
    }
}

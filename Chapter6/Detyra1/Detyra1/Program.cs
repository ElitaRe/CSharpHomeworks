using System;

namespace Detyra1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please write your number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}

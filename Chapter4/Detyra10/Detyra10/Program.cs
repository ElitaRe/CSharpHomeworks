using System;

namespace Detyra10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Enter number: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

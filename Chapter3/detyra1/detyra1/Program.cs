using System;

namespace detyra1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Give a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }

    }
}

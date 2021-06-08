using System;

namespace detyra13
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 10;

            int number3;
            number3 = number1;
            number1 = number2;
            Console.WriteLine(number1);
            Console.WriteLine(number3);
        }
    }
}

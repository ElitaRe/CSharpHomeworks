using System;

namespace detyra13
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr1 = 5;
            int nr2 = 10;

            int ph = nr2;

            nr2 = nr1;
            nr1 = ph;

            Console.WriteLine(nr1);
            Console.WriteLine(nr2);
        }
    }
}

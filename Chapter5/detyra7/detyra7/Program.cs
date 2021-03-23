using System;

namespace detyra7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number: ");
            int nr1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            int nr2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Third number: ");
            int nr3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Fourth number: ");
            int nr4 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Fifth number: ");
            int nr5 = Int32.Parse(Console.ReadLine());

            if ((nr1 >= nr2) && (nr1 >= nr3) && (nr1 >= nr4) && (nr1 >= nr5))
                Console.WriteLine("First number if the biggest", nr1);

            if ((nr2 >= nr1) && (nr2 >= nr3) && (nr2 >= nr4) && (nr2 >= nr5))
                Console.WriteLine("Second number if the biggest", nr2);

            if ((nr3 >= nr1) && (nr3 >= nr2) && (nr3 >= nr4) && (nr3 >= nr5))
                Console.WriteLine("Third number if the biggest", nr3);

            if ((nr4 >= nr1) && (nr4 >= nr2) && (nr4>= nr3) && (nr4 >= nr5))
                Console.WriteLine("Fourth number if the biggest", nr4);

            if ((nr5 >= nr1) && (nr5 >= nr2) && (nr5 >= nr3) && (nr5 >= nr4))
                Console.WriteLine("Fifth number if the biggest", nr5);

        }
    }
}

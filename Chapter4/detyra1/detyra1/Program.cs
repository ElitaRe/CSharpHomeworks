using System;

namespace detyra1
{
    class Program
    {
       static void Main(string[] args)
{
    Console.Write("Enter number 1: ");
    int a = Int32.Parse(Console.ReadLine());
    Console.Write("Enter number 2: ");
    int b = Int32.Parse(Console.ReadLine());
    Console.Write("Enter number 3: ");
    int c = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Result is {0}", a + b + c);
}
    }
}

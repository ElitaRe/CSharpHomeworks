using System;

namespace Detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter variable type (0 - int, 1 - double, 2 string): ");
            int intVar = Int32.Parse(Console.ReadLine());

            switch (intVar)
            {
                case 0:
                    {
                        Console.WriteLine("Enter int variable: ");
                        intVar = Int32.Parse(Console.ReadLine());
                        intVar++;
                        Console.WriteLine("Int variable +1 = {0}", intVar);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Enter int variable: ");
                        double doubleVar = double.Parse(Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine("Double variable +1 = {0}", doubleVar);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter int variable: ");
                        string stringVar = Console.ReadLine();
                        stringVar = stringVar + '*';
                        Console.WriteLine("String variable +* = {0}", stringVar);
                        break;
                    }
                default: Console.WriteLine("Wrong inout"); 
                    break;
            }
        }
    }
}

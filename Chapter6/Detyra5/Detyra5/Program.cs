using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter your number:");
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("Invalid input!");
            return;//we use return to terminate the program if "n" is 0
        }
        else if (n == 1)
        {
            Console.WriteLine(0);
            return;//we use return to terminate the program if "n" is 1
        }

        int x1 = 0;
        int x2 = 1;
        Console.Write("{0} {1} ", x1, x2);//we print the first 2 numbers of the Fibonacci sequence

        for (int i = 2; i < n; i++)//we do the calculation for the numbers ABOVE 2
        {
            int x3 = x1 + x2;
            Console.Write("{0} ", x3);//we use Console.Write INSTEAD OF Console.WriteLine - to glue the above Console.Write - the start of the Fibonacci
            x1 = x2;
            x2 = x3;
        }
        Console.WriteLine();
    }
}


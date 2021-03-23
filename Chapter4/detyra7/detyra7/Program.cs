using System;

public class Program
{
    public static void Main()
    {
        Sum(5);
    }
    
    static void Sum(int numbers)
    {
        int sum = 0;
        for (var i = 1; i <= numbers; i++)
        {
            Console.WriteLine("Please enter number " + i + ":");
            string input = Console.ReadLine();

            int integerInput;
            bool isInteger = int.TryParse(input, out integerInput);

            if (isInteger == false)
            {
                Console.WriteLine("Enter another number");
                continue;
            }
            else
            {
                sum += integerInput;

            }
        }
        Console.WriteLine("The sum is: " + sum);

    }
}
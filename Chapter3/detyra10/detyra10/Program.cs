using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstNumber = (n / 1000) % 10;//divide by 1000 >> then module dividing by 10 to get the 1st number of the 4th digit number
        int secondNumber = (n / 100) % 10;//divide by 100 >> then module dividing by 10 to get the 2nd number of the 4th digit number
        int thirdNumber = (n / 10) % 10;//divide by 10 >> then module dividing by 10 to get the 3rd number of the 4th digit number
        int fourthNumber = (n % 10);//Module dividing by 10 to get the 4th number of the 4th digit number

        //Console.WriteLine("{0},{1},{2},{3}",firstNumber, secondNumber, thirdNumber, fourthNumber);//Check whether it works!

        Console.WriteLine("The sum of the digits is: {0}", firstNumber + secondNumber + thirdNumber + fourthNumber);
        Console.WriteLine("Reversed order: {0}{1}{2}{3}", fourthNumber, thirdNumber, secondNumber, firstNumber);
        Console.WriteLine("Last digit upfront: {0}{1}{2}{3}", fourthNumber, firstNumber, secondNumber, thirdNumber);
        Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", firstNumber, thirdNumber, secondNumber, fourthNumber);
    }
}
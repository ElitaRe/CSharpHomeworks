using System;
 
class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the weight of the person: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("The weight on the moon is: {0}", weight * 17 / 100 );
        }
    }
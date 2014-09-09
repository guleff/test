using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter number to check if it\'s odd or even:");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number {0} is even", number);
        }
        else
        {
            Console.WriteLine("The number {0} is odd", number);
        }
    }
}


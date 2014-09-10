using System;

class IsThirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Enter number to check if third digit from right to left is 7:");
        int number = int.Parse(Console.ReadLine());
        int numberNew = number / 100;
        numberNew %= 10;

        if (numberNew == 7)
        {
            Console.WriteLine("Third digit of number {0} is 7", number);
        }

    }
}


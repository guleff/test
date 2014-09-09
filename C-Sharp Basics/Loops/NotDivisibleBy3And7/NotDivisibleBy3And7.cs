using System;

class NotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("Enter positive number N to get all number not divisible by 3 and 7 to N:");
        uint n = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            bool notDivisible = ((i % 3 != 0) && (i % 7 != 0));
            if (notDivisible == true)
            {
                Console.Write(i + " ");
            }
        }
    }
}


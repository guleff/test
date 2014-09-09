using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter number to get the list from 1 to N:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}


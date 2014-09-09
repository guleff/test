using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter positive numner N to print all number from 1 to N:");
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

class MixMaxSumAverageOfN
{
    static void Main()
    {

        Console.WriteLine("Enter an integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} more integer numbers:", n);
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("min = {0}", array.Min());
        Console.WriteLine("max = {0}", array.Max());
        Console.WriteLine("sum = {0}", array.Sum());
        Console.WriteLine("avg = {0:F2}", array.Average());
    }
}


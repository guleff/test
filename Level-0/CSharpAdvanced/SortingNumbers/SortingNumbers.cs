using System;
using System.Collections.Generic;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] array = { };
        List<int> arr = new List<int>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine();
        arr.Sort();
        foreach (var nums in arr)
        {
            Console.WriteLine(nums);
        }
    }
}


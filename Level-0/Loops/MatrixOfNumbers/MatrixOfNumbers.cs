using System;
using System.Globalization;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        if (n >= 1 && n <= 20)
        {
            for (int i = 1; i <= n; i++)
            {
                int sum = i;
                for (int ii = 1; ii <= n; ii++)
                {
                    Console.Write(sum + " ");
                    sum++;
                    if (ii == n)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("invalid entry");
        }
    }
}


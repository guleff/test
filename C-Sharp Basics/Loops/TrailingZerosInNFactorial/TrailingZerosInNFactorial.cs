using System;
using System.Numerics;

class TrailingZerosInNFactorial
{
    static void Main()
    {
        double n = Convert.ToDouble(Console.ReadLine());
        BigInteger factorialN = 1;
        double result = 0;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }

        for (BigInteger i = factorialN; i % 10 == 0; i /= 10)
        {
            result++;
        }
        Console.WriteLine(result);
    }
}


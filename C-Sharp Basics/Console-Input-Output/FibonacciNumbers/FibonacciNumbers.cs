using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        ulong n = ulong.Parse(Console.ReadLine());
        ulong a = 0;
        ulong b = 1;
        ulong sum;
        Console.Write("0 " + "1 ");
        for (ulong i = 3; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
            Console.Write(sum + " ");
        }
    }
}


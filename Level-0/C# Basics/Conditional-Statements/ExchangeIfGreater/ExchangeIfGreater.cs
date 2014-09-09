using System;
using System.Globalization;

class ExchangeIfGreater
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        double a, b;
        Console.WriteLine("Enter 2 integer numbers:");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine(b + " " + a);
        }
        if (a < b)
        {
            Console.WriteLine(a + " " + b);
        }
        if (a == b)
        {
            Console.WriteLine("Number {0} equals number {1}", a, b);
        }
    }
}


using System;
using System.Globalization;
class NumberComparer
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter two numbers to check which is greater:");
        double a, b;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        Console.WriteLine(a > b && a != b ? a : b);

    }
}


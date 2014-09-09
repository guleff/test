using System;
using System.Globalization;

class SumOf3Numbers
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter 3 real numbers to get their sum:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, a + b + c);
    }
}


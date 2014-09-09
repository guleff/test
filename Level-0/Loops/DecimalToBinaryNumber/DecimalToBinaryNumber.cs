using System;
using System.Globalization;

class DecimalToBinaryNumber
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        long n = long.Parse(Console.ReadLine());
        string binary = "";
        while (n >= 1)
        {
            binary = (n % 2) + binary;
            n /= 2;
        }
        Console.WriteLine(binary);
    }
}

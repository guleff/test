using System;
using System.Globalization;

class CalculatingNFactorialDividedByX
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        double x, n;
        n = Convert.ToDouble(Console.ReadLine());
        x = Convert.ToDouble(Console.ReadLine());
        double factorial = 1;
        double multiplier = 1;
        double sum = 1;

        for (double i = 1; i <= n; i++)
        {
            factorial *= i;
            multiplier *= x;
            double result = factorial / multiplier;
            sum += result;
        }
        Console.WriteLine("{0:F5}", sum);
    }
}



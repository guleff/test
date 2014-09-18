using System;
using System.Globalization;

class CalculatinNFactDividedByKFact
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        double n = Convert.ToDouble(Console.ReadLine());
        double k = Convert.ToDouble(Console.ReadLine());
        double resultN = 1;
        double resultK = 1;

        while (n >= 1)
        {
            resultN *= n;
            n--;

            if (n >= k && k > 0)
            {
                resultK *= k;
                k--;
            }
        }
        Console.WriteLine(resultN / resultK);
    }
}











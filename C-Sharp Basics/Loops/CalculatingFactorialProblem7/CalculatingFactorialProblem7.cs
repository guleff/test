using System;
using System.Globalization;

class CalculatingFactorialProblem7
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        double n = Convert.ToDouble(Console.ReadLine());
        double k = Convert.ToDouble(Console.ReadLine());

        double nMinusK = n - k;
        double factorialN = 1;
        double factorialK = 1;
        double factorialNMinusK = 1;

        if (k >= 1 && k < n && n < 100)
        {
            while (n >= 1)
            {
                factorialN *= n;
                n--;
                if (n >= k && k > 0)
                {
                    factorialK *= k;
                    k--;
                }
            }
            while (nMinusK >= 1)
            {
                factorialNMinusK *= nMinusK;
                nMinusK--;
            }
            Console.WriteLine(factorialN / (factorialK * factorialNMinusK));
        }
        else
        {
            Console.WriteLine("invalid entry");
        }
    }
}


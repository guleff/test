using System;

class CatalanNumbers
{
    static void Main()
    {
        double n = Convert.ToDouble(Console.ReadLine());
        double factorialN = 1;
        double factorialNPlus1 = 1;
        double factorialMultiPly2 = 1;
        if (n > 1 && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                double result = i;
                factorialN *= result;
                result--;

            }
            for (int i = 1; i <= n + 1; i++)
            {
                double result = i;
                factorialNPlus1 *= result;
                result--;

            }
            for (int i = 1; i <= n * 2; i++)
            {
                double result = i;
                factorialMultiPly2 *= result;
                result--;

            }
            double sum = factorialMultiPly2 / (factorialNPlus1 * factorialN);
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("invalid entry");
        }
    }
}


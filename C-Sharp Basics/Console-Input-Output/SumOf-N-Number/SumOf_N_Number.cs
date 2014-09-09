using System;
using System.Globalization;

class SumOf_N_Number
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
            if (i == n)
            {
                Console.WriteLine("The sum of all {0} numbers is {1}", n, sum);
            }
        }
    }
}

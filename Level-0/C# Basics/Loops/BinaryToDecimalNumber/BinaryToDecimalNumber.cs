using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

class BinaryToDecimalNumber
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        BigInteger n = BigInteger.Parse(Console.ReadLine());
        string count = n.ToString();
        double result = 0;
        BigInteger temp = n;
        BigInteger divider = 10;

        for (int i = 0; i < count.Length; i++)
        {
            if (i == 0 && temp % 10 > 0)
            {
                result += 1;
            }
            if (i > 0 && temp % divider > 0)
            {
                result += Math.Pow(2, i);
            }
            temp /= 10;
        }
        Console.WriteLine(result);
    }
}


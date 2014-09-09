using System;
using System.Globalization;

class MultiplicationSign
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter 3 number to get their multiplication sign:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        bool negative = (a < 0 && b > 0 && c > 0) || (b < 0 && a > 0 && c > 0) || (c < 0 && a > 0 && b > 0) || (a < 0 && b < 0 && c < 0);
        bool positive = (a < 0 && b < 0 && c > 0) || (b < 0 && c < 0 && a > 0) || (c < 0 && a < 0 && b > 0) || (a > 0 && b > 0 && c > 0);
        bool zero = (a == 0 || b == 0 || c == 0);

        if (negative == true)
        {
            Console.WriteLine("-");
        }
        else if (positive == true)
        {
            Console.WriteLine("+");
        }
        else if (zero == true)
        {
            Console.WriteLine("0");
        }
    }
}


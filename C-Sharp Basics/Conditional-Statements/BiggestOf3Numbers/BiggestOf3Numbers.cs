using System;
using System.Linq;
using System.Globalization;

class BiggestOf3Numbers
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter 3 numbers and see which one is biggest:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        bool aBiggest = (a > b && a > c);
        bool bBiggest = (b > a && b > c);
        bool cBiggest = (c > a && c > b);

        if (aBiggest == true)
        {
            Console.WriteLine(a);
        }
        else if (bBiggest == true)
        {
            Console.WriteLine(b);
        }
        else if (cBiggest == true)
        {
            Console.WriteLine(c);
        }
        else if (a == b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (a == c && a > b)
        {
            Console.WriteLine(a);
        }
        else if (c == b && c > a)
        {
            Console.WriteLine(c);
        }
        else if (a == b && a < c)
        {
            Console.WriteLine(c);
        }
        else if (a == c && a < b)
        {
            Console.WriteLine(b);
        }
        else if (c == b && c < a)
        {
            Console.WriteLine(a);
        }
        else if (a == b && a == c)
        {
            Console.WriteLine(a);
        }
    }
}


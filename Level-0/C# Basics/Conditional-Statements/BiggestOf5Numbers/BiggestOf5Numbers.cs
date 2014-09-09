using System;
using System.Globalization;

class BiggestOf5Numbers
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        double a, b, c, d, e;
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
        d = Convert.ToDouble(Console.ReadLine());
        e = Convert.ToDouble(Console.ReadLine());

        if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
        {
            Console.WriteLine(a);
        }
        else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
        {
            Console.WriteLine(b);
        }
        else if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
        {
            Console.WriteLine(c);
        }
        else if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
        {
            Console.WriteLine(d);
        }
        else if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
        {
            Console.WriteLine(e);
        }
    }
}


using System;
using System.Globalization;

class Sort3Numbers
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        double a, b, c;
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.Write(a + " ");
            if (b >= c)
            {
                Console.Write(b + " " + c);
            }
            else
            {
                Console.Write(c + " " + b);
            }
        }
        else if (b >= a && b >= c)
        {
            Console.Write(b + " ");
            if (a >= c)
            {
                Console.Write(a + " " + c);
            }
            else
            {
                Console.Write(c + " " + a);
            }
        }
        else if (c >= a && c >= b)
        {
            Console.Write(c + " ");
            if (a >= b)
            {
                Console.Write(a + " " + b);
            }
            else
            {
                Console.Write(b + " " + a);
            }
        }
        Console.WriteLine();
    }
}


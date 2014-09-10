using System;
using System.Globalization;

class QuadraticEquation
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;


        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double d = (b * b) - (4 * a * c);
        double x = ((-b) / (2 * a));
        double x1 = (((-b) - (Math.Sqrt(d))) / (2 * a));
        double x2 = (((-b) + (Math.Sqrt(d))) / (2 * a));

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        if (d == 0)
        {
            Console.WriteLine("x1=2={0}", x);
        }
        if (d > 0)
        {
            Console.WriteLine("x1={0}", x1);
            Console.WriteLine("x2={0}", x2);
        }
    }
}


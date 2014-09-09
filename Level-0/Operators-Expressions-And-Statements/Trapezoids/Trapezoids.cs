using System;
using System.Globalization;
class Trapezoids
{
    static void Main()
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        double a, b, h, area;
        Console.WriteLine("Enter side a:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height:");
        h = Convert.ToDouble(Console.ReadLine());
        area = (h * (a + b)) / 2;

        Console.WriteLine();
        Console.WriteLine("The are of the trapezoid is {0}", area);

    }
}


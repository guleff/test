using System;
using System.Globalization;

class PointInCircle
{
    static void Main()
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        double a, b, x, y, r, o;
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        o = 0;
        a = 0;
        b = 0;
        r = 2;
        bool isInCircle = ((x - a) * (x - a)) + ((y - b) * (y - b)) <= r * r;

        Console.WriteLine(isInCircle ? "The point is inside the circle" : "The point is outside the circle");
    }
}


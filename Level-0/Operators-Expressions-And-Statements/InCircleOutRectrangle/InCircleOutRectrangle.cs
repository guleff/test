using System;
using System.Globalization;

class InCircleOutRectrangle
{
    static void Main()
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter point(x,y) to check if it's inside the circle and outside the rectrangle.");
        double a, b, x, y, r, o;
        Console.WriteLine("Enter value for X:");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for Y:");
        y = double.Parse(Console.ReadLine());
        o = 1;
        a = 1;
        b = 1;
        r = 1.5;
        double top, left, width, height;
        top = 1;
        left = -1;
        width = 6;
        height = 2;
        bool isInCircle = ((x - a) * (x - a)) + ((y - b) * (y - b)) <= r * r;
        bool isInRectrangle = ((x < left) || (y > top)) || ((x > width) || (y > height));

        if (isInCircle == true && isInRectrangle == true)
        {
            System.Console.WriteLine("Yes");
        }
        else
        {
            System.Console.WriteLine("No");
        }
    }
}


using System;
using System.Globalization;

class CirclePerimeterAndArea
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter radius of a circle to get it's perimeter and area:");
        double r = Convert.ToDouble(Console.ReadLine());
        double area = (r * r) * Math.PI;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine("The area of the circle is {0 :00.00}\nThe perimeter of the circle is {1 :00.00}", area, perimeter);

    }
}


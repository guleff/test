using System;
using System.Globalization;
class Rectrangle
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        double weight, height, area, perimeter;
        Console.WriteLine("Enter weight of rectrangle:");
        weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height of rectrangle:");
        height = Convert.ToDouble(Console.ReadLine());
        perimeter = (weight + weight) + (height + height);
        area = height * weight;

        Console.WriteLine("The perimeter of the rectrangle is {0}\nThe area of the rectrangle is {1}", perimeter, area);

    }
}


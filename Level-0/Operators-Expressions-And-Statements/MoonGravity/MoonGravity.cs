using System;
using System.Globalization;



class MoonGravity
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter your weight");
        double weight = double.Parse(Console.ReadLine());
        double moonGravity = 9.80665 / 1.7;
        double moonWeight = weight / moonGravity;
        moonWeight = (float)moonWeight;

        Console.WriteLine("Your weight on the moon will be {0} kg.", moonWeight);


    }
}


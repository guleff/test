using System;
using System.Globalization;

class PlayWithIntDoubleString
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int type = Convert.ToInt32(Console.ReadLine());

        switch (type)
        {
            case 1: Console.WriteLine("Please enter an integer:"); int i = int.Parse(Console.ReadLine()); Console.WriteLine(i + 1); break;
            case 2: Console.WriteLine("Please enter a double:"); double d = double.Parse(Console.ReadLine()); Console.WriteLine(d + 1); break;
            case 3: Console.WriteLine("Please enter a string:"); string s = Console.ReadLine(); Console.WriteLine(s + "*"); break;
            default: Console.WriteLine("invalid entry");
                break;
        }
    }
}


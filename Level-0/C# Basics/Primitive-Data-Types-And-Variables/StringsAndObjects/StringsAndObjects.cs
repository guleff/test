using System;

class StringsAndObjects
{
    static void Main()
    {
        string value1 = "Hello";
        string value2 = "World";
        object finalValue = value1 + " " + value2;
        string result = (string)finalValue;

        Console.WriteLine(result);

    }
}


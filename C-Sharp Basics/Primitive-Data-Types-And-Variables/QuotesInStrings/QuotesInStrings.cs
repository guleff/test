using System;


class QuotesInStrings
{
    static void Main()
    {
        string value1 = "\"use\"";
        string value2 = "quotations causes difficulties.";
        string value3 = "The \"use\" of ";
        string value4 = "quotations causes difficulties.";

        Console.WriteLine("The" + " " + value1 + " of" + " " + value2);
        Console.WriteLine("The {0} of {1}", value1, value2);
        Console.WriteLine(value3 + value4);

    }
}


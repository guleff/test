using System;

class DivideBy7and5
{
    static void Main()
    {
        Console.WriteLine("Enter number to check if it can divide by 5 and 7");
        int number = int.Parse(Console.ReadLine());
        bool divide5 = (number % 5 == 0);
        bool divide7 = (number % 7 == 0);
        bool divide57 = ((number % 5 == 0) && (number % 7 == 0));

        Console.WriteLine(divide57);
    }
}


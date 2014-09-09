using System;

class CheckForPlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter card sign to check if it's valid:");
        var cardSign = Convert.ToString(Console.ReadLine());
        string deuce, three, four, five, six, seven, eight, nine, ten, ace, jack, queen, king;
        deuce = "2";
        three = "3";
        four = "4";
        five = "5";
        six = "6";
        seven = "7";
        eight = "8";
        nine = "9";
        ten = "10";
        ace = "A";
        jack = "J";
        queen = "Q";
        king = "K";

        if (cardSign == deuce)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == three)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == four)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == five)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == six)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == seven)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == eight)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == nine)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == ten)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == ace)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == jack)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == queen)
        {
            Console.WriteLine("Yes");
        }
        else if (cardSign == king)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}


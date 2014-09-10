using System;

class Deck52Cards
{
    static void Main()
    {

        char clubs = (char)5;
        char diamonds = (char)4;
        char hearts = (char)3;
        char spades = (char)6;
        string jack = "J";
        string queen = "Q";
        string king = "K";
        string ace = "A";

        for (int i = 2; i <= 14; i++)
        {

            if (i <= 10)
            {
                Console.WriteLine("{4}{0} {4}{1} {4}{2} {4}{3}", clubs, diamonds, hearts, spades, i);

            }

            switch (i)
            {
                case 11: Console.WriteLine("{4}{0} {4}{1} {4}{2} {4}{3}", clubs, diamonds, hearts, spades, jack); break;
                case 12: Console.WriteLine("{4}{0} {4}{1} {4}{2} {4}{3}", clubs, diamonds, hearts, spades, queen); break;
                case 13: Console.WriteLine("{4}{0} {4}{1} {4}{2} {4}{3}", clubs, diamonds, hearts, spades, king); break;
                case 14: Console.WriteLine("{4}{0} {4}{1} {4}{2} {4}{3}", clubs, diamonds, hearts, spades, ace); break;
                default:
                    break;
            }
        }
    }
}


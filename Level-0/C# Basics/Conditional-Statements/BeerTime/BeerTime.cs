using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter time(in formar hh:mm AM/PM) to check if it's beer time:");
            string userInput = Console.ReadLine();
            DateTime userTime = DateTime.Parse(userInput);
            string beerTimeSetStart = "01:00 PM";
            DateTime beetTimeStart = DateTime.Parse(beerTimeSetStart);
            string beerTimeSetEnd = "03:00 AM";
            DateTime beerTimeEnd = DateTime.Parse(beerTimeSetEnd);

            bool beerTime = ((userTime > beetTimeStart && userTime > beerTimeEnd) || (userTime < beetTimeStart && userTime < beerTimeEnd));

            if (userTime == beetTimeStart)
            {
                Console.WriteLine("beer time");
            }
            else if (beerTime == true)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (System.FormatException)
        {

            Console.WriteLine("invalid time");

        }
    }
}


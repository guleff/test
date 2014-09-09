using System;

class BonusScore
{
    static void Main()
    {

        Console.WriteLine("Enter number");
        int score = Convert.ToInt32(Console.ReadLine());
        bool score1to3 = score >= 1 && score <= 3;
        bool score4to6 = score >= 4 && score <= 6;
        bool score7to9 = score >= 7 && score <= 9;

        if (score1to3 == true)
        {
            Console.WriteLine(score * 10);
        }
        if (score4to6 == true)
        {
            Console.WriteLine(score * 100);
        }
        if (score7to9 == true)
        {
            Console.WriteLine(score * 1000);
        }
        if (score < 1 || score > 9)
        {
            Console.WriteLine("Invalid score");
        }
    }
}


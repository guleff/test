using System;

class RandomNumberInGivenRange
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int min = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());
        Random rnd = new Random();
        if (min <= max)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(rnd.Next(min, max));
            }
        }
        else
        {
            Console.WriteLine("invalid entry");
        }
    }
}


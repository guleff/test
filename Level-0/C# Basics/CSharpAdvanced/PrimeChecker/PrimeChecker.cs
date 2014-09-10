using System;

class PrimeChecker
{
    static void Main()
    {
        PrimeCheck();
    }
    static void PrimeCheck()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(false);
                break;
            }
            if (i == n - 1)
            {
                Console.WriteLine(true);
            }
        }
    }
}


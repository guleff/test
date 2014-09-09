using System;

class PrimeNumberCheck
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        if (n == 0 || n == 1)
        {
            Console.WriteLine(n + " is not prime number");
            Console.ReadLine();
        }
        else
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n
                    % i == 0)
                {
                    Console.WriteLine(n + " is not prime number");
                    return;
                }
            }
            Console.WriteLine(n + " is a prime number");
        }
    }
}


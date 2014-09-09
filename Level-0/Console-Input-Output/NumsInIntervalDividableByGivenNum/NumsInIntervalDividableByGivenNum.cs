using System;

class NumsInIntervalDividableByGivenNum
{
    static void Main()
    {
        Console.WriteLine("Enter 2 positive integer numbers:");
        uint n1 = uint.Parse(Console.ReadLine());
        uint n2 = uint.Parse(Console.ReadLine());
        uint p = 0;

        if ((n1 < n2) && (n1 != n2))
        {
            for (uint i = n1; i <= n2; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("There are {0} numbers dividable by 5 between {1} and {2}", p, n1, n2);
        }
        if ((n1 > n2) && (n1 != n2))
        {
            for (uint i = n2; i <= n1; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("There are {0} numbers dividable by 5 between {1} and {2}", p, n2, n1);
        }
        if (n1 == n2)
        {
            Console.WriteLine("Numbers equal");
        }
    }
}
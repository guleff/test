using System;

class BitExchange
{
    static void Main()
    {
        Console.WriteLine("Enter number for bit exchange:");
        uint n = uint.Parse(Console.ReadLine());
        int p1 = 3;
        int p2 = 4;
        int p3 = 5;
        int p1New = 24;
        int p2New = 25;
        int p3New = 26;
        uint mask1 = n << p1;
        uint mask2 = n << p2;
        uint mask3 = n << p3;
        uint maskNew1 = n << p1New;
        uint maskNew2 = n << p2New;
        uint maskNew3 = n << p3New;
        long bitPos1 = n & mask1;
        long bitPos2 = n & mask2;
        long bitPos3 = n & mask3;
        long bitPosNew1 = n & maskNew1;
        long bitPosNew2 = n & maskNew2;
        long bitPosNew3 = n & maskNew3;

        int mask = 1 << p3;
        long nAndMask = n & mask;
        nAndMask = 1 >> p3;
        nAndMask = 1 << p3New;
        long result = n ^ nAndMask;

        Console.WriteLine("The new number is {0}", result);



        if ((bitPos1 == bitPosNew1 && bitPos2 == bitPosNew2) && (bitPos3 != bitPosNew3))
        {
            if (bitPos3 == 0)
            {



            }

        }
    }
}


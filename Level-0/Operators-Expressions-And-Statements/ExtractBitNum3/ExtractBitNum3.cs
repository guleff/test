using System;


class ExtractBitNum3
{
    static void Main()
    {
        Console.Write("Enter number:");
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int nRightP = n >> p;
        int result = nRightP & 1;


        Console.WriteLine("The bit at possition {0} of number {1} is {2}", p, n, result);
    }

}


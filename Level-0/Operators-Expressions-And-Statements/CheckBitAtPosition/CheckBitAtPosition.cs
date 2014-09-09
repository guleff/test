using System;

class CheckBitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Enter numer:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position of the bit you want to extract:");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int result = nRightP & 1;

        Console.WriteLine(result == 1 ? true : false);




    }
}


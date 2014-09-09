using System;

class ModifyBit
{
    static void Main()
    {
        Console.WriteLine("Enter numer:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position of the bit you want to extract:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter new value of the bit:");
        int v = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bitValue = nRightP & 1;

        if (v == bitValue)
        {
            Console.WriteLine("The number is {0}", n);
        }
        if (v == 1 && bitValue == 0)
        {

            int mask = 1 << p;
            int result = n ^ mask;

            Console.WriteLine("The new number is {0}", result);
        }
        if ((v == 0 && bitValue == 1))
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine("The new number is {0}", result);
        }

    }
}


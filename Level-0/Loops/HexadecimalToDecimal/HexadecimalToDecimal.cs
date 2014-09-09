using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexNum = Console.ReadLine();
        long decimalNumber = 0;
        long bet = 1;
        for (int i = hexNum.Length - 1; i >= 0; i--)
        {
            int num;
            switch (hexNum[i])
            {
                case 'A': num = 10; break;
                case 'B': num = 11; break;
                case 'C': num = 12; break;
                case 'D': num = 13; break;
                case 'E': num = 14; break;
                case 'F': num = 15; break;
                default: num = (int)hexNum[i] - 48; break;
            }
            decimalNumber += num * bet;
            bet *= 16;
        }
        Console.WriteLine(decimalNumber);
    }
}



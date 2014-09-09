using System;

class DecimalToHexadecimal
{
    static void Main()
    {

        long decimalNum = long.Parse(Console.ReadLine());
        string hexNum = "";
        if (decimalNum == 0)
        {
            hexNum = "0";
        }
        else
        {
            while (decimalNum > 0)
            {
                long rest = decimalNum % 16;
                decimalNum /= 16;
                switch (rest)
                {
                    case 10: hexNum = "A" + hexNum; break;
                    case 11: hexNum = "B" + hexNum; break;
                    case 12: hexNum = "C" + hexNum; break;
                    case 13: hexNum = "D" + hexNum; break;
                    case 14: hexNum = "E" + hexNum; break;
                    case 15: hexNum = "F" + hexNum; break;
                    default: hexNum = rest + hexNum; break;
                }
            }
        }
        Console.WriteLine(hexNum);
    }
}


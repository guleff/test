using System;

class FourDigitNumber
{
    static void Main()
    {

        Console.WriteLine("Enter four digit number to play with it:");
        int number = int.Parse(Console.ReadLine());
        int a = (number / 1000) % 10;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;
        int sum = a + b + c + d;


        Console.WriteLine("The sum of all digits in number {0} is {1}", number, sum);
        Console.WriteLine("The reserved order of number {0} is {1}{2}{3}{4}", number, d, c, b, a);
        Console.WriteLine("The last digit of {0} goes at first position makes number {1}{2}{3}{4}", number, d, a, b, c);
        Console.WriteLine("The new number after exchange 2nd and 3rd digit of number {0} will be {1}{2}{3}{4}", number, a, c, b, d);

    }
}


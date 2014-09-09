using System;

class NumberAsWords
{
    static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());

        bool onesIf = (n >= 0) && (n <= 20);
        bool tensIf = (n > 20) && (n < 100);
        bool hundredsIf = (n >= 100) && (n < 1000);

        if (onesIf == true)
        {
            switch (n)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                case 10: Console.WriteLine("Ten"); break;
                case 11: Console.WriteLine("Eleven"); break;
                case 12: Console.WriteLine("Twelve"); break;
                case 13: Console.WriteLine("Thirteen"); break;
                case 14: Console.WriteLine("Fourteen"); break;
                case 15: Console.WriteLine("Fifteen"); break;
                case 16: Console.WriteLine("Sixteen"); break;
                case 17: Console.WriteLine("Seventeen"); break;
                case 18: Console.WriteLine("Eighteen"); break;
                case 19: Console.WriteLine("Nineteen"); break;
                case 20: Console.WriteLine("Twenty"); break;
                default:
                    break;
            }
        }
        else if (n == 100 || n == 200 || n == 300 || n == 400 || n == 500 || n == 600 || n == 700 || n == 800 || n == 900)
        {
            switch (n)
            {
                case 100: Console.WriteLine("One hundred"); break;
                case 200: Console.WriteLine("Two hundred"); break;
                case 300: Console.WriteLine("Three hundred"); break;
                case 400: Console.WriteLine("Four hundred"); break;
                case 500: Console.WriteLine("Five hundred"); break;
                case 600: Console.WriteLine("Six hundred"); break;
                case 700: Console.WriteLine("Seven hundred"); break;
                case 800: Console.WriteLine("Eight hundred"); break;
                case 900: Console.WriteLine("Nine hundred"); break;

                default:
                    break;
            }
        }
        else if (tensIf == true || hundredsIf == true)
        {
            int ones = n % 10;
            int tens = ((n - ones) % 100);
            int hundreds = (n - (n % 100)) / 100;

            if (n > 100 && n < 1000)
            {
                switch (hundreds)
                {
                    case 1: Console.Write("A hundred and "); break;
                    case 2: Console.Write("Two hundred and "); break;
                    case 3: Console.Write("Three hundred and "); break;
                    case 4: Console.Write("Four hundred and "); break;
                    case 5: Console.Write("Five hundred and "); break;
                    case 6: Console.Write("Six hundred and "); break;
                    case 7: Console.Write("Seven hundred and "); break;
                    case 8: Console.Write("Eight hundred and "); break;
                    case 9: Console.Write("Nine hundred and "); break;
                    default:
                        break;
                }
            }

            if ((ones == 0))

                switch (tens)
                {
                    case 20: Console.WriteLine("Twenty"); break;
                    case 30: Console.Write("Thirty"); break;
                    case 40: Console.Write("Fourty"); break;
                    case 50: Console.Write("Fifty"); break;
                    case 60: Console.Write("Sixty"); break;
                    case 70: Console.Write("Seventy"); break;
                    case 80: Console.Write("Eighty"); break;
                    case 90: Console.Write("Ninety"); break;
                    default:
                        break;
                }
            if ((ones > 0))
            {
                switch (tens)
                {
                    case 20: Console.Write("twenty "); break;
                    case 30: Console.Write("thirty "); break;
                    case 40: Console.Write("fourty "); break;
                    case 50: Console.Write("fifty "); break;
                    case 60: Console.Write("sixty "); break;
                    case 70: Console.Write("seventy "); break;
                    case 80: Console.Write("eighty "); break;
                    case 90: Console.Write("ninety "); break;
                    default:
                        break;
                }
                switch (ones)
                {
                    case 1: Console.Write("one"); break;
                    case 2: Console.Write("two"); break;
                    case 3: Console.Write("three"); break;
                    case 4: Console.Write("four"); break;
                    case 5: Console.Write("five"); break;
                    case 6: Console.Write("six"); break;
                    case 7: Console.Write("seven"); break;
                    case 8: Console.Write("eight"); break;
                    case 9: Console.Write("nine"); break;
                    default:
                        break;
                }

                Console.WriteLine();

            }
        }
    }
}



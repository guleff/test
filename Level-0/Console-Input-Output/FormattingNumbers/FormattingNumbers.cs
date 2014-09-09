using System;
using System.Globalization;
using System.Text;

class FormattingNumbers
{
    static void Main()
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        int a = int.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        var bin = Convert.ToString(a, 2);
        string aa = Convert.ToString(a);
        string bb = Convert.ToString(b);
        string cc = Convert.ToString(c);
        if (a >= 0 && a <= 500)
        {
            Console.WriteLine("|{0:X}\t|{3}|\t{1:F2}|{2:F3}", a, b, c, bin.PadLeft(10, '0'));

        }
        else
        {
            Console.WriteLine("Nubmer {0} is not between the given range", a);
        }

    }
}


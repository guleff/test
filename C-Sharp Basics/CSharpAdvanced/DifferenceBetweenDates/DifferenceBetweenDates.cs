using System;
using System.Globalization;

    class DifferenceBetweenDates
    {
        static void Main()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            DateTime date3 = Convert.ToDateTime(date1);
            DateTime date4 = Convert.ToDateTime(date2);
            DateTime result = Convert.ToDateTime(date3.DayOfYear-date4.DayOfYear);
          
            Console.WriteLine(result);
        }
    }


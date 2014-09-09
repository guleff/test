using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Enter your birthday");
            Console.WriteLine("Day:");
            int birthDay= int.Parse(Console.ReadLine());
            Console.WriteLine("Month:");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Year:");
            int birthYear = int.Parse(Console.ReadLine());
        
            int currentDay = DateTime.Now.Day;
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;


            int currentAge = currentYear - birthYear;

            if ((currentMonth>birthMonth))
            {
                Console.WriteLine(currentAge+10);   
            }
            if (((currentMonth==birthMonth) && (currentDay<birthDay)) ||(currentMonth<birthMonth))
            {
                Console.WriteLine("After 10 years will be {0} years old.",currentAge+9);
            }
            

        }
    }


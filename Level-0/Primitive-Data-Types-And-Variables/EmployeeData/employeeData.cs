using System;



class employeeData
{
    static void Main()
    {
        Console.WriteLine("Enter your personal information");
        Console.Write("First name:");
        string firstName = Console.ReadLine();
        Console.Write("Last name:");
        string lastName = Console.ReadLine();
        Console.Write("Age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Gender(eg.m or f)");
        string gender = Console.ReadLine();
        string male = "m";
        string female = "f";
        Console.Write("Personal ID:");
        ulong personalID = ulong.Parse(Console.ReadLine());
        Console.Write("Unique employee number:");
        ulong employeeNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Full name is:{0} {1}" + "\nAge:{2}", firstName, lastName, age);

        if (gender==male || gender==female)
        {
             if (gender == male)
        {
            Console.WriteLine("Gender:male");
        }
        if (gender == female)
        {
            Console.WriteLine("Gender:female");
        }

        }
        else
        {
            Console.WriteLine("You have entered invalid gender");
        }
        Console.WriteLine("Personal ID:{0}", personalID);
        Console.WriteLine("Unique employee number:{0}", employeeNumber);

    }

}


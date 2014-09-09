using System;

class CompanyInfo
{
    static void Main()
    {

        Console.WriteLine("Enter company name:");
        var companyName = Console.ReadLine();
        Console.WriteLine("Enter company address:");
        var companyAddress = Console.ReadLine();
        Console.WriteLine("Enter company phone number:");
        var companyPhone = Console.ReadLine();
        Console.WriteLine("Enter company fax number:");
        var companyFax = Console.ReadLine();
        Console.WriteLine("Web site:");
        var webSite = Console.ReadLine();
        Console.WriteLine("Manager first name:");
        var firstName = Console.ReadLine();
        Console.WriteLine("Manager last name:");
        var lastName = Console.ReadLine();
        Console.WriteLine("Manager age:");
        var age = Console.ReadLine();
        Console.WriteLine("Manager phone number");
        var managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhone);
        Console.WriteLine("Fax: {0}", companyFax);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age:{2}, tel. {3})", firstName, lastName, age, managerPhone);
    }
}


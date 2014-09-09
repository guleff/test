using System;


class BankAccountData
{
    static void Main()
    {


        Console.WriteLine("First name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Middle name:");
        string middleName = Console.ReadLine();
        Console.WriteLine("Last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Bank name :");
        string bankName = Console.ReadLine();
        Console.WriteLine("IBAN");
        string IBAN = Console.ReadLine();
        Console.WriteLine("Available balance:");
        decimal balance = decimal.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Enter credit card #1");
        Console.WriteLine("Credit card type(visa or mastercard)");
        string typeCC1 = Console.ReadLine();
        Console.WriteLine("Credit card number:");
        double cc1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Credit card expire month:");
        int expMonth1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Credit card expire year:");
        int expYear1 = int.Parse(Console.ReadLine());
        Console.WriteLine("CVV code");
        int cvvCode1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine("Enter credit card #2");
        Console.WriteLine("Credit card type(visa or mastercard)");
        string typeCC2 = Console.ReadLine();
        Console.WriteLine("Credit card number:");
        double cc2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Credit card expire month:");
        int expMonth2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Credit card expire year:");
        int expYear2 = int.Parse(Console.ReadLine());
        Console.WriteLine("CVV code");
        int cvvCode2 = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Enter credit card #3");
        Console.WriteLine("Credit card type(visa or mastercard)");
        string typeCC3 = Console.ReadLine();
        Console.WriteLine("Credit card number:");
        double cc3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Credit card expire month:");
        int expMonth3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Credit card expire year:");
        int expYear3 = int.Parse(Console.ReadLine());
        Console.WriteLine("CVV code");
        int cvvCode3 = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Full name:{0} {1} {2}\nBank name:{3}\nIBAN:{4}\nAvailable balance {5}\n",firstName,middleName,lastName,bankName,IBAN,balance);
        Console.WriteLine("CC #1\nCart type:{0}\nCC number:{1}\nExpire date:{2}|{3}\nCVV code:{4}\n",typeCC1,cc1,expMonth1,expYear1,cvvCode1);
        Console.WriteLine("CC #2\nCart type:{0}\nCC number:{1}\nExpire date:{2}|{3}\nCVV code:{4}\n", typeCC2, cc2, expMonth2, expYear2, cvvCode2);
        Console.WriteLine("CC #3\nCart type:{0}\nCC number:{1}\nExpire date:{2}|{3}\nCVV code:{4}", typeCC3, cc3, expMonth3, expYear3, cvvCode3);



    }
}


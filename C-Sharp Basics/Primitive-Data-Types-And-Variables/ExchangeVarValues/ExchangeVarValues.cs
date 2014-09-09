using System;
   
class ExchangeVarValues

    {
        static void Main()
        {

            int a = 5;
            int b = 10;


            Console.WriteLine("The old values of A is {0} and of B is {1}",a,b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("The new value of A is {0} and of B is {1}",a,b);

        }
    }



using System;


    class ComparingFloats
    {
        static void Main()
        {
            float a;
            float b;
            Console.WriteLine("Enter value for number A:");
            var aUnformated = Console.ReadLine();
            a = float.Parse(aUnformated);
            Console.WriteLine("Enter value for number B:");
            var bUnformated = Console.ReadLine();
            b = float.Parse(aUnformated);

            //bool aSmaller = a < b;
            //bool bSmaller = a > b;
            //bool equal = (a == b);

            if (a<b)
            {
                Console.WriteLine("A is smaller than B");
            }
            if (a > b)
            {
                Console.WriteLine("B is smaller than A");
            }
            else
            {
                Console.WriteLine("false");

            }
            
           
                
            

        }
    }


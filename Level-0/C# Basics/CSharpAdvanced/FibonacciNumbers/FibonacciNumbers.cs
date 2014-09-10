using System;

    class FibonacciNumbers
    {
        static void Main()
        {

            Fibonacci();
        }
        static void Fibonacci()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int fibonacci1 = 0;
            int nextFibonacci2 = 0;
            int result = 0;
            for (int i = 0; i < n; i++)
            {

                
                nextFibonacci2 += fibonacci1;
                result = fibonacci1 + nextFibonacci2;
                Console.Write("{0} {1} ",fibonacci1,nextFibonacci2);
                nextFibonacci2 += result;

                
            }
            
            

        }
    }


using System;

    class LongSequence
    {
        static void Main()
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i*(-1));
                }
            }

        }
    }


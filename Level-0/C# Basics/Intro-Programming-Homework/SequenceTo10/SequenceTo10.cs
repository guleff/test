using System;

    class SequenceTo10
    {
        static void Main()
        {
            for (int i = 0; i < 11; i++)
            {
                if (i %2==0)
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


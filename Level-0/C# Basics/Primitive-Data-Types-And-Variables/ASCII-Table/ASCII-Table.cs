using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Table
{
    class Program
    {

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;


            char symbol = '\u00a9';
            Console.WriteLine(symbol);
            for (byte counter = 0; counter < 255; counter++)
            {
                Console.Write((char)counter + "|");
            }

        }
    }
}

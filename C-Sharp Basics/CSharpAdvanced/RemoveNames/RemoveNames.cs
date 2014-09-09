using System;
using System.Linq;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        List<string> allNames = new List<string> { };
        allNames.Add(Console.ReadLine());
        List<string> removeNames = new List<string> { };
        removeNames.Add(Console.ReadLine());
        
        foreach (var finalnames in allNames)
        {

           
            Console.Write("{0} ", finalnames);
        }
        Console.WriteLine();
    }
}


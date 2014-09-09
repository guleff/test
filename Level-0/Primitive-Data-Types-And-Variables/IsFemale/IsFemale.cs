using System;

class IsFemale
{
    static void Main()
    {

        Console.WriteLine("Please enter your gender to check is you female<m or f>");
        char gender = char.Parse(Console.ReadLine());

        bool isFemale = (gender == 'f' || gender == 'F');
        bool isMale = (gender == 'm' || gender == 'M');


        if (isFemale == true)
        {
            Console.WriteLine("Your gender is female.");
        }

        else
        {
            if (isMale == true)
            {
                Console.WriteLine("Your gender is male.");
            }
            else
            {
                Console.WriteLine("You have entered invalid gender value...");
            }

        }



    }


}


using System;
using System.Collections.Generic;
using System.Linq;
class BoolenVariable
{
    static void Main(string[] args)
    {
        bool isFemale = false;
        Console.WriteLine("Are you Female? (Yes/No): ");
        string answer = Console.ReadLine();
        if (answer=="Yes")
        {
            isFemale = true;
            Console.WriteLine("You are Female ");
        }
        else if (answer=="No")
        {
            isFemale = false;
            Console.WriteLine("You are Male ");
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}

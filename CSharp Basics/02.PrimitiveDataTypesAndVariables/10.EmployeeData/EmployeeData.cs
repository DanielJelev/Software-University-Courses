using System;
using System.Collections.Generic;
using System.Linq;
class EmployeeData
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? - ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? - ");
        string lasttName = Console.ReadLine();
        Console.Write("How old are you? - ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("What is your grander? - ");
        string grander = Console.ReadLine();
        Console.Write("Please insert your Personal ID: - ");
        long personalID = long.Parse(Console.ReadLine());
        Random random = new Random();
        int randomNumber = random.Next(27560000, 27569999);
        Console.WriteLine("Your Emplye number is: - " + randomNumber);


    }
}

using System;   
class AgeAfter10Years
{
    static void Main()
    {
        DateTime birthDay; 
        if (DateTime.TryParse(Console.ReadLine(), out birthDay))
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDay.Year; 
            if (birthDay > today.AddYears(-age)) age--;
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }  
        else
        {
            Console.WriteLine("Please enter the birthday in proper format (e.g. dd.mm.yyyy)");
        }
    }
}
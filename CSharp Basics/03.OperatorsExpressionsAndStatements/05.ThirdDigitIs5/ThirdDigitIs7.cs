using System;

class ThirdDigitIs7
{
    static void Main() 
    {
        Console.WriteLine("Enter n =:");
        int n = Math.Abs (int.Parse(Console.ReadLine()));
        Console.WriteLine("Third digit 7 ? ");
        int p = n / 100;

        if (p % 10 == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
        
    }
} 

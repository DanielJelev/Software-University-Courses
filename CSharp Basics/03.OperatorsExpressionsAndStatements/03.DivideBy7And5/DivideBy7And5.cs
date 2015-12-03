using System;

class DivideBy7And5
{
    static void Main(string[] args)
    {
        Console.WriteLine("n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Divided by 7 and 5 ? ");
        bool d = n % 5 == 0 & n % 7 == 0;
        if (d == true)
        {
            Console.WriteLine(true);
            
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
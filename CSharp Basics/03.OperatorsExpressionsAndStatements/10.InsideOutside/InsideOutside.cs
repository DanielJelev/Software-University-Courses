using System;

class InsideOutside
{
    static void Main()
    {
        double Xa = Double.Parse(Console.ReadLine());
        double Ya = Double.Parse(Console.ReadLine());
        double d = Math.Sqrt(Math.Pow(1-Xa,2) + Math.Pow (1-Ya,2));
        bool range =Ya > 1;
        if (d <= 1.5 && range == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }


    }
}
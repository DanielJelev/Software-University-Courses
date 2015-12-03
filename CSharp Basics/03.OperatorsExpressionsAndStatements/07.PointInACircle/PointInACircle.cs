using System;

class PointInACircle
{
    static void Main()
    {
        double Xa = Double.Parse(Console.ReadLine()); 
        double Ya = Double.Parse(Console.ReadLine());
        double d = Math.Sqrt(Math.Pow(0 - Xa, 2) + Math.Pow(0 - Ya, 2));
        if (d>2)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }

    }
}

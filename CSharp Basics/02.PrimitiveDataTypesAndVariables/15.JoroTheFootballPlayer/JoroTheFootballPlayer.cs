using System;

class JoroTheFootballPlayer
{
    static void Main(string[] args)
    {

        string year = Console.ReadLine();
        double p = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double plays = h + (52 - h) * 2 / 3 + (0.5 * p);
        if (year == "t")
        {
            Console.WriteLine(Math.Floor(plays) + 3);
        }
        else if (year == "f")
        {
            Console.WriteLine(Math.Floor(plays));
        }
        else
        {
            Console.WriteLine("incorrect Value");
        }
    }
}
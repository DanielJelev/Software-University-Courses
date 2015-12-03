using System;

class Rectangles
{
    static void Main(string[] args)
    {
        int weight = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        int p = 2 * weight + 2 * height;
        int s = weight * height;
        Console.WriteLine("Perimeter is: " + p);
        Console.WriteLine("Area is: " + s);
}

    }
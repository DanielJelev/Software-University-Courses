using System;

class Trapezoids
{
    static void Main(string[] args)
    {
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double h = Double.Parse(Console.ReadLine());
        double area = (0.5 * (a + b)) * h;
        Console.WriteLine("Perimeter is :" + area);


    }
}

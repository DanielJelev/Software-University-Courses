using System;
class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter a value for radius: r = ");
        double r = double.Parse(Console.ReadLine());
        double area =Math.PI * Math.Pow(r, 2);
        double perimeter = 2 * (Math.PI * r);
        Console.WriteLine("Circle Area is: {0:0.00}",area);
        Console.WriteLine("Circle Perimeter is: {0:0.00}", perimeter);
    }
}

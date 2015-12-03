using System;
class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Write("Enter a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        double b = double.Parse(Console.ReadLine());
        double greater = Math.Max(a, b);
        Console.WriteLine("Greater number is: "+greater);
    }
}

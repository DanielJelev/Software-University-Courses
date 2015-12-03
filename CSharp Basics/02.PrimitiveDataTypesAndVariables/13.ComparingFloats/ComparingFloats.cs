using System;
class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        Console.WriteLine("Enter the first floating number: ");
        double a1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second floating number: ");
        double b1 = double.Parse(Console.ReadLine());
        if (a1 - b1 > eps || b1 - a1 > eps)
        {
            Console.WriteLine(false + "\nThe two numbers are not equal");
        }
        else
        {
            Console.WriteLine(true + "\nThe two numbers are equal");
        }
    }
}
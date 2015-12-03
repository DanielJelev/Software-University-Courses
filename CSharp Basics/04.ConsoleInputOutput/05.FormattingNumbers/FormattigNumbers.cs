using System;
class FormattigNumbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10}| {1,-10:0}|{2,10:00.00}|{3,-10:0.000}|", a.ToString("X"), (Convert.ToString(a, 2)), b, c);        
    }
}

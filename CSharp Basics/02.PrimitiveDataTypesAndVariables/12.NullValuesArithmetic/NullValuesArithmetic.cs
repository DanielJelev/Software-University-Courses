using System;

class NullValueAritmetics
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a += null;
        b += null;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a += 10;
        b += 60;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = 10;
        b = 6;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

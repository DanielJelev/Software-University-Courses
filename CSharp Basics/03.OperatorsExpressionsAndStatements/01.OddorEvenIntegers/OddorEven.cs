using System;

class OddorEven
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }
    }
}
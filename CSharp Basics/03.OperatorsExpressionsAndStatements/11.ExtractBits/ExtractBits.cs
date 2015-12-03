using System;

class ExtractBits
{
    static void Main()
    {
        int p = 3;
        int n = int.Parse(Console.ReadLine());
        int nRightp = n >> p;
        int bit = nRightp & 1;
        Console.WriteLine(bit);
    }
}

using System;

class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int nRightp = n >> p;
        int bit = nRightp & 1;
        Console.WriteLine(bit);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
class PrintTheASCIITable
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 32; i < 255; i++)
        {
            char symbol = (char)i;
            Console.WriteLine(i + " -> " + symbol);

        }
    }
}

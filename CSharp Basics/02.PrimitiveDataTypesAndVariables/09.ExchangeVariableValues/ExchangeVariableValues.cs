using System;
using System.Collections.Generic;
using System.Linq;
class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int c = a;
        a = b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

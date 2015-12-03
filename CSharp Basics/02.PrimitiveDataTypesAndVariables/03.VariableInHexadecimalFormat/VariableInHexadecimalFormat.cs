using System;
using System.Collections.Generic;
using System.Linq;
class VariableInHexadecimalFormat
{
    static void Main(string[] args)
    {
        int number = 254;
        string hexValue = number.ToString("X");
        Console.WriteLine(hexValue);
        char c = '\u0042';
        Console.WriteLine(c);
    }
}

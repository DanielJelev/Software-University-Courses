using System;
using System.Collections.Generic;
using System.Linq;
class UnicodeCharacter
{
    static void Main(string[] args)
    {
        char ch ='\u002A';;
        short number = (short)ch;
        Console.WriteLine(number);
        Console.WriteLine(ch);
    }
}

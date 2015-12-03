using System;
using System.Collections.Generic;
using System.Linq;
class PrintASequance
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 10; i++)
        {
            if (i%2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}
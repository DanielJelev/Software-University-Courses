using System;
using System.Collections.Generic;
using System.Linq;
class PrintLongSequance
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 1001; i++)
        {
            if (i%2==0)
            {
                Console.Write(" "+i);
            }
            else
            {
                Console.Write(" " + -i);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
class Sunglases
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char pipe = '|';
        char dash = '/';
        char space = ' ';
        int insideSpacing = n + (n / 2);
        Console.WriteLine(new string(asterisk, n * 2) + new string(space, n) + new string(asterisk, n * 2));
        for (int i = 0; i < n-2; i++)
        {
            if (i>=n-1)
            {
                Console.WriteLine(asterisk + new string(dash, insideSpacing) + asterisk + new string(space, n) + asterisk + new string(dash, insideSpacing) + asterisk);
            }
            else if (i<=n/2)
            {
                Console.WriteLine(asterisk + new string(dash, insideSpacing) + asterisk + new string(pipe,n) + asterisk + new string(dash, insideSpacing) + asterisk);
            }
            else
            {
                Console.WriteLine(asterisk + new string(dash, insideSpacing) + asterisk + new string(space, n) + asterisk + new string(dash, insideSpacing) + asterisk);
            }
        }
        Console.WriteLine(new string(asterisk, n * 2) + new string(space, n) + new string(asterisk, n * 2));
    }
}

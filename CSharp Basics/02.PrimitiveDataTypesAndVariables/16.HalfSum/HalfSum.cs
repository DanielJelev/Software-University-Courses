using System;
using System.Collections.Generic;
using System.Linq;
class HalfSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum1 += number;
        }
        for (int i = 0; i < n; i++)
        {
            int numbers2 = int.Parse(Console.ReadLine());
            sum2 += numbers2;
        }
        if (sum1==sum2)
        {
            Console.WriteLine("Yes, sum=" + sum2);
        }
        else
        {
            int diff = Math.Abs(sum1 - sum2);
            Console.WriteLine("No, diff=" + diff);
        }
    }
}

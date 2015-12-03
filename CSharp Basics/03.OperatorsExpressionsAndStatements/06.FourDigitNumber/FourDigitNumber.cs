using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int d = n % 10; // 2011 % 10 = 1 => d = 1
        n = n / 10; // n = 2011 / 10 => n = 201
        int c = n % 10; // c = 201 % 10=> c = 1
        n = n / 10; // 201 / 10 = 20 => n = 20
        int b = n % 10;// 20 % 10 = 0 => b = 0
        int a = n / 10; // 20 / 10 = 2

        Console.WriteLine("The Sum is: " +( a+b+c+d ));
        int dcba = (d * 1000 + b * 100 + c * 10 + a);
        Console.WriteLine("dcba is : " + dcba);


   
    }
}

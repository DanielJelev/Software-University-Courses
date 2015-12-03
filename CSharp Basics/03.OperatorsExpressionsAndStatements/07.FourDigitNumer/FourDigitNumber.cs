using System;

class FourDigitNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = n % 10; 
        n = n / 10; 
        int c = n % 10; 
        n = n / 10; 
        int b = n % 10;
        int a = n / 10;

        Console.WriteLine("The Sum is: " + (a + b + c + d)); 
        int dcba = (d * 1000 + c * 100 + b * 10 + a); 
        Console.WriteLine("dcba is : " + dcba); 
        int dabc = (d * 1000 + a * 100 + b * 10 + c); 
        Console.WriteLine("dabc is : " + dabc); 
        int acbd = (a * 1000 + c * 100 + b * 10 + d);
        Console.WriteLine("acbd is : " + acbd);
            




    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());                    
        int p = int.Parse(Console.ReadLine()); 
        uint mask = 1; 
        uint newMask = mask << p; 
        uint check = newMask & n;
        Console.WriteLine(check > 0);
       
        
    }
}
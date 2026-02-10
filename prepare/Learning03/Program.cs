using System;
using System.Runtime.InteropServices;



class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();

        Console.WriteLine(f1.getFractionString());

        Random numerator = new Random();
        Random denominator = new Random();
        for (int i = 0; i < 20; i++)
        {
            f1.SetTop(numerator.Next(1, 100));
            f1.SetBottom(denominator.Next(1, 100));
            f1.getFractionBoth();
        }
    }
}
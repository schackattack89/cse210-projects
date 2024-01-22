using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);
        fraction1.GetFractionString();
        fraction2.GetFractionString();
        fraction3.GetFractionString();

        fraction1.SetTop(1);
        fraction1.SetBottom(1);
        fraction1.GetFractionString();
        Console.WriteLine(fraction1.GetDecimalValue());

        fraction1.SetTop(5);
        fraction1.SetBottom(1);
        fraction1.GetFractionString();
        Console.WriteLine(fraction1.GetDecimalValue());

        fraction1.SetTop(3);
        fraction1.SetBottom(4);
        fraction1.GetFractionString();
        Console.WriteLine(fraction1.GetDecimalValue());

        fraction1.SetTop(1);
        fraction1.SetBottom(3);
        fraction1.GetFractionString();
        Console.WriteLine(fraction1.GetDecimalValue());
    }
}
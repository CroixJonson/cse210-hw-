using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac = new Fraction();
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());

        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        Fraction frac4 = new Fraction(1, 3);
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());
        Random random = new Random();

        Fraction fracrand = new Fraction();

        int i = 0;
        while (i < 20)
        {
            int topfrac = random.Next(1, 100);
            int botfrac = random.Next(1, 100);

            fracrand.SetTop(topfrac);
            fracrand.SetBottom(botfrac);

            Console.Write($"Fraction{i + 1}: ");
            Console.Write($"string:{fracrand.GetFractionString()}");
            Console.WriteLine($" Number:{fracrand.GetDecimalValue()}");


            i++;
        }
        Console.WriteLine("all done!!!");

    }
}
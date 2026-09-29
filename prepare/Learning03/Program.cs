using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        string frac = frac1.GetFractionString();
        double dec = frac1.GetDecimalValue();
        Console.WriteLine(frac);
        Console.WriteLine(dec);

        Fraction frac2 = new Fraction(5);
        string f2 = frac2.GetFractionString();
        double dec2 = frac2.GetDecimalValue();
        Console.WriteLine(f2);
        Console.WriteLine(dec2);

        Fraction frac3 = new Fraction(3, 4);
        string f3 = frac3.GetFractionString();
        double dec3 = frac3.GetDecimalValue();
        Console.WriteLine(f3);
        Console.WriteLine(dec3);

        Fraction frac4 = new Fraction(1, 3);
        string f4 = frac4.GetFractionString();
        double dec4 = frac4.GetDecimalValue();
        Console.WriteLine(f4);
        Console.WriteLine(dec4);

        int i = 1;
        while (i != 21)
        {
            Random rnum = new Random();
            Fraction frac5 = new Fraction();
            int tnum = rnum.Next(1, 100);
            int bnum = rnum.Next(1, 100);
            frac5.SetTop(tnum);
            frac5.SetBottom(bnum);
            string f5 = frac5.GetFractionString();
            double dec5 = frac5.GetDecimalValue();
            Console.WriteLine($"Fraction {i}: String: {f5} Number: {dec5}");
            i++;
        }
    }
}
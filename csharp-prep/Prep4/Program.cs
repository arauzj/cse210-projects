using System;
using System.Numerics;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float number = -1;
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = float.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        float total = 0;
        foreach (float i in numbers)
            {
                total = total + i;
            }
        Console.WriteLine($"The total is {total}");
        float average = total / numbers.Count;
        Console.WriteLine($"The Average is {average}");
        float num2 = 0;
        foreach (float num in numbers)
        {
            if (num2 < num)
            {
                num2 = num;
            }
        }
        Console.WriteLine($"The largest number is {num2}");
    }
}
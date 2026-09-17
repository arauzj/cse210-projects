using System;

class Program
{
    static void Main(string[] args)
    {
        int x;
        DisplayWelcome();
        String name = PromptUserName();
        int number = PromptUserNumber();
        PromptUserBirthYear(out x);
        int square = SquareNumber(number);
        DisplayResult(name, square, x);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        String num = Console.ReadLine();
        int favNum = int.Parse(num);
        return favNum;
    }
    static void PromptUserBirthYear(out int x)
    {
        Console.Write("Please enter the year you were born: ");
        String year = Console.ReadLine();
        int bYear = int.Parse(year);
        x = bYear;
    }
    static int SquareNumber(int num)
    {
        int square = num * num;
        return square;
    }
    static void DisplayResult(string name, int number, int year)
    {
        int yOld = 2026 - year;
        Console.WriteLine($"{name}, the square of your number is {number}.");
        Console.WriteLine($"{name}, you will turn {yOld} this year.");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        String grade = Console.ReadLine();
        String letter = "";
        int number = int.Parse(grade);
        if (number >= 93)
        {
            letter = "A";
        }
        else if (number < 93 && number >= 90)
        {
            letter = "A-";
        }
        else if (number >= 87 && number < 90)
        {
            letter = "B+";
        }
        else if (number <= 86 && number >= 83)
        {
            letter = "B";
        }
        else if (number < 83 && number >= 80)
        {
            letter = "B-";
        }
        else if (number >= 77 && number < 80)
        {
            letter = "C+";
        }
        else if (number <= 76 && number >= 73)
        {
            letter = "C";
        }
        else if (number < 73 && number >= 70)
        {
            letter = "C-";
        }
        else if (number >= 67 && number < 70)
        {
            letter = "D+";
        }
        else if (number <= 66 && number >= 63)
        {
            letter = "D";
        }
        else if (number < 63 && number >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is {letter}");
        if (number >= 70)
        {
        Console.Write("You passed the class!");
        }
        else
        {
        Console.Write("You did not the class! Maybe next time!");
        }
        
    }
}
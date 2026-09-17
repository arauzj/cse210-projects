using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 101);
        int num = -1;
        while (num != 0)
        {
            Console.Write("What is your guess? ");
            String gNumber = Console.ReadLine();
            int number2 = int.Parse(gNumber);
            if (number > number2)
            {
                Console.WriteLine("Higher");
            }
            else if (number < number2)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.Write("You guessed it!");
                num = 0;
            }
        }
    }
}
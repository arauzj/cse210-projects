using System;

class Program
{
    static void Main(string[] args)
    {
        string answer1 = "";
        User user = new User();
        while (answer1 != "6")
        {
            Console.WriteLine($"You have {user.GetPoints()} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("What is your choice?: ");
            string answer = Console.ReadLine();
           

            if (answer == "1")
            {
                user.CreateGoal();
            }
            else if (answer == "2")
            {
                user.ListGoals();
            }
            else if (answer == "3")
            {
                user.SaveGoals();
            }
            else if (answer == "4")
            {
                user.LoadGoals();
            }
            else if (answer == "5")
            {
                user.RecordGoals();
            }
            else
            {
                answer1 = "6";
            }
        }
    }
}
using System;

public class Program
{
    static void Main(string[] args)
    {
        
        
        string answer1 = "";
        while (answer1 != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("What is your choice?: ");
            string answer = Console.ReadLine();
           
            if (answer == "1")
            {
                BreathingActivity Activity1 = new BreathingActivity();
                Activity1.BreatheProgram();
            }
            else if (answer == "2")
            {
                ReflectionActivity Activity2 = new ReflectionActivity();
                Activity2.ReflectProgram();
            }
            else if (answer == "3")
            {
                ListingActivity Activity3 = new ListingActivity();
                Activity3.ListProgram();
            }
            else
            {
                answer1 = "4";
            }
        }
    }
}
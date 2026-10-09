using System.Security.Cryptography;

public class Activity()
{
    private List<string> _animation = new List<string>();
    private List<string> _prompts = new List<string>();
    private int _seconds;
    public void Animation(int num)
    {
        _animation.Add("|");
        _animation.Add("/");
        _animation.Add("-");
        _animation.Add("\\");
        _animation.Add("|");
        _animation.Add("/");
        _animation.Add("-");
        _animation.Add("\\");
        int i = 0;
        DateTime time1 = DateTime.Now;
        DateTime stoptime = time1.AddSeconds(num);

        while (time1 <= stoptime)
        {

            while (i != 8)
            {
                Console.Write(_animation[i]);
                Thread.Sleep(225);
                Console.Write("\b \b");
                i++;

            }
            i = 0;
            time1 = DateTime.Now;

        }
    }
    public void NumAnimation(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write(seconds);
            seconds--;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void CreateActivityList(string activity)
    {
        _prompts = [];
        if (activity == "reflectionPrompt")
        {
            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something truly selfless.");
        }
        else if (activity == "listingPrompt")
        {
            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");
        }
        else if (activity == "reflection")
        {
            _prompts.Add("Why was this experience meaningful to you?");
            _prompts.Add("Have you ever done anything like this before?");
            _prompts.Add("How did you get started?");
            _prompts.Add("How did you feel when it was complete?");
            _prompts.Add("What made this time different than other times when you were not as successful?");
            _prompts.Add("What is your favorite thing about this experience?");
            _prompts.Add("What could you learn from this experience that applies to other situations?");
            _prompts.Add("What did you learn about yourself through this experience?");
            _prompts.Add("How can you keep this experience in mind in the future?");
        }
    }
    public List<string> GetPrompts(string activity)
    {
        CreateActivityList(activity);
        return _prompts;
    }

    public void StartProgram(string activityTitle)
    {
        Console.Clear();
        Console.Write("Loading...");
        Animation(4);

        Console.Clear();
        Console.WriteLine($"Welcome to the {activityTitle} Activity!");
        Console.WriteLine();
    }
    public void FinishProgram(int seconds, string activityTitle)
    {
        Console.WriteLine("Well Done!");
        Animation(4);
        Console.WriteLine($"You have completed {seconds} seconds of the {activityTitle} Activity");
        Animation(4);
        Console.Clear();
    }
    public int DetermineSeconds()
    {
        Console.Write("How long would you like this activity to be (in seconds)?: ");
        string answer = Console.ReadLine();
        _seconds = int.Parse(answer);
        return _seconds;
    }
}
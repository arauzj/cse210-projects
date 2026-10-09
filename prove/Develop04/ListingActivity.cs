public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();


    public void ListProgram()
    {
        StartProgram("Listing");
        Console.WriteLine("This Activity will help you to reflect on many great things in your life by having you list many ways you have experienced them.");
        int totalSeconds = DetermineSeconds();
        Console.Clear();
        Console.Write("Get Ready...");
        Animation(4);
        Console.WriteLine();
        Random randChoice = new Random();
        _prompts = GetPrompts("listingPrompt");
        int listIndex = randChoice.Next(_prompts.Count);
        Console.WriteLine("List as many responses to the following prompt as possible:");
        Console.WriteLine();
        Console.WriteLine(_prompts[listIndex]);
        Console.WriteLine();
        Console.Write("You may begin in: ");
        NumAnimation(5);
        Console.WriteLine();
        DateTime time = DateTime.Now;
        DateTime newTime = time.AddSeconds(totalSeconds);
        int j = 0;
        while (time <= newTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            j++;
            time = DateTime.Now;
        }
        Console.WriteLine();
        Console.WriteLine($"You came up with {j} items!");
        Console.WriteLine();
        FinishProgram(totalSeconds, "Listing");
    }
}
public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _reflections = new List<string>();


    public void ReflectProgram()
    {
        
        StartProgram("Reflection");
        Console.WriteLine("This Activity will help you to reflect on meaningful times in your life.");
        int totalSeconds = DetermineSeconds();

        Console.Clear();
        Console.Write("Get Ready...");
        Animation(4);
        Console.WriteLine();
        Random randChoice = new Random();
        _prompts = GetPrompts("reflectionPrompt");
        int listIndex = randChoice.Next(_prompts.Count);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(_prompts[listIndex]);
        Console.WriteLine();
        Console.WriteLine("When ready to continue, press enter.");
        Console.ReadLine();
        Console.WriteLine("Now ponder these questions as they relate to your experience.");
        Console.Write("You may begin in: ");
        NumAnimation(5);
        Console.Clear();
        int i = 0;
        int f = -1;
        int totalSec = totalSeconds / 2;
        while (i != 2)
        {
            _prompts = GetPrompts("reflection");
            listIndex = randChoice.Next(_prompts.Count);

            while (f == listIndex)
            {
                listIndex = randChoice.Next(_prompts.Count);
            }
            Console.Write($"> {_prompts[listIndex]}");
            Animation(totalSec);
            Console.WriteLine();
            f = listIndex;
            i++;
        }
        
        FinishProgram(totalSeconds, "Reflection");
    }
}
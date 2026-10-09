public class BreathingActivity : Activity
{
    public void BreatheProgram()
    {
        StartProgram("Breathing");
        Console.WriteLine("This Activity will help you to relax by helping you to focus on breathing in and out slowly. Clear your mind and focus on your breathing.");
        int totalSeconds = DetermineSeconds();
        Console.Clear();
        Console.Write("Get Ready...");
        Animation(4);
        Console.WriteLine();
        DateTime time = DateTime.Now;
        DateTime newTime = time.AddSeconds(totalSeconds);
        while (time <= newTime)
        {
            Console.WriteLine();
            Console.Write("Breathe In...");
            NumAnimation(4);
            Console.WriteLine();
            Console.Write("Breathe Out...");
            NumAnimation(6);
            Console.WriteLine();
            time = DateTime.Now;

        }
        FinishProgram(totalSeconds, "Breathing");
    }
}
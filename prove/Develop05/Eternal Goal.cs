public class EternalGoal : Goal
{
    private string _goal;
    public override string GetGoal()
    {
        _goal = NewGoal("EternalGoal");
        Console.WriteLine();
        return _goal;
    }
}
public class SimpleGoal : Goal
{
    private string _goal;
    public override string GetGoal()
    {
        _goal = NewGoal("SimpleGoal");
        Console.WriteLine();
        return _goal;
    }
}
using System.Diagnostics.CodeAnalysis;

public class ChecklistGoal : Goal
{
    private string _goal;
    private string _totalTimes;
    private string _bonus;
    public override string GetGoal()
    {
        _goal = NewGoal("ChecklistGoal");
        Console.Write("How many times does this goal need to be accomplished to recieve a bonus?: ");
        _totalTimes = Console.ReadLine();
        Console.Write("What is the bonus for fully completing it?: ");
        _bonus = Console.ReadLine();
        Console.WriteLine();
        return $"{_goal},{_bonus},{_totalTimes},0";
    }
}
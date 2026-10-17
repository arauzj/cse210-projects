public abstract class Goal
{
    private string _goalName;
    private string _description;
    private string _points;
    public string NewGoal(string goalType)
    {
        Console.Write("What is the name of the goal?: ");
        _goalName = Console.ReadLine();
        Console.Write("Give a short description of the goal: ");
        _description = Console.ReadLine();
        Console.Write("How many points is this goal worth?: ");
        _points = Console.ReadLine();
        string goal = $"{goalType},[ ],{_goalName},{_description},{_points}";
        return goal;
    }
    public virtual string GetGoal()
    {
        return "";
    }
}
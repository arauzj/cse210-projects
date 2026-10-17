using System.Globalization;
using System.Reflection;

public class User
{
    
    private List<string> _goalList = new List<string>();
    private string _filename;
    private string[] _goalLineList = [];
    private int _bonus;
    private int _recievedPoints = 0;
    private int _points = 0;
    private string[] _goal2 = [];
    StarAnimation _animation = new StarAnimation();
    public void CreateGoal()
    {
        Console.WriteLine("Here are the types of goals you can create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select your choice (1/2/3): ");
        string answer = Console.ReadLine();
        
        if (answer == "1")
        {
            SimpleGoal simple = new SimpleGoal();
            string goal = simple.GetGoal();
            _goalList.Add(goal);
        }
        else if (answer == "2")
        {
            EternalGoal eternal = new EternalGoal();
            string goal2 = eternal.GetGoal();
            _goalList.Add(goal2);
        }
        else if (answer == "3")
        {
            ChecklistGoal checklist = new ChecklistGoal();
            string goal3 = checklist.GetGoal();
            _goalList.Add(goal3);
        }

    }
    public void ListGoals()
    {
        foreach (string i in _goalList)
        {
            string[] goal = i.Split(",");
            if (goal[0] == "SimpleGoal" || goal[0] == "EternalGoal")
            {
                Console.WriteLine($"{goal[1]} {goal[2]} ({goal[3]})");
            }
            if (goal[0] == "ChecklistGoal")
            {
                Console.WriteLine($"{goal[1]} {goal[2]} ({goal[3]}) -- Currently Completed: {goal[7]}/{goal[6]}");
            }
            Console.WriteLine();
        }
    }
    public void SaveGoals()
    {
        FindFile();
        using (StreamWriter file = new StreamWriter(_filename))
        {
            file.WriteLine(_points);
            foreach (string line in _goalList)
            {    
                file.WriteLine(line);
            }
        }
    }
    public void LoadGoals()
    {
        FindFile();
        _goalLineList = File.ReadAllLines(_filename);
            

        Console.WriteLine("");
        int k = 1;
        foreach (string row in _goalLineList)
        {
            if (k == 1)
            {
                _points = int.Parse(row);
                k++;
            }
            else
            {
                _goalList.Add(row);
            }
        }
        Console.WriteLine();
    }
    public void RecordGoals()
    {
        _recievedPoints = 0;
        int j = 1;
        Console.WriteLine("The goals are: ");
        foreach (string i in _goalList)
        {
            string[] goal = i.Split(",");
            Console.WriteLine($"{j}. {goal[2]}");
            j++;
        }
        Console.Write("Which goal did you accomplish(number)?: ");
        
        
        int selectGoal = int.Parse(Console.ReadLine());
        selectGoal--;

        
        
        string goalLine = _goalList[selectGoal];
        _goal2 = goalLine.Split(",");
        
        
        _recievedPoints += int.Parse(_goal2[4]);
        ChangeListIndex(selectGoal);
        

        _recievedPoints += _bonus;
        Console.WriteLine($"Congratulations! You earned {_recievedPoints} points!");
        _points += _recievedPoints;

    }
    public int GetPoints()
    {
        return _points;
    }
    public void FindFile()
    {
        Console.Write("What is the name of the file?: ");
        _filename = Console.ReadLine();
    }
    public void ChangeListIndex(int selectGoal)
    {
        _bonus = 0;
        if (_goal2[0] == "SimpleGoal")
        {
           _goal2[1] = _goal2[1].Replace("[ ]", "[X]");
           _goalList[selectGoal] = _goalList[selectGoal].Replace(_goalList[selectGoal], $"{_goal2[0]},{_goal2[1]},{_goal2[2]},{_goal2[3]},{_goal2[4]}");
        }
        else if (_goal2[0] == "ChecklistGoal")
        {
            int number = int.Parse(_goal2[7]);
            number++;
            _goal2[7] = _goal2[7].Replace(_goal2[7], $"{number}");
            if (_goal2[7] == _goal2[6])
            {
                _goal2[1] = _goal2[1].Replace("[ ]", "[X]");
                _bonus = int.Parse(_goal2[5]);
                Console.Clear();
                _animation.Animation();
                Console.WriteLine($"You completed the {_goal2[3]} goal!!");
            }
            
            
           _goalList[selectGoal] = _goalList[selectGoal].Replace(_goalList[selectGoal], $"{_goal2[0]},{_goal2[1]},{_goal2[2]},{_goal2[3]},{_goal2[4]},{_goal2[5]},{_goal2[6]},{_goal2[7]}");
        }
        
    }
}
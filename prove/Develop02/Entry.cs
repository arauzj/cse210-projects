public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _entry1 = "";
    public int _num = 0;
    public int _i = 0;
    public string _name = "";
    public List<string> _prompts = [];
    public List<string> _entries = new List<string>();
    public List<string> PromptForEntry(List<string> entries)
    {
        
        DateTime currentDate = DateTime.Now;
        _prompts = [
            "What happened today that made my grateful for the gospel?",
            "Who was the most interesting person I interacted with today?",
            "What important descisions did I make today?",
            "What did I do to make the most out of my day?",
            "What interesting thing happened today?"];
        Random Rprompt = new Random();
        _num = Rprompt.Next(_prompts.Count);
        _prompt = _prompts[_num];
        Console.WriteLine($"{_prompt}");
        Console.Write("> ");
        _date = currentDate.ToShortDateString();
        _entry1 = Console.ReadLine();
        Console.WriteLine("Who wrote this entry?: ");
        Console.Write("> ");
        _name = Console.ReadLine();
        
        entries.Add(_name);
        entries.Add($"Date: {_date} - Prompt: {_prompt}");
        entries.Add(_entry1);
        entries.Add("");
        return _entries;
    }
    public void JournalEntry(List<string> entries)
    {
        _i = 0;
        foreach (string entry in entries)
        {
            Console.WriteLine(entries[_i]);
            _i++;
        }
    }
        
        List <string> entries = new List<string>();
    public string file = "";
    public void DisplayJournalEntries(List<string> entries)
    {
        _i = 0;
        foreach (string i in entries)
        {
            Console.WriteLine(entries[_i]);
            _i++;
        }
    }
}
using System.IO;

public class Journal
{
    public string _txt = "";
    public string _file1 = "";
    public string[] _rows = [];
    public string _file = "";
    public void LoadJournal()
    {
        Console.WriteLine("What is the name of the file?: ");
        Console.Write("> ");
        _txt = Console.ReadLine();
        _file1 = $"{_txt}";
        _rows = System.IO.File.ReadAllLines(_file1);
        Console.WriteLine("");
        foreach (string row in _rows)
        {
            Console.WriteLine(row);
        }
    }
    public void SaveJournal(List<string> entries)
    {    
        Console.WriteLine("What is the name of the file?: ");
        Console.Write("> ");
        _file = Console.ReadLine();
        using (StreamWriter file = File.AppendText($"{_file}"))
        {
            foreach (string line in entries)
            {    
                file.WriteLine(line);
            }
        }
    }
}
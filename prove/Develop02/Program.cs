using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        List<string> _entry = new List<string>();
        List <string> entries = _entry;

        string answer1 = "0";
        Console.WriteLine("Welcome to the Journal Program!");

        while (answer1 != "5")
        {
            Console.WriteLine("Please select one of the choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What is your choice?: ");
            string answer = Console.ReadLine();
           
            if (answer == "1")
            {
                Entry entry1 = new Entry();
                entry1.PromptForEntry(entries);
            }
            else if (answer == "2")
            {
                    Entry journal1 = new Entry();
                    journal1.DisplayJournalEntries(entries);
            }
            else if (answer == "3")
            {
                Journal journal1 = new Journal();
                journal1.LoadJournal();

            }
            else if (answer == "4")
            {
                Journal entry3 = new Journal();
                entry3.SaveJournal(entries);
            }
            else
            {
                answer1 = "5";
            }
        }
    }
}
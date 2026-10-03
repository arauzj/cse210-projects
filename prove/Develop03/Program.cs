using System;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Word newScripture = new Word();
        string scriptureHead = newScripture.GetHeadingWord();
        string scripturePhrase = newScripture.GetPhraseWord();
        Console.WriteLine("Welcome to the Scripture Memo Program!");
        Console.WriteLine("Here is the Scripture:");
        Console.WriteLine($"{scriptureHead} {scripturePhrase}");
        Console.Write("Press enter to hide words or type 'quit' to end the program: ");
        string answer = Console.ReadLine();
        Console.Clear();

        while (answer != "quit")
        {
            string scriptureVerse = newScripture.GetHidWord(scripturePhrase);
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memo Program!");
            Console.WriteLine("Here is the Scripture:");
            Console.WriteLine($"{scriptureHead} {scriptureVerse}");
            Console.Write("Press enter to hide words or type 'quit' to end the program: ");
            answer = Console.ReadLine();

            if (!scriptureVerse.Any(char.IsLetter))
            {
                break;
            }
            scripturePhrase = scriptureVerse;
        }
    }
}
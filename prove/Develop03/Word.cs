using System.Runtime.ConstrainedExecution;

public class Word
{
    private string _bookName;
    private string _chapter;
    private string _verse1;
    private string _phrase;
    private string _verse2;
    private string _refScript;
    public string GetHidWord(string phrase)
    {

        Random randIndex = new Random();
        List<string> changeVers = phrase.Split(" ").ToList();
        int i = randIndex.Next(changeVers.Count);
        string word = changeVers[i];
        while (word.Contains("_"))
        {
            i = randIndex.Next(changeVers.Count);
            word = changeVers[i];
        }
        int len = word.Length;
        string newWord = "";
        int num = 0;
        while (num != len)
        {
            newWord = newWord + "_";
            num++;
        }
        changeVers.RemoveAt(i);
        changeVers.Insert(i, newWord);

        Reference hidWord = new Reference(changeVers);
        string hidWords = hidWord.GetHidPhrase();
        return hidWords;
    }
    public string GetHeadingWord()
    {
        Scripture scriptures = new Scripture();
        string scrip = scriptures.Scripture1();
        List<string> finalVers = scrip.Split(" ").ToList();
        _bookName = finalVers[1];
        _chapter = finalVers[2];
        _verse1 = finalVers[3];
        _verse2 = finalVers[4];
        _phrase = finalVers[0];
        if (_verse2 != "N/A")
        {
            Reference refScript = new Reference(_bookName, _chapter, _verse1, _verse2);
            _refScript = refScript.GetHeading();
        }
        else
        {
            Reference refScript = new Reference(_bookName, _chapter, _verse1);
            _refScript = refScript.GetHeading();
        }

        string nScripture = _refScript;
        return nScripture;
    }
    public string GetPhraseWord()
    {
        string phrase = _phrase;
        Reference refPhrase = new Reference(phrase);
        string phrase1 = refPhrase.GetPhrase();
        return phrase1;
    }
}
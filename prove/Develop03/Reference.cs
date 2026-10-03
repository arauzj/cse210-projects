using System.Reflection.Metadata.Ecma335;

public class Reference
{
    private string _heading;
    private string _phrase;
    private string _hidPhrase;
    public Reference(List<string> hidWord)
    {
        string hidPhrase = string.Join(" ", hidWord);
        _hidPhrase = hidPhrase;
    }
    public Reference(string phrase)
    {
        _phrase = phrase.Replace("."," ");
    }
    public Reference(string bookname, string chapter, string verse)
    {
        _heading = $"{bookname} {chapter}:{verse}";
        
    }
    public Reference(string bookname, string chapter, string verse, string verse2)
    {
        _heading = $"{bookname} {chapter}:{verse}-{verse2}";
        
    }
    public string GetHeading()
    {
        string heading = _heading;
        return heading;
    }
    public string GetPhrase()
    {
        string phrase = _phrase;
        return phrase;
    }
    public string GetHidPhrase()
    {
        string phrase = _hidPhrase;
        return phrase;
    }
}
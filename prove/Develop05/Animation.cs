public class StarAnimation
{
    private List<string> _animation = new List<string>();
    public void Animation()
    {
        _animation.Add("*Hooray!*");
        _animation.Add("#Hooray!#");
        _animation.Add("!Hooray!!");
        _animation.Add("*Hooray!*");
        _animation.Add("+Hooray!+");
        _animation.Add("#Hooray!#");
        _animation.Add("!Hooray!!");
        _animation.Add("+Hooray!+");
        int i = 0;
        DateTime time1 = DateTime.Now;
        DateTime stoptime = time1.AddSeconds(5);

        while (time1 <= stoptime)
        {

            while (i != 8)
            {
                Console.Write(_animation[i]);
                Thread.Sleep(225);
                Console.Write("\b\b\b\b\b\b\b\b\b         \b\b\b\b\b\b\b\b\b");
                i++;

            }
            i = 0;
            time1 = DateTime.Now;

        }
    }
}
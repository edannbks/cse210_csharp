public class Affirmations
{
    private List<string> _affirmList = new List<string>

    {
        "May the rest of your week be as beautiful as you are.",
        "I have everything I need and I am exactly where I am supposed to be.",
        "I am grateful to be me.",
        "Do good, be good, shine bright, and have fun.",
        "May your days be happy, healthy, and full of love."
    };
    public string GetRandomAffirmation()
    {
        Console.Clear();
        Random random = new Random();
        int randomIndex = random.Next(_affirmList.Count);
        string theAffirmation = _affirmList[randomIndex];
        Console.WriteLine("\n**************************************************************\n");
        Console.WriteLine(theAffirmation);
        Console.WriteLine("\n**************************************************************\n");
        return theAffirmation;
    }
}
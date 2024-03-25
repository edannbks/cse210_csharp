using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Listing : Activity
{   
    private DateTime listenStart;
    private DateTime listenEnd; 
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "How have you felt God's love lately?",
        "What are things I have to be grateful for right now?"
    };
 
    public Listing(string name, string description)
        : base(name, description)
        {
 
        }

    public void RunListing()
    {
        DisplayStartingMessage();
        ShowSpinner();
        Console.Clear();
        Console.WriteLine("Get ready to begin.");
        for (int prepare = 0; prepare <= 5; prepare++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.Clear();
        listenStart = DateTime.Now;
        listenEnd = listenStart.AddSeconds(base.GetDuration() + 10);
        Console.WriteLine("Think about the following question:\n");
        GetRandomPrompt();
        Console.WriteLine("After the countdown ends, begin listing as many answers as you can think of, pressing 'Enter' between each response.");

        ShowCountDown2();
        while (DateTime.Now < listenEnd)
        {
            GetListFromUser();
        }
        Console.WriteLine($"You listed {_count} things for this prompt!");
        DisplayEndingMessage();     
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int randomPromptIndex = random.Next(_prompts.Count);
        string listenPrompt = _prompts[randomPromptIndex];
        Console.WriteLine(listenPrompt);
        return listenPrompt;
    }

    private void GetListFromUser()
    {
        string userListItem = Console.ReadLine();
        _prompts.Add(userListItem);
        _count++;
    }
}
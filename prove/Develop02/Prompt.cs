using System;

public class Prompt
{
    public List<string> _prompts = new List<string>
  
    {
        "What happened today that I can feel grateful for?",
        "If I could start the day again, what would I do differently?",
        "What am I most looking forward to tomorrow?",
        "Am I satisfied with my efforts today? Why, or why not?",
        "What made me feel happy today?",
        "What was the greatest challenge I faced today?",
        "What is one thing I can do this week to serve someone else?",
        "What is something new I have learned this week?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string thePrompt = _prompts[randomIndex];
        Entry prompt = new Entry();
        prompt._promptText = thePrompt;
        Console.WriteLine(thePrompt);
        return thePrompt;
    }
}
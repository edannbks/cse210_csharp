using System;

public class Prompt
{
// are my prompts added to my list as objects in the program class?
    public List<string> _prompts = new List<string>
  
    {
        "What happened today that I can feel grateful for?",
        "If I could start the day again, what would I do differently?",
        "What am I most looking forward to tomorrow?",
        "Am I satisfied with my efforts today? Why, or why not?",
        "What made me feel happy today?"
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
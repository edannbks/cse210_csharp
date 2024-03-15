using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _moodText;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood: {_moodText}");
    }
}
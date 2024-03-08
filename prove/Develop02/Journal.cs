using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Console.WriteLine("Please respond to the following prompt:");
        Prompt getPrompt = new Prompt();
        getPrompt.GetRandomPrompt();
        Entry newEntry = new Entry();
        newEntry._entryText = Console.ReadLine();
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine(_entries);
        }
    }
    public void SaveToFile(string file)
    {
        string filename = "JE-Files.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string filename = "JE-Files.txt";

        using (StreamWriter inputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                inputFile.WriteLine(filename);
            }
        }
    }
}
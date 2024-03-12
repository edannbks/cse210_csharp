using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal
{
    public List<Entry>_entries = new List<Entry>();

    public void AddEntry()
    {
        Console.WriteLine("What is today's date?");
        string today = Console.ReadLine();
        Console.Clear();   
        Console.WriteLine("Please respond to the following prompt:");
        
        Prompt getPrompt = new Prompt();
        getPrompt.GetRandomPrompt();

        Entry newEntry = new Entry();
        newEntry._entryText = Console.ReadLine();
        newEntry._date = today;
        _entries.Add(newEntry);
  //    Console.WriteLine("Would you like to log your mood today?");
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void SaveToFile()
    {
        string filename = "JE-Files.txt";
    //    Console.WriteLine("Please enter the filename you would like to save to");
    //    string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(_entries);
            }
        }
    }
    public void LoadFromFile()
    {
        string filename = "JE-Files.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        {
            foreach (string line in lines)
            {
                string[] readList = line.Split("~~");
            }
        }
    }
}
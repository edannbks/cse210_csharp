using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!\n");
        Console.WriteLine($"{_description}\n");
    }
    public int GetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like your session to run for?\n(Please enter at least 30 seconds to ensure enough time to complete the activity effectively.)");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");
        ShowSpinner();
    }

    public void ShowSpinner()
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        DateTime startSpinner = DateTime.Now;
        DateTime endSpinner = startSpinner.AddSeconds(5);

        while (DateTime.Now < endSpinner)
        {
            for (int s = 0; s < spinner.Count; s++)
            {
                string spin = spinner[s];
                Console.Write(spin);
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
            DateTime currentTime = DateTime.Now;
            if (currentTime >= endSpinner)
            {
                break;
            }

        }
    }

    public void ShowCountDown()
    {

        for (int c = 4; c > 0; c--)
        {
            Console.Write(c);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }  
    }
    public void ShowCountDown2()
    {

        for (int c = 8; c > 0; c--)
        {
            Console.Write(c);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }  
    }
}
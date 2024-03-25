public class Breathing : Activity
{       
    private DateTime activityStart;
    private DateTime activityEnd;
    public Breathing(string name, string description)
        : base(name, description)
        {
            
        }

    public void RunBreathing()
    {
        DisplayStartingMessage();
        activityStart = DateTime.Now;
        activityEnd = activityStart.AddSeconds(base.GetDuration() + 5);
        Console.Clear();
        Console.WriteLine("Take a deep breath in and get ready to begin.\n");
        for (int prepare = 0; prepare <= 5; prepare++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        while (DateTime.Now < activityEnd)
        {
            Console.WriteLine("Breathe out slowly...");
            ShowCountDown();
            Console.WriteLine("... and hold...");
            Thread.Sleep(4000);
            Console.WriteLine("Breathe in slowly...");
            ShowCountDown();
            Console.WriteLine("and hold...");
            Thread.Sleep(4000);
            Console.Clear();
        }
        Console.WriteLine("Now exhale.");        
        DisplayEndingMessage();
    }
}
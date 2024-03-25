using System.Reflection;

public class Reflecting : Activity
{
    private DateTime reflectStart;
    private DateTime reflectEnd;       
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Had you ever done anything like this before?",
        "What prompted you to take action?",
        "How did this make you feel afterward?",
        "What did you learn from this experience?",
        "How can you apply things you learned to future experiences?"
    };
    private List<int> usedQuestions = new List<int>();
    public Reflecting(string name, string description)
        : base(name, description)
    {

    }

    public void RunReflecting()
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
        reflectStart = DateTime.Now;
        reflectEnd = reflectStart.AddSeconds(base.GetDuration());
        while (DateTime.Now < reflectEnd)
        {
            DisplayPrompt();
            ShowSpinner();

            while (DateTime.Now < reflectEnd)
            {
                Console.WriteLine();
                DisplayQuestion();
                if (usedQuestions.Count == _questions.Count)
                {   usedQuestions.Clear();
                    break;
                }
            }
        }
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Console.Clear();
        Random random = new Random();
        int randomPromptIndex = random.Next(_prompts.Count);
        string reflectPrompt = _prompts[randomPromptIndex];
        return reflectPrompt;
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int randomQuestionIndex = random.Next(_questions.Count);
        string aQuestion = _questions[randomQuestionIndex];
        return aQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());

    }
    public void DisplayQuestion()
    {
        int randomQuestionIndex;
        do
        {
            randomQuestionIndex = new Random().Next(_questions.Count);
        }
        while (usedQuestions.Contains(randomQuestionIndex));
        usedQuestions.Add(randomQuestionIndex);
        Console.WriteLine(_questions[randomQuestionIndex]);
        ShowSpinner();
    }
}
public class GoalManager
{
    public List<Goal> _goals;
    public int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    
    public void Start()
    {
        
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine("\nThe Eternal Quest\nYou have Menu: Choose an activity!\n");
            Console.WriteLine($"{DisplayPlayerInfo()}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Please enter the number for your selection.");

            string selection = Console.ReadLine();
            choice = int.Parse(selection);
            Console.Clear();

            if (choice == 1)
                {
                    CreateGoal();
     //               Console.Clear();
                }
            else if (choice == 2)
                {
                    ListGoalNames();
      //              Console.Clear();
                }
            else if (choice == 3)
                {
                    SaveGoals();
      //              Console.Clear();
                }
            else if (choice == 4)
                {
                    LoadGoals();
         //           Console.Clear();
                }
            else if (choice == 5)
                {
                    RecordEvent();
            //        Console.Clear();
                }                            
            else
                {                    
                  //  Console.Clear();
                    Console.WriteLine("\n\nDon't be afraid to pursue your goals-- even your dreams!\nBut know that there is no shortcut to excellence and competence.\n\n--Russell M. Nelson");
                }
        } 
    }
    
    public string DisplayPlayerInfo()
    {
        return $"You have {_score} points.";
    }
    
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GoalName);
        }
    }
    
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    
    public void CreateGoal()
    {
        Console.WriteLine("What is your goal?");
        string newGoalName = Console.ReadLine();
        SimpleGoal newGoal = new SimpleGoal(newGoalName);
        _goals.Add(newGoal);
    //    Console.WriteLine("Goal added: " + newGoalName); // Debug statement
    //    Console.WriteLine("Total goals in list: " + _goals.Count); // Debug statement
        Console.WriteLine("What type of goal is this?");
        Console.WriteLine("1- A simple goal (to complete after doing one time).");
        Console.WriteLine("2- A checklist goal (to complete after doing multiple times).");
        Console.WriteLine("3- An eternal goal (to do regularly and never complete).");
        string goalType = Console.ReadLine();
        if (goalType == "1")
        {

        }
        if (goalType == "2")
        {
            
        }
        if (goalType == "3")
        {
            
        }
    }
    
    public void RecordEvent()
    {
        Console.WriteLine("Please select the number of the goal you achieved.");
        int goalNumber = int.Parse(Console.ReadLine());
        _goals[goalNumber].RecordEvent();
        _score += _goals[goalNumber].GetPoints();
    }
    
    public void SaveGoals()
    {
    string filename = "Goals.txt";
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }
    }        
    } 
    
    public void LoadGoals()
    {
        string filename = "Goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        {
            foreach (string line in lines)
            {
                string[] variables = line.Split("~~");
                // Debugging code to check if there are enough elements in the array
                if (variables.Length >= 2)
                {
                    string _shortName = variables[0];
                    string _description = variables[1];
              //      string _points = variables[2];
                    Console.WriteLine($"{_shortName} {_description}");
              //      Console.WriteLine($"{_shortName} {_description} {_points}");
                }
                else
                {
                    // Handle the case where the line doesn't contain enough elements
                    Console.WriteLine("Invalid format in file: " + line);
                }
//                string _shortName = variables[0];
  //              string _description = variables[1];
    //            string _points = variables[2];
      //          Console.WriteLine($"{_shortName} {_description} {_points}");
            }        
        }
    }
}
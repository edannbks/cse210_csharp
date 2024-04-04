public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }
    
    GoalManager theScore = new GoalManager();
    public override void RecordEvent()
    {

    }

    public override bool isComplete()
    {
        return false;
    }

     public override string GetStringRepresentation()
    {
        return $"Goal {_shortName} {_description} {_points}";        
    }
}
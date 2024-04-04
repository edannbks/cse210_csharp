using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
            _amountCompleted =+ 1;
            
    }

    public override bool isComplete()
    {
        if (_amountCompleted == _target)
        {
              return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return"";
    }

    public override string GetStringRepresentation()
    {
        return $"Goal {_shortName} {_description} {_points} {_amountCompleted}/{_target}";        
    }
}
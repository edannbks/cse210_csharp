using System.ComponentModel;
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal (string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public Goal (string name)
    {
        _shortName = name;
    }

    public string GoalName
    {
        get {return _shortName;}
        set {_shortName = value;}
    }

    public string GoalDescription
    {
        get {return _description;}
        set {_description = value;}
    }

    public string GoalPoints
    {
        get {return _points;}
        set {_points = value;}
    }

    public abstract void RecordEvent();
 
    public abstract bool isComplete();

    public virtual string GetDetailsString()
    {
        return $"{_shortName} {isComplete()}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}~~{_description}~~{_points}";
    }

    public int GetPoints()
    {
        return int.Parse($"{_points}");
    }

}
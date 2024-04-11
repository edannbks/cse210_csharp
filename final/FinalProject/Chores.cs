public abstract class Chores
{
    protected string _choreName;
    protected List<string> _choreList;
    protected bool _iscomplete;

    public Chores (string chName, List<string> chList, bool isDone)
    {
        _choreName = chName;
        _choreList = chList;
        _iscomplete = isDone;
    }

    public bool RecordComplete()
    {

    }
}
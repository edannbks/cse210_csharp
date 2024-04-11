public class Daily : Chores
{
    private int _daysComplete;

    public Daily(string chName, List<string> chList, bool isDone) : base (chName, chList, isDone)
    {
        
    }
        public override bool RecordComplete()
    {

    }
}
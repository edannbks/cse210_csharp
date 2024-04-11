public class Weekend : Chores
{
    private bool _beforeNoon;
    private int _bonusEarned;

    public Weekend(string chName, List<string> chList, bool isDone) : base (chName, chList, isDone)
    {

    }

            public override bool RecordComplete()
    {

    }
}
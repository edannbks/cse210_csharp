using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

public class Members
{
    protected string _memberName;
    protected int _piggyBank;
    protected bool _weekComplete;
    protected int _age;

    public Members (string mName, int piggy, bool wComplete, int age)
    {
    _memberName = mName;
    _piggyBank = piggy;
    _weekComplete = wComplete;
    _age = age;
    }

    public virtual string DisplayMemberStats()
    {
        Console.WriteLine($"{memberName} has {bankBalance} in their piggy bank, and {checkCompletion} finish their chores this week!");
    }

    public bool CheckComplete();
    {
        return $"{_weekComplete}";
    }

}
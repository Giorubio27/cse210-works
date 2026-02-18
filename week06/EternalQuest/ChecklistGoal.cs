public class ChecklistGoal : Goal
{
    private int _amountCompleted;

    private int _target;

    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {

        _target = target;
        _amountCompleted = 0;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine("Congrats! Bonus points where rewarded");
            

        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal, {_shortName}, {_description}, {_points}, {_target}, {_bonus}";
    }
}
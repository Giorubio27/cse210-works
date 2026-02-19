using System.ComponentModel;

public abstract class Goal
{
    protected string _shortName;

    protected string _description;

    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }
    public int GetPoints()
    {
        return _points;
    }
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailString()
    {
        return $"{_shortName}, {_description}, {_points}";
    }
    public abstract string GetStringRepresentation();
}

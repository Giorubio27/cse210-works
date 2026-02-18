using System.ComponentModel;

public class Goal
{
    private string _shortName;

    private string _description;

    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }
    public virtual void RecordEvent()
    {

    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetDetailString()
    {
        return $"{_shortName} {_description} {_points}";
    }
    public virtual string GetStringRepresentation()
    {
        return "";
    }
}
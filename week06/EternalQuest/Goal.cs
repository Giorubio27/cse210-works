using System.ComponentModel;

public class Goal
{
    private string _shortName;

    private string _description;

    private string _points;

    public Goal(string name, string description, int points)
    {

    }
    public void RecordEvent()
    {

    }
    public bool isComplete()
    {
        return true;
    }
    public string GetDetailString()
    {
        return $"{_shortName} {_description} {_points}";
    }
    public string GetStringRepresentation()
    {
        return "";
    }
}
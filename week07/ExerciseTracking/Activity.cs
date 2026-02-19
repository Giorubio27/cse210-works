using System.Dynamic;

public class Activity
{
    private string _date;

    private double _minutes;

    private double _speed;

    private double _pace;

    public Activity(string date, int time)
    {
        _date = date;

        _minutes = time;




    }

    public virtual string GetSummary()
    {
        return $"{_date} ({_minutes} min)" + $"- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} per mile";
    }
    public virtual double GetSpeed()
    {
        _speed = GetDistance() / (_minutes / 60.0);
        return _speed;


    }
    public virtual double GetDistance()
    {
        return 0;

    }
    public virtual double GetPace()
    {
        _pace = (double)(_minutes / 60.0) / (double)(GetDistance());
        return _pace;

    }


}
public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, int time, double distance) : base(date, time)
    {
        _distance = distance;

    }
    public override string GetSummary()
    {
        return $"Running: {base.GetSummary()}";
    }
    public override double GetSpeed()
    {
        return base.GetSpeed();
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return base.GetPace();
    }
}



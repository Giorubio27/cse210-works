public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string date, int time, double laps) : base(date, time)
    {
        _laps = laps;

    }
    public override string GetSummary()
    {
        return $"Swimming: {base.GetSummary()}";
    }
    public override double GetSpeed()
    {
        return base.GetSpeed();
    }
    public override double GetDistance()
    {
        double distance = ((_laps * 50) / 1000);
        return distance * .62;
    }
    public override double GetPace()
    {
        return base.GetPace();
    }
}

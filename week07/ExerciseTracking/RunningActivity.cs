public class RunningActivity : Activity
{
    public RunningActivity(string date, int time, double distance) : base(date, time)
    {

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
        return base.GetDistance();
    }
    public override double GetPace()
    {
        return base.GetPace();
    }
}



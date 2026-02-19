public class BikingActivity : Activity
{

    private double _distance;
    public BikingActivity(string date, int time, double distance) : base( date, time)
    {
        _distance = distance;
        
    }
    public override string GetSummary()
    {
        return $"Biking: {base.GetSummary()}";
    }
    public override double GetSpeed()
    {
        return base.GetSpeed();
    }
    public override double GetDistance()
    {
        return GetDistance();
    }
    public override double GetPace()
    {
        return base.GetPace();
    }
}
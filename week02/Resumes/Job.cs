public class Job
{
    public string _jobTitle = "";
    public string _jobCompany = "";
    public string _startDate = "";
    public string _endDate = "";
    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_startDate}-{_endDate}");

    }

}
public class Assignment
{
    private string _studentName;

    private string _topic;

    public void SetStudentName(string name)
    {
        _studentName = name;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{GetStudentName()} - {GetTopic()}";
    }
}
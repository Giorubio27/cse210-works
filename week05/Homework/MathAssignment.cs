public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public void SetTexbook(string textbook)
    {
        _textbookSection = textbook;

    }
    public string GetTextbook()
    {
        return _textbookSection;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetProblems()
    {
        return _problems;
        
    }


    public string GetHomework()
    {
        return $"Section {GetTextbook()} {GetProblems()}";
    }

}
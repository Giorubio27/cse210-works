public class Comments
{
    private string _name;

    private string _comment;

    public string GetDisplay()
    {
        return $"{_name}: {_comment}";
    }
    public Comments(string name, string comment)
    {
        _name = name;
        _comment = comment;

        
        
    }
}
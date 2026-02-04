using System.Transactions;

public class Video
{
    private string _title;

    private string _author;

    private int _length;

    private List<Comments> _comments = new List<Comments>();


    public int GetNumberOfComments()
    {
        return _comments.Count();
    }
    public void newComment(Comments comment)
    {
        _comments.Add(comment);

    }
    public void GetDisplayVideo()
    {
        Console.WriteLine($"The Title:{_title} by {_author} length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

        foreach(Comments comment in _comments)
        {
            Console.WriteLine(comment.GetDisplay());
            Console.WriteLine();
        }
    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        
    }
}
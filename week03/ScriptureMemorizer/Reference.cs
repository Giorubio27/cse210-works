public class Reference
{
    private string _book;
    private int _chapter;

    private int _verse;

    private int _endVerse;

    private List<Reference> _references = new List<Reference>();


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

    }
    public List<Scripture> LoadTopic(string file)
    {
        List<Scripture> listToReturn = new List<Scripture>();
        string[] lines = System.IO.File.ReadAllLines(file);


        foreach (string line in lines)
        {
            string[] parts = line.Split(",,");
            Reference newRef;
            if (parts.Length > 4)
            {
                newRef = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
            }  
            else
            {
                newRef = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
            }

            string text = parts[parts.Length - 1].Trim('"');

            listToReturn.Add(new Scripture(newRef, text));


            _references.Add(newRef);

        }
        return listToReturn;
        
    }


    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} { _chapter}: { _verse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_verse}-{_endVerse}";
        }
    }
}
using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file...");
        
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}~~{e._promptText}~~{e._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach(string line in lines)
        {
            string[] parts = line.Split("~");

        }
    }
}
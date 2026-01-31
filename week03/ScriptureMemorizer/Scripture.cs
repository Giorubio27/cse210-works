public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        List<string> words = text.Split(" ").ToList();
        foreach (string word in words)
        {
            _words.Add(new Word(word));

        }
    }
    public void HideRandomWords(int numberToHide)
    {
        int wordsHiddenThisTime = 0;
        Random randomGenerator = new Random();
        while (wordsHiddenThisTime < numberToHide && !IsHiddenCompletely())
        {
            
            int randomIndex = randomGenerator.Next(0, _words.Count());
            Word chosenWord = _words[randomIndex];
            if (!chosenWord.IsHidden())
            {
                chosenWord.Hide();
                wordsHiddenThisTime += 1;
            }
            
        }


    }
    public string GetDisplayText()
    {
        string fullText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {

            fullText += " " + word.GetDisplayText();
        }
        return fullText;
    }

    public bool IsHiddenCompletely()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }

        }
        return true;
    }
}
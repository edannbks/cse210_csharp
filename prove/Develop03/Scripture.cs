public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(Reference reference,string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] referenceWords = text.Split(" ");
        foreach (string wordText in referenceWords)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }
    public void HideRandomWords (int numberToHide)
    {
        Random random = new Random();
        List<int> hiddenWords = new List<int>();

        for (int i = 0; i< numberToHide; i++)
        {
            int index;
            do
            {
                index = random.Next(_words.Count);
            }
            while (hiddenWords.Contains(index));
            hiddenWords.Add(index);
            _words[index].Hide();
        }
    }

    public string GetFirstDisplayText()
    {
        string referenceText = $"{_reference.GetDisplayText1()}: ";
        foreach (Word word in _words)
        {
            referenceText += word.GetDisplayText() + " ";
        }
        return referenceText;
    }

    public string GetSecondDisplayText()
    {
        string referenceText = $"{_reference.GetDisplayText2()}: ";
        foreach (Word word in _words)
        {
            referenceText += word.GetDisplayText() + " ";
        }
        return referenceText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
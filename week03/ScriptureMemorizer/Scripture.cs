using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words= new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        foreach(string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HiddenRandomWords(int numberToHide)
    {
        Random wRand = new Random();

        var viWords = _words.Where(w => !w.IsHidden()).ToList();

        if (viWords.Count == 0)
        {
            return;
        }

        numberToHide = Math.Min(numberToHide, viWords.Count);

        for (int i = 0; i < numberToHide; i++)
        {
            int index = wRand.Next(viWords.Count);
            viWords[index].Hide();
            viWords.RemoveAt(index);
        }
        
    }
    public string GetDisplayText()
    {
        string referText = _reference.GetDisplayText();
        string wordText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        
        return $"{referText}\n{wordText}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
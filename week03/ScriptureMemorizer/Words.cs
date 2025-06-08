using System.Collections.Generic;
class Word
{
    private string _word;
    private bool _isHidden = false;

    public Word(string scriptWord)
    {
        _word = scriptWord;
    }

    public void Hide() => _isHidden = true;

    public bool IsHidden => _isHidden;

    public string Display() => _isHidden ? new string('_', _word.Length) : _word;
 // comment for upload
}
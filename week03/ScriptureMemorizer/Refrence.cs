// --- Reference.cs ---
using System;

using System;

class Reference
{
    private string _Book;
    private int _Chapter;
    private int _StartVerse;
    private int? _EndVerse;

    public Reference(string book, int chapter, int verse)
    {
        _Book = book;
        _Chapter = chapter;
        _StartVerse = verse;
        _EndVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _Book = book;
        _Chapter = chapter;
        _StartVerse = startVerse;
        _EndVerse = endVerse;
    }

    public override string ToString()
    {
        return _EndVerse.HasValue
            ? $"{_Book} {_Chapter}:{_StartVerse}–{_EndVerse}"
            : $"{_Book} {_Chapter}:{_StartVerse}";
    }
    // comment for upload
}
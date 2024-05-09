using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Words are visible by default
    }

    public void Hide()
    {
        _isHidden = true; // Hide the word
    }

    public void Show()
    {
        _isHidden = false; // Show the word
    }

    public bool IsHidden()
    {
        return _isHidden; // Check if the word is hidden
    }

    public override string ToString()
    {
        return _isHidden ? "______" : _text; // Display either the word or underscores if hidden
    }
}

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        if (_endVerse != null)
            return $"{_book} {_chapter}:{_verse}-{_endVerse}"; // Display the reference with verse range if applicable
        else
            return $"{_book} {_chapter}:{_verse}"; // Display the reference without verse range
    }
}

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordTexts = text.Split(' ');
        foreach (string wordText in wordTexts)
        {
            _words.Add(new Word(wordText)); // Create Word objects for each word in the scripture
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, _words.Count(word => !word.IsHidden())); // Randomly determine how many words to hide
        int hiddenCount = 0;

        while (hiddenCount < wordsToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide(); // Hide a word if it's not already hidden
                hiddenCount++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden()); // Check if all words are hidden
    }

    public void Display()
    {
        Console.WriteLine($"Reference: {_reference}"); // Display the scripture reference
        foreach (Word word in _words)
        {
            Console.Write($"{word} "); // Display each word (or underscores if hidden)
        }
        Console.WriteLine("\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a sample scripture
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, text);

        // Hide words until all are hidden
        while (!scripture.AllWordsHidden())
        {
            scripture.Display(); // Display the scripture
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            else
            {
                Console.Clear();
                scripture.HideRandomWords(); // Hide random words
            }
        }
    }
}
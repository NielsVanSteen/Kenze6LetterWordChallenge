using Kenze6LetterWordChallenge.File;
using Kenze6LetterWordChallenge.Model;

namespace Kenze6LetterWordChallenge.Core;

public class WordFinderRecursion : IWordFinder
{
    private ICollection<WordFound> _wordsFound = new List<WordFound>();
    private IEnumerable<Word> _wordsToFind = new List<Word>();
    private bool _printWhileSearching;

    public IEnumerable<WordFound> FindAll(IEnumerable<Word> allWords, IEnumerable<Word> wordsToFind, int length, bool printWhileSearching)
    {
        _wordsFound = new List<WordFound>();
        _wordsToFind = wordsToFind.ToList();
        _printWhileSearching = printWhileSearching;
        Find(allWords, length, new WordFound(new List<Part>(), ""));
        return _wordsFound;
    }

    /// <summary>
    /// Method that recursively finds all combinations of words that have a combined length of 'length'. and occur in the '_wordsToFind' list.
    /// </summary>
    private void Find(IEnumerable<Word> searchWords, int length, WordFound partOfWordFound)
    {
        var combinedLength = partOfWordFound.Word.Length;
        // Check if the combination we have so far occurs in the list of words, if not return.
        if (!_wordsToFind.Any(w => w.WordString.StartsWith(partOfWordFound.Word)))
        {
            return;
        }
        // When the length is correct, add the word. The Previous if statement made sure the word occurs in the list.
        if (combinedLength == length )
        {
            AddWordFound(partOfWordFound);
            PrintWordFound(_printWhileSearching, partOfWordFound );
            return;
        }
        // Max Length exceeded, return.
        if (combinedLength >= length)
        {
            return;
        }
        // Call this method again, with all the parts.
        var enumerable = searchWords.ToArray();
        foreach (var part in enumerable)
        {
            Find(enumerable, length, CreateNewWordFound(partOfWordFound, part));
        }
    }
    
    private void AddWordFound(WordFound partOfWordFound)
    {
        _wordsToFind = _wordsToFind.Where(w => w.WordString != partOfWordFound.Word).ToList(); // -> Most importance line for performance. :)
        var wordFound = new WordFound(partOfWordFound.Parts, partOfWordFound.Word);
        _wordsFound.Add(wordFound);
    }
    
    /// <summary>
    /// Creates a new object to prevent reference issues.
    /// </summary>
    private WordFound CreateNewWordFound(WordFound wordFound, Word part)
    {
        var @new = new WordFound(wordFound.Parts, wordFound.Word);
        @new.Parts.Add(new Part(part.WordString));
        @new.Word += part.WordString;
        return @new;
    }
    
    private void PrintWordFound(bool printWhileSearching, WordFound wordFound)
    {
        if (printWhileSearching)
        {
            wordFound.Print();
        }
    }
}
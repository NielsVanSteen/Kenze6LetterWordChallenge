using Kenze6LetterWordChallenge.Model;

namespace Kenze6LetterWordChallenge.Core;

public class WordFinderRecursionMultiple : IWordFinder
{
    private IEnumerable<Word> _allWords = new List<Word>();
    private IEnumerable<Word> _wordsToFind = new List<Word>();
    private bool _printWhileSearching;

    public IEnumerable<WordFound> FindAll(IEnumerable<Word> allWords, IEnumerable<Word> wordsToFind, int length, bool printWhileSearching)
    {
        _allWords = allWords;
        _wordsToFind = wordsToFind;
        _printWhileSearching = printWhileSearching;
        var found = new List<WordFound>();
        foreach (var word in _wordsToFind)
        {
            found.AddRange(FindAllCombinations(word));
        }
        return found;
    }

    private IEnumerable<WordFound> FindAllCombinations(Word wordToFind)
    {
        var availableParts = _allWords.Where(str => wordToFind.WordString.Contains(str.WordString)).Distinct().ToList();
        var combinations = new List<WordFound>();

        FindAll(wordToFind, availableParts, new WordFound(new List<Part>(), ""), combinations);
        return combinations;
    }

    private void FindAll(Word wordToFind, ICollection<Word> parts, WordFound wordFound, ICollection<WordFound> combinations)
    {
        if (wordToFind.WordString.Length == 0)
        {
            combinations.Add(wordFound);
            IWordFinder.PrintWordFound(_printWhileSearching, wordFound);
            return;
        }
        foreach (var part in parts)
        {
            if (wordToFind.WordString.StartsWith(part.WordString))
            {
                string remainingWord = wordToFind.WordString.Substring(part.WordString.Length);
                WordFound newWord = IWordFinder.CreateNewWordFound(wordFound, part);
                FindAll(new Word(remainingWord), parts, newWord, combinations);
            }
        }
    }
    
}
using System.Collections;
using Kenze6LetterWordChallenge.File;
using Kenze6LetterWordChallenge.Model;

namespace Kenze6LetterWordChallenge.Core;

public class WordLetterChallenge
{
    public required IFileReader FileReader { get; init; }
    public required IWordFinder WordFinder { get; init; }
    public required int WordLength { get; init; }

    public IEnumerable<WordFound> SearchWords(string path, bool printWhileSearching)
    {
        var allWords = FileReader.ReadFile(path).ToArray();
        var wordsToFind = FindWordsToSearch(allWords);
        var parts = FindParts(allWords);
        return WordFinder.FindAll(parts, wordsToFind, WordLength, printWhileSearching);
    }

    private IEnumerable<Word> FindWordsToSearch(IEnumerable<Word> words)
    {
        return words.Where(w => w.WordString.Length == WordLength);
    }

    private IEnumerable<Word> FindParts(IEnumerable<Word> words)
    {
        return words.Where(w => w.WordString.Length < WordLength);
    }
}
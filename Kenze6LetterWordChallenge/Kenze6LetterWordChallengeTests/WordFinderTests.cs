using Kenze6LetterWordChallenge.Core;
using Kenze6LetterWordChallenge.Model;

namespace Kenze6LetterWordChallengeTests;

public class WordFinderTests
{
    [Fact]
    public void FindAll_FindAllWords_ShouldReturnAllPossibleWordsMatchingLength()
    {
        var words = new List<Word>
        {
            new("Niels"),
            new("Kenze"),
            new("Ni"),
            new("els"),
            new("K"),
            new("enze")
        };
        var wordsToFind = new List<Word>() {new("Niels"), new("Kenze")};
        IWordFinder wordFinder = new WordFinderRecursion();
        var returnedWords = wordFinder.FindAll(words, wordsToFind, 5, false).ToList();
        Assert.All(new[] { "Niels", "Kenze" }, expectedValue => Assert.Contains(expectedValue, returnedWords.Select(w => w.Word)));
    }
}
using Kenze6LetterWordChallenge.Model;

namespace Kenze6LetterWordChallenge.Core;

public interface IWordFinder
{
    public IEnumerable<WordFound> FindAll(IEnumerable<Word> allWords, IEnumerable<Word> wordsToFind, int length, bool printWhileSearching);
}
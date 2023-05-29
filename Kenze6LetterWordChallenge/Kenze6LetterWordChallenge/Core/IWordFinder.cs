using Kenze6LetterWordChallenge.Model;

namespace Kenze6LetterWordChallenge.Core;

public interface IWordFinder
{
    public IEnumerable<WordFound> FindAll(IEnumerable<Word> allWords, IEnumerable<Word> wordsToFind, int length,
        bool printWhileSearching);

    protected static sealed WordFound CreateNewWordFound(WordFound wordFound, Word part)
    {
        var @new = new WordFound(wordFound.Parts, wordFound.Word);
        @new.Parts.Add(new Part(part.WordString));
        @new.Word += part.WordString;
        return @new;
    }

    protected static sealed void PrintWordFound(bool printWhileSearching, WordFound wordFound)
    {
        if (printWhileSearching)
        {
            wordFound.Print();
        }
    }
}
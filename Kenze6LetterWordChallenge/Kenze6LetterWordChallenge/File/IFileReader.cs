using Kenze6LetterWordChallenge.Model;

namespace Kenze6LetterWordChallenge.File;

public interface IFileReader
{
    IEnumerable<Word> ReadFile(string path);
}
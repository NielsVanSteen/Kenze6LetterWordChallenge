using Kenze6LetterWordChallenge.File;
using Kenze6LetterWordChallenge.Model;

namespace Kenze6LetterWordChallenge.File;

public class FileReader : IFileReader
{
    public IEnumerable<Word> ReadFile(string path)
    {
        return System.IO.File.ReadLines(path).Select(l => new Word(l));
    }
}
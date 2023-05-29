using Kenze6LetterWordChallenge.File;

namespace Kenze6LetterWordChallengeTests;

public class FileReaderUnitTests
{
    private IFileReader? _fileReader;
    
    [Fact]
    public void ReadFile_ShouldReturnCorrectData()
    {
        _fileReader = new FileReader();
        var words = _fileReader.ReadFile("input.txt").ToList();
        Assert.Equal(4202, words.Count);
        Assert.Equal("osine", words[0].WordString);
        Assert.Equal("fligh", words[^1].WordString);
    }
}
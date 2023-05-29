namespace Kenze6LetterWordChallenge.Model;

public class WordFound
{
    public ICollection<Part> Parts { get; }
    public string Word {get; set;}

    public WordFound(ICollection<Part> parts, string word)
    {
        Parts = new List<Part>(parts);
        Word = word;
    }
}
namespace Kenze6LetterWordChallenge.Model;

public class Word
{
    public string WordString { get; set; }

    public Word(string wordString)
    {
        WordString = wordString;
    }

    protected bool Equals(Word other)
    {
        return WordString == other.WordString;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Word) obj);
    }

    public override int GetHashCode()
    {
        return WordString.GetHashCode();
    }
}
using Kenze6LetterWordChallenge.Core;
using Kenze6LetterWordChallenge.Model;

namespace Kenze6LetterWordChallenge;

public static class WordFoundExtensionMethods
{
    public static void Print(this WordFound word)
    {
        var combined = String.Join(AppConstants.JoinCharacter, word.Parts.Select(p => p.WordPart));
        Console.WriteLine($"{combined}{AppConstants.EqualsCharacter}{word.Word}");
    }
}
using System.Diagnostics;
using Kenze6LetterWordChallenge.Core;
using Kenze6LetterWordChallenge.File;
using Kenze6LetterWordChallenge.Model;

IFileReader fileReader = new FileReader();
//IWordFinder wordFinder = new WordFinderRecursion(); //-> Finds only 1 combination for a given word in the text file.
IWordFinder wordFinder = new WordFinderRecursionMultiple(); // -> Finds all combinations for a given word in the text file.
var wordLetterChallenge = new WordLetterChallenge()
{
    FileReader = fileReader,
    WordFinder = wordFinder,
    WordLength = AppConstants.BaseWordLength
};
Console.WriteLine("Here are all the word combinations in input.txt:\n------------------");
var stopwatch = new Stopwatch();
stopwatch.Start();
IEnumerable<WordFound> words = wordLetterChallenge.SearchWords("input.txt", true);
stopwatch.Stop();
TimeSpan elapsed = stopwatch.Elapsed;
Console.WriteLine($"Found: {words.ToList().Count} words in {elapsed.Seconds}.{elapsed.Milliseconds:D3} seconds"); 
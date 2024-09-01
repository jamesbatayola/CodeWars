namespace _6KYU_04;

// A pangram is a sentence that contains every single letter of the alphabet at least once.For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once(case is irrelevant).

// Given a string, detect whether or not it is a pangram.Return True if it is, False if not.Ignore numbers and punctuation.

internal class Program
{

    static void Main(string[] args)
    {
        string sentence = "The quick brown fox jumps over the lazy dog.";

        Console.WriteLine(IsPangram(sentence));

        Console.ReadLine();
    }

    public static bool IsPangram(string str)
    {
        return str
                .ToLower()
                .Replace(" ", string.Empty)
                .Where(x => char.IsLetter(x))
                .Distinct()
                .Count() == 26;
    }

}

// COMPLETED

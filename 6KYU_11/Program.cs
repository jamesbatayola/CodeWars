namespace _6KYU_11;

// Welcome.

// In this kata you are required to, given a string, replace every letter with its position in the alphabet.

// If anything in the text isn't a letter, ignore it and don't return it.

// "a" = 1, "b" = 2, etc.

// Example
// Input = "The sunset sets at twelve o' clock."
// Output = "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11"

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));

        Console.ReadLine();
    }

    // SOLUTION
    public static string AlphabetPosition(string text)
    {
           return string.Join(" ", text.ToLower().Where(x => char.IsLetter(x)).Select(x => Math.Abs(('a' - 0) - (x - 0) - 27) - 26));       
    }


}

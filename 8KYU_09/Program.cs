namespace _8KYU_09;

// Is the string uppercase?
// Task
// Create a method to see whether the string is ALL CAPS.

// Examples(input -> output)
// "c" -> False
// "C" -> True
// "hello I AM DONALD" -> False
// "HELLO I AM DONALD" -> True
// "ACSKLDFJSgSKLDFJSKLDFJ" -> False
// "ACSKLDFJSGSKLDFJSKLDFJ" -> True

// In this Kata, a string is said to be in ALL CAPS whenever it does not contain any lowercase letter so any string containing no letters at all is trivially considered to be in ALL CAPS.

internal static class Program
{
    static void Main(string[] args)
    {

        Console.ReadLine();
    }

    // SOLUTION
    public static bool _IsUpperCase(this string text)
    {
        return text.Where(x => char.IsLetter(x)).All(x => char.IsUpper(x));
    }
}

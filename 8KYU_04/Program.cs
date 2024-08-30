namespace _8KYU_04;

// Create a function that accepts a string and a single character, and returns an integer of the count of occurrences the 2nd argument is found in the first one.

// If no occurrences can be found, a count of 0 should be returned.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(StrCount("hiii", 'i'));

        Console.ReadLine();
    }

    // SOLUTION
    public static int StrCount(string str, char letter)
    {
        return str.Count(x => x == letter);
    }

}

// COMPLETED :)

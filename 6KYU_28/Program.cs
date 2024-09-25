// Count the number of Duplicates

// Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
// Example

// "abcde" -> 0 # no characters repeats more than once
// "aabbcde" -> 2 # 'a' and 'b'
// "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
// "indivisibility" -> 1 # 'i' occurs six times
// "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
// "aA11" -> 2 # 'a' and '1'
// "ABBA" -> 2 # 'A' and 'B' each occur twice

Console.WriteLine(DuplicateCount("abcde"));
Console.WriteLine(DuplicateCount("aabbcde"));
Console.WriteLine(DuplicateCount("aabBcde"));
Console.WriteLine(DuplicateCount("ndivisibility"));
Console.WriteLine(DuplicateCount("ndivisibilities"));
Console.WriteLine(DuplicateCount("aA11"));
Console.WriteLine(DuplicateCount("ABBA"));

static int DuplicateCount(string str)
{
    var pair = new Dictionary<char, int>();

    foreach(char letter in str.ToLower())
    {
        if (!pair.ContainsKey(letter))
            pair[letter] = 1;
        else
            pair[letter]++;
    }

    return pair.Count(e => e.Value > 1);
}

Console.ReadLine();
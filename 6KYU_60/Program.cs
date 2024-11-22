// Acknowledgments:
// I thank yvonne-liu for the idea and for the example tests :)
//
// Description:
// Encrypt this!
//
// You want to create secret messages which can be deciphered by the Decipher this! kata. Here are the conditions:
//
// Your message is a string containing space separated words.
//     You need to encrypt each word in the message using the following rules:
// The first letter must be converted to its ASCII code.
//     The second letter must be switched with the last letter
// Keepin' it simple: There are no special characters in the input.
//     Examples:
// Kata.EncryptThis("Hello") == "72olle"
// Kata.EncryptThis("good") == "103doo"
// Kata.EncryptThis("hello world") == "104olle 119drlo"

Console.WriteLine(EncryptThis(""));
Console.WriteLine(EncryptThis("A"));
Console.WriteLine(EncryptThis("Ab"));
Console.WriteLine(EncryptThis("Abc"));
Console.WriteLine(EncryptThis("Abcd"));
Console.WriteLine(EncryptThis("hello world"));

static string EncryptThis(string input)
{
    var words = input.Split(' ');

    if (string.IsNullOrEmpty(input)) return "";

    var encrypted = new List<string>();

    foreach (var word in words)
    {
        var ascii = $"{Convert.ToInt32(word[0])}";

        encrypted.Add(
            word.Length > 3 ? ascii + word[^1] + word[2..^1] + word[1] :
            word.Length == 1 ? ascii :
            word.Length == 2 ? ascii + word[1] :
            ascii + word[^1] + word[1]
        );
    }

    return string.Join(" ", encrypted);
}

// PSEUDO CODE
// - seperate the input by spaces
// - convert 1st letter of each words to ascii
// - switch the 2nd and last letter of words


// OTHER ANSWER -----------------------------

public class Kata
{
    public static string EncryptThis(string input) => input
        .Split(" ")
        .Select(Encrypt)
        .Aggregate((r, w) => $"{r} {w}");
      
    private static string Encrypt(string w) => w.Length switch 
    {
        0 => string.Empty,
        1 => $"{(int)w[0]}",
        2 => $"{(int)w[0]}{w[1]}",
        _ => $"{(int)w[0]}{w[^1]}{w[2..^1]}{w[1]}"
    };
}
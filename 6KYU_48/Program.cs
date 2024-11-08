// Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
//     Examples
//
// Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
// Kata.PigIt("Hello world !");     // elloHay orldway !

using System.Text;

Console.WriteLine(PigIt("Pig latin is cool"));
Console.WriteLine(PigIt("Hello world !"));

static string PigIt(string str)
{
    var res = new List<string>();

    foreach (var word in str.Split(' '))
    {
        char temp = word[0];
        if (word.Length > 1)
        {
            res.Add(word.Substring(1) + $"{temp}ay");
        }
        else
        {
            res.Add(word);
        }
    }

    return string.Join(" ", res);
}
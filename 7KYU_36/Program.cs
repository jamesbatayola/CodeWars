// The vowel substrings in the word codewarriors are o, e, a, io. The longest of these has a length of 2. Given a lowercase string that has alphabetic characters only (both vowels and consonants) and no spaces, return the length of the longest vowel substring. Vowels are any of aeiou.

// Good luck!

// If you like substring Katas, please try:

// Non - even substrings

// Vowel-consonant lexicon

//Console.WriteLine(Solve("codewarrions"));

using System.Text;

Console.WriteLine(Solve("codewarriors"));
Console.WriteLine(Solve("suoidea"));
Console.WriteLine(Solve("ultrarevolutionariees"));
Console.WriteLine(Solve("strengthlessnesses"));
Console.WriteLine(Solve("cuboideonavicuare"));
Console.WriteLine(Solve("chrononhotonthuooaos"));
Console.WriteLine(Solve("iiihoovaeaaaoougjyaw"));


Console.WriteLine(Solve("ssss"));

static int Solve(string str)
{
    var sb = new StringBuilder();

    for (int i = 0; i < str.Length; i++)
    {
        sb.Append("aeiou".Contains(str[i]) ? str[i] : " ");
    }

    if(sb.ToString().Any(e => "aeiou".Contains(e)))
    {
        return sb.ToString().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Max(e => e.Length);
    }

    return 0;
}

Console.ReadLine();
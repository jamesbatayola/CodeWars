// The vowel substrings in the word codewarriors are o, e, a, io. The longest of these has a length of 2. Given a lowercase string that has alphabetic characters only (both vowels and consonants) and no spaces, return the length of the longest vowel substring. Vowels are any of aeiou.

// Good luck!

// If you like substring Katas, please try:

// Non - even substrings

// Vowel-consonant lexicon

//Console.WriteLine(Solve("codewarrions"));

using System.Text;

//Console.WriteLine(new string[] { "a", "as", "asd" }.Max(e => e.Length));

//Console.WriteLine(Solve("codewarriors"));

//string asd = "   ssd  ds ds      sd";
//var test = asd.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

//foreach(var i in test)
//{
//    Console.WriteLine(i);
//}

Console.WriteLine(Solve("Codewars"));

static int Solve(string str)
{
    var sb = new StringBuilder();

    for(int i =0; i < str.Length; i++)
    {
        sb.Append( "aeiou".Contains(str[i]) ? str[i] : " ");
    }

    return sb.ToString().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Max(e => e.Length);    
}

Console.ReadLine();
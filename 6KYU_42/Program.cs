// Write a function that accepts a string, and returns the same string with all even indexed characters in each word upper cased, and all odd indexed characters in each word lower cased. The indexing just explained is zero based, so the zero-ith index is even, therefore that character should be upper cased and you need to start over for each word.
//
//     The passed in string will only consist of alphabetical characters and spaces(' '). Spaces will only be present if there are multiple words. Words will be separated by a single space(' ').
//     Examples:
//
// "String" => "StRiNg"
// "Weird string case" => "WeIrD StRiNg CaSe"

using System.Text;

// Console.WriteLine(ToWeirdCase("String"));
// Console.WriteLine(ToWeirdCase("Weird string case"));
//
// Console.WriteLine(ToWeirdCase("This"));
// Console.WriteLine(ToWeirdCase("is"));
// Console.WriteLine(ToWeirdCase("This is a test"));

Console.WriteLine(ToWeirdCase("ayqW"));
Console.WriteLine(ToWeirdCase("BOY"));

static string ToWeirdCase(string s)
{
    string words = s.Trim().ToLower();
    
    if (!words.Any(char.IsWhiteSpace))
    {
        return string.Join("", words.Select((e, i) => i % 2 == 0 ? char.ToUpper(e) : e));
    }

    int beg = 0;
    
    var sb = new StringBuilder(words);
    
    for(int i = 0; i < words.Length; i++)
    {
        if (char.IsWhiteSpace(words[i]))
        {
            beg = 0;
            continue;
        }
        
        if(beg % 2 == 0)
            sb[i] = char.ToUpper(words[i]);

        beg++;
    }

    return sb.ToString();
}

Console.ReadLine();
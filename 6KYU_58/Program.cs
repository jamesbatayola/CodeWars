// You are given a secret message you need to decipher. Here are the things you need to know to decipher it:
//
// For each word:
//
// the second and the last letter is switched (e.g. Hello becomes Holle)
//     the first letter is replaced by its character code (e.g. H becomes 72)
// there are no special characters used, only letters and spaces
//     words are separated by a single space
// there are no leading or trailing spaces
//     Examples
//
// '72olle 103doo 100ya' --> 'Hello good day'
// '82yade 115te 103o'   --> 'Ready set go'


// Console.WriteLine(DecipherThis("72olle 103doo 100ya"));
// Console.WriteLine(DecipherThis("82yade 115te 103o"));
//
// Console.WriteLine(DecipherThis("65"));
// Console.WriteLine(DecipherThis("65b"));
// Console.WriteLine(DecipherThis("65cb"));

Console.WriteLine(DecipherThis(""));

static string DecipherThis(string s)
{
    if (s.Length <= 0) return "";
    
    var res = new List<string>();

    foreach (var word in s.Split(" "))
    {
        string ascii = string.Concat(word.TakeWhile(char.IsDigit));
        char asciiToChar = (char)int.Parse(ascii);

        string lettersOnly = string.Concat(word.Where(char.IsLetter));
        string switchedWords = lettersOnly.Length >= 3 ?  lettersOnly[^1] + string.Concat(lettersOnly.Skip(1).SkipLast(1)) + lettersOnly[0] :
                               lettersOnly.Length == 2 ? $"{lettersOnly[^1]}{lettersOnly[0]}" :
                               lettersOnly.Length == 1 ?  lettersOnly : "";

        res.Add($"{asciiToChar}{switchedWords}");
    }

    return string.Join(" ", res);
}

// fetch digits on input
// convert digits(ASCII) to letters

// fetch letters on input
// switch 1st and last letter in fetched letters

// converted digits and switched letters
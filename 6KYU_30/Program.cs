// Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.
// Examples

// "the-stealth-warrior" gets converted to "theStealthWarrior"

// "The_Stealth_Warrior" gets converted to "TheStealthWarrior"

// "The_Stealth-Warrior" gets converted to "TheStealthWarrior"


using System.Text;

Console.WriteLine(ToCamelCase("the-stealth-warrior"));
Console.WriteLine(ToCamelCase("The_Stealth-Warrior"));
Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));

//static string ToCamelCase(string str)
//{
//    string[] words = str.Split(new char[] { '-', '_'});
//    for(int i = 1; i < words.Length; i++)
//    {
//        words[i][0] = char.ToUpper(words[i][0]);
//        words[i][0].ToString().To
//    }
//    return string.Join("", words);
//}

static string ToCamelCase(string str)
{
    var sb = new StringBuilder();
    for (int i = 0; i < str.Length; i++)
    {
        if (i != 0 &&!char.IsLetter(str[i - 1]))
            sb.Append(char.ToUpper(str[i]));
        else if (char.IsLetter(str[i])) 
            sb.Append(str[i]);
    }
    return sb.ToString();
}

// OTHER ANSWER ---------------------

static string _ToCamelCase(string str)
{
    return string.Concat(str.Split('-', '_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
}

Console.ReadLine();
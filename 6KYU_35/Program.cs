// Write a method (or function, depending on the language) that converts a string to camelCase, that is, all words must have their first letter capitalized and spaces must be removed.
//     Examples (input --> output):
//
// "hello case" --> "HelloCase"
// "camel case word" --> "CamelCaseWord"
//
// Don't forget to rate this kata! Thanks :)

using Microsoft.VisualBasic.CompilerServices;

public static class Kata
{
    public static void Main(string[] args)
    {
        // Console.WriteLine(_CamelCase("test case"));
        // Console.WriteLine(_CamelCase(" camel case method"));
        // Console.WriteLine(_CamelCase("say hello"));
        // Console.WriteLine(_CamelCase("                        "));
        
        Console.WriteLine(_CamelCase("lvccbwlybrfmf  dpnbz qsgjdqzfcpj cxlswlmhrqrsuwqz"));
    }
    
    public static string _CamelCase(this string str)
    {
        if (str.Trim() == "") return str;
        
        string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return string.Join("", words.Select(w => char.ToUpper(w[0]) + w.Substring(1)));
    }
    
}



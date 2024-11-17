//Description:

//When provided with a String, capitalize all vowels

//For example:

//Input: "Hello World!"

//Output: "HEllO WOrld!"

//Note: Y is not a vowel in this kata.

Console.WriteLine(Swap("Hello World!"));

static string Swap(string s)
{
    var res = s.Select(e => "aeiou".Contains(e, StringComparison.CurrentCultureIgnoreCase) ? char.ToUpper(e) : e);

    return string.Join("", res);
}
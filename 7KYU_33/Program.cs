// Given a string and an array of integers representing indices, capitalize all letters at the given indices.

// For example:

//    capitalize("abcdef", [1, 2, 5]) = "aBCdeF"
//    capitalize("abcdef", [1, 2, 5, 100]) = "aBCdeF".There is no index 100.

// The input will be a lowercase string with no spaces and an array of digits.

// Good luck!

using System.Text;
using System.Text.RegularExpressions;

Console.WriteLine(Capitalize("qwertyuiopasd", [1, 2, 10]));
Console.WriteLine(Capitalize("abcdef", [1, 2, 5, 100]));
Console.WriteLine(Capitalize("qweasdzxcrtyfgh", [0]));

// CONCISE VERSION
static string Capitalize(string s, List<int> idxs)
{
    return string.Join("", s.Select((e, i) => idxs.Contains(i) ? char.ToUpper(e) : e));
}

Console.ReadLine();
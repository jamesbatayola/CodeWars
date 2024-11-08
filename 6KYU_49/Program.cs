//
// Description:
//
// Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order of the strings of a1 which are substrings of strings of a2.
//     Example 1:
//
// a1 = ["arp", "live", "strong"]
//
// a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
//
// returns ["arp", "live", "strong"]
// Example 2:
//
// a1 = ["tarp", "mice", "bull"]
//
// a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
//
// returns []
// Notes:
//
// Arrays are written in "general" notation. See "Your Test Cases" for examples in your language.
//     In Shell bash a1 and a2 are strings. The return is a string where words are separated by commas.
//     Beware: In some languages r must be without duplicates.
//


var a1 = new string[] { "arp", "live", "strong" };
var a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };

var a3 = new string[] { "tarp", "mice", "bull" };
var a4 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };

var test1 = inArray(a3, a4);

foreach (var i in test1)
{
    Console.WriteLine(i);
}

static string[] inArray(string[] array1, string[] array2)
{
    var dict = new Dictionary<string, int>();

    foreach (var key in array1)
    {
        dict[key] = 0;
    }

    foreach (var eachA1 in array1)
    {
        if (array2.Any(e => e.Contains(eachA1)))
        {
            dict[eachA1]++;
        }
    }

    return dict.Where(e => e.Value > 0)
        .Select(e => e.Key)
        .Order()
        .ToArray();
}
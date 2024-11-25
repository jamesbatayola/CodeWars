// In this Kata, you will be given an array of strings and your task is to remove all consecutive duplicate letters from each string in the array.
//
//     For example:
//
// dup(["abracadabra","allottee","assessee"]) = ["abracadabra","alote","asese"].
//
//     dup(["kelless","keenness"]) = ["keles","kenes"].
//
//     Strings will be lowercase only, no spaces. See test cases for more examples.
//
//     Good luck!
//
//     If you like this Kata, please try:
//
// Alternate capitalization
//
// Vowel consonant lexicon

var test1 = dup(["abracadabra","allottee","assessee"]);
var test2 = dup(["kelless","keenness"]);

foreach(var each in test2)
    Console.WriteLine(each);

static string[] dup(string[] arr)
{
    var res = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        string temp = $"{arr[i][0]}";
        for (int j = 1; j < arr[i].Length; j++)
        {
            temp += arr[i][j] != arr[i][j - 1] ? arr[i][j] : "";
        }
        res[i] = temp;
    }
    return res;
}

// loop through array
// remove consecutive duplicate from each item and store them in temp variable
// ater each item is filtered add the temp variable to the res variable
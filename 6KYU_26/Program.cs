//You are given an array(list) strarr of strings and an integer k. Your task is to return the first longest string consisting of k consecutive strings taken in the array.
//Examples:

//strarr = ["tree", "foling", "trashy", "blue", "abcdef", "uvwxyz"], k = 2

//Concatenate the consecutive strings of strarr by 2, we get:

//treefoling   (length 10)  concatenation of strarr[0] and strarr[1]
//folingtrashy ("      12)  concatenation of strarr[1] and strarr[2]
//trashyblue   ("      10)  concatenation of strarr[2] and strarr[3]
//blueabcdef   ("      10)  concatenation of strarr[3] and strarr[4]
//abcdefuvwxyz ("      12)  concatenation of strarr[4] and strarr[5]

//Two strings are the longest: "folingtrashy" and "abcdefuvwxyz".
//The first that came is "folingtrashy" so 
//longest_consec(strarr, 2) should return "folingtrashy".

//In the same way:
//longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"

//n being the length of the string array, if n = 0 or k > n or k <= 0 return "" (return Nothing in Elm, "nothing" in Erlang).
//Note

//consecutive strings : follow one after another without an interruption
//You are given an array(list) strarr of strings and an integer k. Your task is to return the first longest string consisting of k consecutive strings taken in the array.
//Examples:

//strarr = ["tree", "foling", "trashy", "blue", "abcdef", "uvwxyz"], k = 2

//Concatenate the consecutive strings of strarr by 2, we get:

//treefoling   (length 10)  concatenation of strarr[0] and strarr[1]
//folingtrashy ("      12)  concatenation of strarr[1] and strarr[2]
//trashyblue   ("      10)  concatenation of strarr[2] and strarr[3]
//blueabcdef   ("      10)  concatenation of strarr[3] and strarr[4]
//abcdefuvwxyz ("      12)  concatenation of strarr[4] and strarr[5]

//Two strings are the longest: "folingtrashy" and "abcdefuvwxyz".
//The first that came is "folingtrashy" so 
//longest_consec(strarr, 2) should return "folingtrashy".

//In the same way:
//longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"

//n being the length of the string array, if n = 0 or k > n or k <= 0 return "" (return Nothing in Elm, "nothing" in Erlang).
//Note

//consecutive strings : follow one after another without an interruption

Console.WriteLine(LongestConsec(new string[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2));
Console.WriteLine(LongestConsec(new string[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2));
Console.WriteLine(LongestConsec(new string[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3));
Console.WriteLine(LongestConsec(new string[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0));

static string LongestConsec(string[] strarr, int k)
{
    if (strarr.Length == 0 || k > strarr.Length || k <= 0) return "";

    if (k == 1) return strarr.MaxBy(e => e.Length);

    var words = new List<string>();

    for (int i = 0; i < strarr.Length - k + 1; i++)
    {
        string temp = strarr[i];
        for (int j = i + 1; j < i + k; j++)
        {
            temp += strarr[j];
        }
        words.Add(temp);
    }

    return words.First(e => e.Length == words.Max(e => e.Length));
}



Console.ReadLine();
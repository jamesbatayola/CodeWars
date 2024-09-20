// The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.
// Examples

// "din"      =>  "((("
// "recede"   =>  "()()()"
// "Success"  =>  ")())())"
// "(( @"     =>  "))((" 

// Notes

// Assertion messages may be unclear about what they display in some languages. If you read "...It Should encode XXX", the "XXX" is the expected result, not the input!

using System.Text;

//string word = "din";

//for (int i = 0; i < word.Length * word.Length; i++)
//{
//    Console.WriteLine($"outer: {i / word.Length} = {word[i / word.Length]} | inner: {i % word.Length} = {word[i % word.Length]}");
//}

Console.WriteLine(_DuplicateEncode("din"));
Console.WriteLine(_DuplicateEncode("recede"));
Console.WriteLine(_DuplicateEncode("Success"));
Console.WriteLine(_DuplicateEncode("(( @"));

// BRUTE FOREC APPROACH 
static string DuplicateEncode(string word)
{
    var res = new StringBuilder();

    int len = word.Length;

    for (int i = 0; i < len; i++)
    {
        bool hasCopy = false;

        for (int j = 0; j < len; j++)
        {
            if (i != j && char.ToLower(word[i]) == char.ToLower(word[j])) hasCopy = true;
        }

        if (!hasCopy) res.Append("(");
        else res.Append(")");
    }

    return res.ToString();
}

// OTHER ANSWER ----------

static string _DuplicateEncode(string word)
{
    var res = "";
    bool isOnce = true;
    int len = word.Length;

    for (int i = 0; i < len * len; i++)
    {
        if ((i / len) != (i % len) && char.ToLower(word[i / len]) == char.ToLower(word[i % len]))
        {
            isOnce = false;
        }

        if(i % len == len - 1)
        {
            res += (i % len) == (len - 1) && isOnce ? "(" : ")";
            isOnce = true;
        }
    }

    return res;
}

Console.ReadLine();
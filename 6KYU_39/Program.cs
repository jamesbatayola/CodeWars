// Description:

// Write a function that takes a string of braces, and determines if the order of the braces is valid. It should return true if the string is valid, and false if it's invalid.

// This Kata is similar to the Valid Parentheses Kata, but introduces new characters: brackets[], and curly braces {}. Thanks to @arnedag for the idea!

// All input strings will be nonempty, and will only consist of parentheses, brackets and curly braces: ()[]{ }.
// What is considered Valid ?

// A string of braces is considered valid if all braces are matched with the correct brace.
// Examples

// "(){}[]"   =>  True
// "([{}])"   =>  True
// "(}"       =>  False
// "[(])"     =>  False
// "[({})](]" =>  False

//Console.WriteLine(validBraces("(){}[]"));
//Console.WriteLine(validBraces("([{}])"));
Console.WriteLine(validBraces("(}"));
Console.WriteLine(validBraces("[(])"));
Console.WriteLine(validBraces("[({})](]"));

//static bool validBraces(String braces)
//{
//    var pairs = new Dictionary<char, int>
//    {
//        { '[', 0 },
//        { ']', 0 },
//        { '{', 0 },
//        { '}', 0 },
//        { '(', 0 },
//        { ')', 0 },
//    };

//    foreach (char i in braces)
//    {
//        if (pairs.ContainsKey(i)) pairs[i] += 1;
//    }

//    return pairs.All(e => e.Value == 1);
//}

static bool validBraces(String braces)
{
    bool isTrue = false;
    var pairs = new Dictionary<char, int>
    {
        { '[', 1 },
        { ']', 2 },
        { '{', 4 },
        { '}', 5 },
        { '(', 7 },
        { ')', 8 },
    };

    for (int i = 0; i < braces.Length;)
    {
        if (pairs[braces[i]] + 1 == pairs[braces[(braces.Length - 1) - i]])
        {
            isTrue = true;
            i++;
            if (i == braces.Length / 2) break;
        }
        else if (pairs[braces[i]] + 1 == pairs[braces[i + 1]])
        {
            isTrue = true;
            i += 2;
        }
        else i++;
    }

    return isTrue;
}

Console.ReadLine();
// Task
//
//     Given a string str, reverse it and omit all non-alphabetic characters.
//     Example
//
// For str = "krishan", the output should be "nahsirk".
//
//     For str = "ultr53o?n", the output should be "nortlu".
//     Input/Output
//
//     [input] string str
//
// A string consists of lowercase latin letters, digits and symbols.
//
//     [output] a string
//
// Hello, World!");

Console.WriteLine(ReverseLetter("jake"));
Console.WriteLine(ReverseLetter("j1a2k3e"));

string ReverseLetter(string str)
{
    string res = "";
    for (int i = str.Length - 1; i >= 0; i--)
    {
        if(char.IsLetter(str[i])) 
            res += str[i];
    }
    return res;
}


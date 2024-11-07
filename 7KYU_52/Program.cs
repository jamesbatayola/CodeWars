// Description:
//
// Given a string, capitalize the letters that occupy even indexes and odd indexes separately, and return as shown below. Index 0 will be considered even.
//
//     For example, capitalize("abcdef") = ['AbCdEf', 'aBcDeF']. See test cases for more examples.
//
//     The input will be a lowercase string with no spaces.
//
//     Good luck!


using System.Text;

var test1 = Capitalize("abcdefg");
foreach (var i in test1)
{
    Console.WriteLine(i);
}

static string[] Capitalize(string s)
{
    var odd = new StringBuilder(s.ToLower());
    var even = new StringBuilder(s.ToLower());

    for (int i = 0; i < s.Length; i++)
    {
        if (i % 2 == 0)
            even[i] = char.ToUpper(s[i]);
        else 
            odd[i] = char.ToUpper(s[i]);
    }
    
    return new[] {odd.ToString(), even.ToString()};
}
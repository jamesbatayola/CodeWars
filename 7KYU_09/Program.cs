using System.Text.RegularExpressions;

namespace _7KYU_09;

//Return the number(count) of vowels in the given string.

//We will consider a, e, i, o, u as vowels for this Kata (but not y).

//The input string will only consist of lower case letters and/or spaces.

internal class Program
{
    static void Main(string[] args)
    {
       

        Console.ReadLine();
    }

    // SOLUTION
    public static int GetVowelCount(string str)
    {
        Regex rgx = new Regex(@"^a|e|i|o|u$");
        return str.Count(x => rgx.IsMatch(x.ToString()));
    }

    // OTHER ANSWER -------------------

    public static int _GetVowelCount(string str)
    {
        return str.Count(i => "aeiou".Contains(i));
    }

}

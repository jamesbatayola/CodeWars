using System.Text;

namespace _7KYU_12;

// This time no story, no theory.The examples below show you how to write function accum:

// Examples:
// accum("abcd") -> "A-Bb-Ccc-Dddd"
// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt") -> "C-Ww-Aaa-Tttt"
// The parameter of accum is a string which includes only letters from a..z and A..Z.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Accum("ZpglnRxqenU"));
        Console.WriteLine(Accum("NyffsGeyylB"));

        Console.ReadLine();
    }

    // SOLUTION
    public static String Accum(string s)
    {
        return string.Join("-", s.Select((val, ind) => char.ToUpper(val) + new string(char.ToLower(val), ind)));
    }

}

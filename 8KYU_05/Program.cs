using System.Text.RegularExpressions;

namespace _8KYU_05;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Correct("hell0"));

        Console.ReadLine();
    }

    // SOLUTION
    public static string Correct(string text)
    {
        var revise = text.Select(ii => ii switch
        {
            '5' => "S",
            '0' => "O",
            '1' => "I",
            _ => ii.ToString()
        });

        return string.Join("", revise);

    }

    // ALTERNATIVE ----------------------
    public static string _Correct(string text)
    {
        return text
        .Replace("0", "O")
        .Replace("1", "I")
        .Replace("5", "S");
    }

}

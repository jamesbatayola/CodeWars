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
            '5' => "s",
            '0' => "o",
            '1' => "i",
            _ => ii.ToString()
        });

        return string.Join("", revise);

    }

}

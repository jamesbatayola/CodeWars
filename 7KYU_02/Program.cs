namespace _7KYU_02;

/* 
 * An isogram is a word that has no repeating letters, consecutive or non-consecutive.
 * Implement a function that determines whether a string that contains only letters is an isogram.
 * Assume the empty string is an isogram. Ignore letter case.
 */

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsIsogram("abcda"));
        Console.WriteLine(IsIsogram("abcdefghijk"));

        Console.ReadLine();
    }

    public static bool IsIsogram(string str)
    {
        return str
                .ToLower()
                .Select((item, index) => new { item, index })
                .GroupBy(x => x.item)
                .OrderByDescending(x => x.Count())
                .All(x => x.Count() == 1);
    }

    // COMPLETED :)

    // BEST PRACTICE --------------------------

    public static bool _IsIsogram(string str)
    {
        return str.ToLower().Distinct().Count() == str.Length;
    }

}
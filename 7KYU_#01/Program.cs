namespace _7KYU__01;

/* 
 * Take 2 strings s1 and s2 including only letters from a to z. 
 * Return a new sorted string, the longest possible,
 * containing distinct letters - each taken only once - coming from s1 or s2.
 */

internal class Program
{
    static void Main(string[] args)
    {
        int[] num = { 0, 3, 1, 2 };
        Array.Sort(num);

        foreach (var i in num)
            Console.WriteLine(i);

        Console.ReadLine();
    }

    // SOLUTION
    public static string Longest(string s1, string s2)
    {
        // your code
        char[] std = (s1 + s2).Distinct().ToArray();
        Array.Sort(std);
        return string.Join("", std);
    }

}

// COMPLETED :)
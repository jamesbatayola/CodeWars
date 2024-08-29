namespace _8KYU_03;

//Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.
internal class Program
{
    static void Main(string[] args)
    {
        string asd = "";

        Console.WriteLine(asd + "s");
    }

    public static string RepeatStr(int n, string s)
    {
        //string result = "";

        //for (int i = 0; i < n; i++)
        //    result += s;

        return string.Join("", Enumerable.Range(1, n).Select(x => s).ToArray());
    }

}

// COMPLETED

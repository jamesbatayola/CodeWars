namespace _8KYU_10;

//When provided with a number between 0-9, return it in words.

//Input :: 1

//Output:: "One".

//If your language supports it, try using a switch statement.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    // SOLUTION
    public static string SwitchItUp(int number)
    {
        return number switch
        {
            0 => "Zero",
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            _ => "INVALID"
        };
    }

    // OTHER ANSWER 

    public static string _SwitchItUp(int number)
    {
        var dic = new Dictionary<int, string>()
    {
      {1, "One"},
      {2, "Two"},
      {3, "Three"},
      {4, "Four"},
      {5, "Five"},
      {6, "Six"},
      {7, "Seven"},
      {8, "Eight"},
      {9, "Nine"},
      {0, "Zero"}
    };
        return dic[number];
    }
}

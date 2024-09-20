namespace _7KYU_23;

// Welcome.In this kata, you are asked to square every digit of a number and concatenate them.

// For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1. (81-1-1-81)

// Example #2: An input of 765 will/should return 493625 because 72 is 49, 62 is 36, and 52 is 25. (49-36-25)

// Note: The function accepts an integer and returns an integer.

// Happy Coding!


internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SquareDigits(9119));
    }
         
    // SOLUTION
    public static int SquareDigits(int n)
    {
        int[] nums = n.ToString().Select(e => e - '0').ToArray();

        return Convert.ToInt32(string.Join("", nums.Select(e => e * e).ToArray()));
    }

}

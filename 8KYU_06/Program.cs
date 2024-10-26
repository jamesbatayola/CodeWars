namespace _8KYU_06;

/*
 * Your task is to make two functions ( max and min, or maximum and minimum, etc., depending on the language )
 * that receive a list of integers as input,
 * and return the largest and lowest number in that list, respectively.
 */

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 4, 6, 2, 1, 9, 63, -134, 566 };

        Console.WriteLine(Min(nums));
        Console.WriteLine(Max(nums));

        Console.ReadLine();
    }

    // SOLUTION
    public static int Min(int[] list)
    {
        return list.Min();
    }

    public static int Max(int[] list)
    {
        return list.Max();
    }
}

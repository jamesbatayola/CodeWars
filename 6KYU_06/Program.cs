namespace _6KYU_06;

// Given an array of integers, find the one that appears an odd number of times.

// There will always be only one integer that appears an odd number of times.

// Examples
// [7] should return 7, because it occurs 1 time (which is odd).
// [0] should return 0, because it occurs 1 time(which is odd).
// [1, 1, 2] should return 2, because it occurs 1 time(which is odd).
// [0, 1, 0, 1, 0] should return 0, because it occurs 3 times(which is odd).
// [1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1] should return 4, because it appears 1 time(which is odd).

internal class Program
{
    static void Main(string[] args)
    {
        int[] seq = { 1, 1, 3, 3, 3, 2, 2, 2, 2 };

        find_it(seq);    

        Console.ReadLine();
    }

    // SOLUTION
    public static int find_it(int[] seq)
    {
        int[] oddOne = seq
                    .GroupBy(x => x)
                    .First(x => x.Count() % 2 != 0)
                    .Distinct()
                    .ToArray();

        return oddOne[0];
    }

    // OTHER ANSWER -----------------------------------

    public static int _find_it(int[] seq)
    {
        return seq
            .GroupBy(x => x)
            .Single(g => g.Count() % 2 == 1).Key;
    }

}

namespace _5KYU_01;

// The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or list of integers:

// maxSequence[-2, 1, -3, 4, -1, 2, 1, -5, 4]
// -- should be 6: [4, -1, 2, 1]
// Easy case is when the list is made up of only positive numbers and the maximum sum is the sum of the whole array.If the list is made up of only negative numbers, return 0 instead.

// Empty list is considered to have zero greatest sum. Note that the empty list or array is also a valid sublist/subarray.

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int[] asd = { -5, 18, -1, -2 };

        Console.WriteLine(asd.Sum());

        //Console.WriteLine(MaxSequence(nums));

        Console.ReadLine();
    }

    public static int MaxSequence(int[] arr)
    {
        if (arr.All(x => x <= 0) || arr.Count() <= 0)
        {
            return 0;
        }

        int temp = arr.Sum();

        var sub = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            sub.Add(arr[i]);
            for (int j = i + 1; j < arr.Length; j++)
            {
                sub.Add(arr[j]);
                if (sub.Sum() > temp)
                {
                    temp = sub.Sum();
                }
            }
            sub.Clear();
        }

        return temp;
    }

    // CLEVER! :O ----------------------------------------

    public static int _MaxSequence(int[] arr)
    {
        int max = 0, res = 0, sum = 0;
        foreach (var item in arr)
        {
            sum += item;
            max = sum > max ? max : sum;
            res = res > sum - max ? res : sum - max;
        }
        return res;
    }

}
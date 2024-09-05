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

        _MaxSequence(nums);

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

    // OTHER ANSWER --------------------------------------

    public static int _MaxSequence(int[] arr)
    {
        int currentMax = 0, totalMax = 0;
        foreach (var a in arr)
        {
            currentMax = Math.Max(0, currentMax + a);
            totalMax = Math.Max(totalMax, currentMax);
        }
        return totalMax;
    }

    public static int __MaxSequence(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                max = Math.Max(max, sum);
            }
        }
        return max;
    }

    // CLEVER! :O ----------------------------------------

    // { 2, 1, -3, 4, -1, 2, 1, -5, 4 } 
    public static int ___MaxSequence(int[] arr)
    {
        int max = 0, res = 0, sum = 0;  // Initialize variables

        foreach (var item in arr)  // Iterate over each element in the array
        {
            sum += item;  // Add the current element to the running sum
            max = sum > max ? max : sum;  // Update max to be the minimum subarray sum encountered so far
            res = res > sum - max ? res : sum - max;  // Update res to be the maximum difference, which is the max sum subarray
        }

        return res;  // Return the maximum sum of any contiguous subarray
    }

}
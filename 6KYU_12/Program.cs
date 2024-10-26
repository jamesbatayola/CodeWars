namespace _6KYU_12;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = new int[] { 1, 2, 3, 4, 3, 2, 1 };
        int[] nums2 = new int[] { 1, 100, 50, -51, 1, 1 };
        int[] nums3 = new int[] { 1, 2, 3, 4, 5, 6 };
        int[] nums4 = new int[] { 20, 10, 30, 10, 10, 15, 35 };
        int[] nums5 = new int[] { 20, 10, -80, 10, 10, 15, 35 };
        int[] nums6 = new int[] { 0, 8 };


        Console.WriteLine(FindEvenIndex(nums1));
        Console.WriteLine(FindEvenIndex(nums2));
        Console.WriteLine(FindEvenIndex(nums3));
        Console.WriteLine(FindEvenIndex(nums4));
        Console.WriteLine(FindEvenIndex(nums5));
        Console.WriteLine(FindEvenIndex(nums6));

        Console.WriteLine();

        Console.ReadLine();
    }

    // SOLUTION
    public static int FindEvenIndex(int[] arr)
    {
        int length = arr.Length;

        for(int i = 0; i < length;)
        {
            int l = i == 0 ? 0 : arr.Take(i).Sum();
            int r = i == 0 ? arr.TakeLast(length - 1).Sum() : arr.TakeLast(length - (i + 1)).Sum();
            if (l == r)
            {
                return i; 
            }
            i++;
        }

        return -1;
    }

    // OTHER ANSWER ------------------

    public static int _FindEvenIndex(int[] arr)
    {
        int leftSum = 0, rightSum = arr.Sum();

        for (int i = 0; i < arr.Length; ++i)
        {
            rightSum -= arr[i];

            if (leftSum == rightSum)
            {
                return i;
            }

            leftSum += arr[i];
        }

        return -1;
    }


}

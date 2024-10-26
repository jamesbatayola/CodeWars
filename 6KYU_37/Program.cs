// Write a function that takes an array of numbers (integers for the tests) and a target number. It should find two different items in the array that, when added together, give the target value. The indices of these items should then be returned in a tuple / list (depending on your language) like so: (index1, index2).

// For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.

// The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; target will always be the sum of two different items from that array).

// two_sum([1, 2, 3], 4) == { 0, 2}
// two_sum([3, 2, 4], 6) == { 1, 2}

var test1 = TwoSum(new int[] { 1, 2, 3 }, 4);
var test2 = TwoSum(new int[] { 3, 2, 4 }, 6);
var test3 = TwoSum(new int[] { 2, 2, 3 }, 4);

Console.WriteLine(string.Join(" ", test1));
Console.WriteLine(string.Join(" ", test2));
Console.WriteLine(string.Join(" ", test3));

static int[] TwoSum(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < numbers.Length; j++)
        {
            if (numbers[i] == numbers[j]) break;
            if (numbers[i] + numbers[j] == target)
            {
                return new int[] { j, i };
            }
        }
    }
    return new int[] { 0, 1 };
}

Console.ReadLine();
// Complete the function that
//
// accepts two integer arrays of equal length
//     compares the value each member in one array to the corresponding member in the other
// squares the absolute value difference between those two values
//     and returns the average of those squared absolute value difference between each member pair.
//     Examples
//         [1, 2, 3], [4, 5, 6]              -->   9   because (9 + 9 + 9) / 3
//     [10, 20, 10, 2], [10, 25, 5, -2]  -->  16.5 because (0 + 25 + 25 + 16) / 4
//     [-1, 0], [0, -1]                  -->   1   because (1 + 1) / 2

Console.WriteLine(Solution([1, 2, 3], [4, 5, 6]));
Console.WriteLine(Solution([10, 20, 10, 2], [10, 25, 5, -2] ));
Console.WriteLine(Solution([-1, 0], [0, -1]));

static double Solution(int[] firstArray, int[] secondArray)
{
    var o = new int[firstArray.Length];
    for (int i = 0; i < firstArray.Length; i++)
    {
        int min = firstArray[i] > secondArray[i] ? secondArray[i] : firstArray[i];
        int max = firstArray[i] < secondArray[i] ? secondArray[i] : firstArray[i];
        int count = 0;
        while (min < max)
        {
            min++;
            count++;
        }

        o[i] = count * count;
    }

    return (double)o.Sum() / firstArray.Length;
}

// compares the value difference in each member of 2 arrays
//  - create a count var
//  - increment count by 1 for each digit differences
// squares that count var by itself
// sum count var for each member
// divide the sum value by array length
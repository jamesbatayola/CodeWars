// Task
// You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.

// Examples
// [7, 1]  =>  [1, 7]
// [5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
// [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]Task
// You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.

// Examples
// [7, 1]  =>  [1, 7]
// [5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
// [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]

var col1 = SortArray(new int[] { 5, 3, 2, 8, 1, 4 });
var col2 = SortArray(new int[] { 5, 3, 1, 8, 0 });

foreach(var i in col1)
    Console.WriteLine(i);

static int[] SortArray(int[] array)
{
    int[] odd = array.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();

    int[] res = new int[array.Length];

    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) res[i] = odd[count++];
        else res[i] = array[i];
    }

    return res;
}

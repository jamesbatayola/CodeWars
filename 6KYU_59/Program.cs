// Description:
// In this kata you're expected to sort an array of 32-bit integers in ascending order of the number of on bits they have.
//
//     E.g Given the array [7, 6, 15, 8]
//
// 7 has 3 on bits (000...0111)
// 6 has 2 on bits (000...0110)
// 15 has 4 on bits (000...1111)
// 8 has 1 on bit (000...1000)
// So the array in sorted order would be [8, 6, 7, 15].
//
//     In cases where two numbers have the same number of bits, compare their real values instead.
//
//     E.g between 10 (...1010) and 12 (...1100), they both have the same number of on bits '2' but the integer 10 is less than 12 so it comes first in sorted order.
//
//     Your task is to write a function that takes an array of integers and sort them as described above.
//
//     Note: your solution has to sort the array in place.
//
//     Example:
//
// [3, 8, 3, 6, 5, 7, 9, 1]   =>    [1, 8, 3, 3, 5, 6, 9, 7]

var test1 = SortByBit(new int[] { 3, 8, 3, 6, 5, 7, 9, 1 });
var test2 = SortByBit(new int[] { 9, 4, 5, 3, 5, 7, 2, 56, 8, 2, 6, 8, 0 });

foreach (var each in test1)
    Console.WriteLine(each);

static int[] SortByBit(int[] array)
{
    var binaries = array.Select(e => Convert.ToString(e, 2)).OrderBy(e => e.Count(c => c == '1'));
    var groups = binaries.GroupBy(e => e.Count(c => c == '1'));

    var res = new List<int>();

    foreach (var group in groups)
    {
        var temp = group.Select(int.Parse).ToList();

        temp.Sort();

        res.AddRange(temp.Select(e => Convert.ToInt32($"{e}", 2)));
    }

    return res.ToArray();
}

// loop through array
// convert each to binary
// count the 1s in each binary converted
// sort them by the number of 1s on each integer
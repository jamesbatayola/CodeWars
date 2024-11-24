// In this kata, you will write a function that returns the positions and the values of the "peaks" (or local maxima) of a numeric array.
//
//     For example, the array arr = [0, 1, 2, 5, 1, 0] has a peak at position 3 with a value of 5 (since arr[3] equals 5).
//
//     The output will be returned as a Dictionary<string, List<int>> with two key-value pairs: "pos" and "peaks". If there is no peak in the given array, simply return {"pos" => new List<int>(), "peaks" => new List<int>()}.
//
// Example: pickPeaks([3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 3]) should return {pos: [3, 7], peaks: [6, 3]} (or equivalent in other languages)
//
// All input arrays will be valid integer arrays (although it could still be empty), so you won't need to validate the input.
//
//     The first and last elements of the array will not be considered as peaks (in the context of a mathematical function, we don't know what is after and before and therefore, we don't know if it is a peak or not).
//
// Also, beware of plateaus !!! [1, 2, 2, 2, 1] has a peak while [1, 2, 2, 2, 3] and [1, 2, 2, 2, 2] do not. In case of a plateau-peak, please only return the position and value of the beginning of the plateau. For example: pickPeaks([1, 2, 2, 2, 1]) returns {pos: [1], peaks: [2]} (or equivalent in other languages)
//
// Have fun!

var test0 = GetPeaks([1, 2, 3, 6, 4, 1, 2, 3, 2, 1]);
var test1 = GetPeaks([1, 2, 3, 6, 4, 1, 2, 3, 2, 1]);
var test2 = GetPeaks([3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 2, 2, 1]);
var test3 = GetPeaks([2, 1, 3, 1, 2, 2, 2, 2, 1]);
var test4 = GetPeaks([2, 1, 3, 1, 2, 2, 2, 2]);
var test5 = GetPeaks([17, -3, -4, 2, 10, 5, 16, 3, -5, 0, 0, -4, 1, -2, 12, 8, 15, -2, 1, 9, 1, 15, -1]);
var test6 = GetPeaks([-1, 6, 6, 12, -4, 2, 11, 16, 9, 11, 8, 4, 1, 16, -1, 12, 11, 0, -2, 2, 5, 4, 1]);

foreach (var item in test6)
foreach (var value in item.Value)
    Console.WriteLine(value);

// MY ANSWER ( UNFINISHED )

static Dictionary<string, List<int>> GetPeaks(int[] arr)
{
    var res = new Dictionary<string, List<int>>();

    var pos = new List<int>();
    var peaks = new List<int>();

    int lMinima = arr[0];

    for (int i = 1; i < arr.Length - 1; i++)
    {
        lMinima = lMinima > arr[i] ? arr[i] : lMinima;

        if (arr[i] > arr[i + 1] && arr[i] > lMinima)
        {
            pos.Add(i);
            peaks.Add(arr[i]);
            lMinima = arr[i + 1];
        }

        // plateau
        if (arr[i] == arr[i + 1] && arr[i + 1] == arr[i + 2] && arr[i] > lMinima && arr[^2] > arr[^1])
        {
            pos.Add(i);
            peaks.Add(arr[i]);
            break;
        }
    }

    res.Add("pos", pos);
    res.Add("peaks", peaks);

    return res;
}

// CHAT_GPT =================================

static Dictionary<string, List<int>> _GetPeaks(int[] arr)
{
    var res = new Dictionary<string, List<int>>
    {
        { "pos", new List<int>() },
        { "peaks", new List<int>() }
    };

    if (arr.Length < 3)
        return res; // No peaks possible in arrays smaller than 3

    int plateauStart = -1;

    for (int i = 1; i < arr.Length - 1; i++)
    {
        // Detect a potential plateau
        if (arr[i] > arr[i - 1] && arr[i] == arr[i + 1])
        {
            plateauStart = i; // Mark the start of a plateau
        }
        // Confirm a peak or plateau end
        else if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
        {
            res["pos"].Add(i);
            res["peaks"].Add(arr[i]);
        }
        // Handle end of a plateau
        else if (plateauStart != -1 && arr[i] > arr[i + 1])
        {
            res["pos"].Add(plateauStart);
            res["peaks"].Add(arr[plateauStart]);
            plateauStart = -1; // Reset plateauStart
        }
    }

    return res;
}
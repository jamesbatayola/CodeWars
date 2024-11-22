// You get an array of arrays.
//     If you sort the arrays by their length, you will see, that their length-values are consecutive.
//     But one array is missing!
//
//
// You have to write a method, that return the length of the missing array.
//
//     Example:
// [[1, 2], [4, 5, 1, 1], [1], [5, 6, 7, 8, 9]] --> 3
//
// If the array of arrays is null/nil or empty, the method should return 0.
//
//     When an array in the array is null or empty, the method should return 0 too!
// There will always be a missing element and its length will be always between the given arrays.
//
//     Have fun coding it and please don't forget to vote and rank this kata! :-)
//
// I have created other katas. Have a look if you like coding and challenges.ello, World!");

// var dummyArray1 = new Object[][] { [1, 2], [1, 2, 3, 4], [1], [1, 2, 3, 4, 5] };
// var dummyArray2 = new Object[][] { [5, 2, 9], [4, 5, 1, 1], [1], [5, 6, 7, 8, 9] };
// var dummyArray3 = new Object[][] { [null], [null, null, null] };
// var dummyArray4 = new Object[][]
//     { ['a', 'a', 'a'], ['a', 'a'], ['a', 'a', 'a', 'a'], ['a'], ['a', 'a', 'a', 'a', 'a', 'a'] };
var dummyArray5 = new Object[][] { [], [], [] };
var dummyArray6 = null;

// Console.WriteLine(new object?[] {  }.Length == 1);

var test = GetLengthOfMissingArray(dummyArray5);

Console.WriteLine(test);

static int GetLengthOfMissingArray(object[][] arrayOfArrays)
{
    if (arrayOfArrays == null || arrayOfArrays.Length <= 0) return 0;
    if (arrayOfArrays.Any(e => e == null || e.Length <= 0)) return 0;
    
    var grouped = arrayOfArrays.OrderBy(a => a.Length).ToArray();
    
    int res = 0;
    
    for (int i = 0; i < grouped.Length - 1; i++)
    {
        if (grouped[i].Length + 1 != grouped[i + 1].Length)
        {
            res = grouped[i].Length + 1;
            break;
        }
    }

    return res;
}

// group the array by ther length
// sort it ascending
// 
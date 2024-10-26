// Given an array of integers of any length, return an array that has 1 added to the value represented by the array.

// If the array is invalid (empty, or contains negative integers or integers with more than 1 digit), return nil (or your language's equivalent).

// Examples
// Valid arrays

// [4, 3, 2, 5] would return [4, 3, 2, 6] (4325 + 1 = 4326)
// [1, 2, 3, 9] would return [1, 2, 4, 0] (1239 + 1 = 1240)
// [9, 9, 9, 9] would return [1, 0, 0, 0, 0] (9999 + 1 = 10000)
// [0, 1, 3, 7] would return [0, 1, 3, 8] (0137 + 1 = 0138)
// Invalid arrays

// [] is invalid because it is empty
// [1, -9] is invalid because -9 is not a non-negative integer
// [1, 2, 33] is invalid because 33 is not a single-digit integerGiven an array of integers of any length, return an array that has 1 added to the value represented by the array.

// If the array is invalid (empty, or contains negative integers or integers with more than 1 digit), return nil (or your language's equivalent).

// Examples
// Valid arrays

// [4, 3, 2, 5] would return [4, 3, 2, 6] (4325 + 1 = 4326)
// [1, 2, 3, 9] would return [1, 2, 4, 0] (1239 + 1 = 1240)
// [9, 9, 9, 9] would return [1, 0, 0, 0, 0] (9999 + 1 = 10000)
// [0, 1, 3, 7] would return [0, 1, 3, 8] (0137 + 1 = 0138)
// Invalid arrays

// [] is invalid because it is empty
// [1, -9] is invalid because -9 is not a non-negative integer
// [1, 2, 33] is invalid because 33 is not a single-digit integer

//Console.WriteLine('0' - 0);

using System.Globalization;
using System.Numerics;

//var asd1 = UpArray(new int[] { 2, 3, 9 });
//var asd2 = UpArray(new int[] { 4, 3, 2, 5 });
var asd3 = UpArray(new int[] { 0, 0, 4, 2 });

foreach (var i in asd3)
    Console.WriteLine(i);

static int[] UpArray(int[] num)
{
    if (num.Length <= 0 || num.Any(e => e < 0 || e > 9))
    {
        return null;
    }

    string stringNum = "";

    if (num[0] == 0)
    {
        string temp1 = string.Join("", num.SkipWhile(e => e == 0));
        var temp2 =  BigInteger.Parse(temp1) + 1;
        stringNum = string.Join("", num.SkipLast(temp1.Length))  + temp2.ToString();
    }
    else
        stringNum = Convert.ToString(BigInteger.Parse(string.Join("", num)) + 1) ;

    return stringNum.ToCharArray().Select(e => e == '0' ? 0 : e - '0').ToArray();
}

Console.ReadLine();
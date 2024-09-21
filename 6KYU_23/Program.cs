// You are given an array (which will have a length of at least 3, but could be very large) containing integers. The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. Write a method that takes the array as an argument and returns this "outlier" N.
// Examples

// [2, 4, 0, 100, 4, 11, 2602, 36] -->  11 (the only odd number)

// [160, 3, 1719, 19, 11, 13, -21] --> 160 (the only even number)

// You are given an array (which will have a length of at least 3, but could be very large) containing integers. The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. Write a method that takes the array as an argument and returns this "outlier" N.
// Examples

// [2, 4, 0, 100, 4, 11, 2602, 36] -->  11 (the only odd number)

// [160, 3, 1719, 19, 11, 13, -21] --> 160 (the only even number)

Console.WriteLine(__Find(new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 }));
Console.WriteLine(__Find(new int[] { 160, 3, 1719, 19, 11, 13, -21}));
Console.WriteLine(__Find(new int[] { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 }));

static int __Find(int[] integers)
{
    var odd = new List<int>();
    var even = new List<int>();

    foreach (var i in integers)
    {
        if (i % 2 == 0) odd.Add(i);
        else even.Add(i);
    }

    return odd.Count() > even.Count() ? even[0] : odd[0];
}

Console.ReadLine();
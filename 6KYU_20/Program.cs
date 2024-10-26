// Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

// It should remove all values from list a, which are present in list b keeping their order.

// Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }) => new int[] { 2 }

// If a value is present in b, all of its occurrences must be removed from the other:

// Kata.ArrayDiff(new int[] { 1, 2, 2, 2, 3 }, new int[] { 2 }) => new int[] { 1, 3 }

var a1 = ArrayDiff(new int[] { 1, 2 }, new int[] { 1 });
var a2 = ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 });
var a3 = ArrayDiff(new int[] { 1, 2, 2 }, new int[] { });
var a4 = ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 });
var a5 = ArrayDiff(new int[] { }, new int[] { 1, 2 });

var a6 = ArrayDiff(new int[] {10, 20, 30, 40, 50, 55, 90 }, new int[] { 10, 21, 3,1, 3123, 12, 55 });

foreach (int i in a6) 
    Console.WriteLine(i);

static int[] ArrayDiff(int[] a, int[] b)
{
   var res = new List<int>();

    for (int i = 0; i < a.Length; i++)
    {
        bool isPresent = false;

        for(int j = 0; j < b.Length; j++)
        {
            if (a[i] == b[j]) isPresent = true;
        }
        
        if(!isPresent) res.Add(a[i]);
    }

    return res.ToArray();
}

Console.ReadLine();
// Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.


var test1 = MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });

foreach(var i in test1)
    Console.WriteLine(i);

static int[] MoveZeroes(int[] arr)
{
    var zeros = arr.Count(e => e == 0);
    var nonZero = arr.Where(e => e != 0).ToList();

    for (int i = 0; i < zeros; i++)
    {
        nonZero.Add(0);
    }

    return nonZero.ToArray();
}

// OTHER ANSWER -----------------------------

static int[] _MoveZeroes(int[] arr)
{
    return arr.OrderBy(x => x == 0).ToArray();
}

Console.ReadLine();
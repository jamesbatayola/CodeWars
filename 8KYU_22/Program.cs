// Description:

// Given a non-empty array of integers, return the result of multiplying the values together in order. Example:

// [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24

// Description:

// Given a non-empty array of integers, return the result of multiplying the values together in order. Example:

// [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24

Console.WriteLine(Grow(new int[] { 1, 2, 3, 4 }));

static int Grow(int[] x)
{
    return x.Aggregate((x, y) => x * y);
}

Console.ReadLine();
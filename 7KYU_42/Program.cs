// Description:
//
// Your task is to write a function which returns the sum of a sequence of integers.
//
// The sequence is defined by 3 non-negative values: begin, end, step.
//
// If begin value is greater than the end, your function should return 0. If end is not the result of an integer number of steps, then don't add it to the sum. See the 4th example below.
//
// Examples
//
// 2,2,2 --> 2
// 2,6,2 --> 12 (2 + 4 + 6)
// 1,5,1 --> 15 (1 + 2 + 3 + 4 + 5)
// 1,5,3  --> 5 (1 + 4)

// Console.WriteLine(SequenceSum(2,2,2));
// Console.WriteLine(SequenceSum(2, 6,2));
// Console.WriteLine(SequenceSum(1, 5,1));
// Console.WriteLine(SequenceSum(1, 5,3));

Console.WriteLine(SequenceSum(2, 6,2));
Console.WriteLine(SequenceSum(1, 5, 1));
Console.WriteLine(SequenceSum(1, 5,3));
Console.WriteLine(SequenceSum(0, 15,3));
Console.WriteLine(SequenceSum(16, 15,3));
Console.WriteLine(SequenceSum(2, 24,22));
Console.WriteLine(SequenceSum(2, 2,2));
Console.WriteLine(SequenceSum(2, 2,1));
Console.WriteLine(SequenceSum(1, 15,3));
Console.WriteLine(SequenceSum(15, 1,3));

static int SequenceSum(int start, int end, int step)
{
    if (start > end) return 0;
    
    int res = start;
    
    var seq = new List<int> { start };
    
    while (res < end && res != end && res + step <= end)
    {
        res += step;
        seq.Add(res); 
    }
    
    return seq.Sum();
}

// OTHER_ANSWER -----------------------------------

static int _SequenceSum(int start, int end, int step)
{
    int sum = 0;
    
    for ( int i = start; i <= end; i += step)
    {
        sum += i;
    }
  
    return sum;
}

Console.ReadLine();
//Description:

//Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.
//Examples:

//Input: 42145 Output: 54421

//Input: 145263 Output: 654321

//Input: 123456789 Output: 987654321
//Fundamentals

Console.WriteLine(DescendingOrder(42145));

static int DescendingOrder(int num)
{
    int[] nums = num.ToString().Select(e => e - '0').ToArray();
    return Convert.ToInt32(string.Join("", nums.OrderByDescending(e => e).ToArray()));
}

// OTHER ANSWERS -------------

static int _DescendingOrder(int num)
{
    return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
}

Console.ReadLine();
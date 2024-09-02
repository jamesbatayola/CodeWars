using System.Collections;

namespace _6KYU_05;

/*
 * The number 89 is the first integer with more than one digit that fulfills the property
 * partially introduced in the title of this kata. What's the use of saying "Eureka"? 
 * Because this sum gives the same number: 89 = 8^1 + 9^2
 */

internal class Program
{
    static void Main(string[] args)
    {
        var coll = SumDigPow(1, 10);

        foreach(var i in coll)
            Console.WriteLine(i);

        Console.ReadLine();
    }

    // SOLUTIoN
    public static long[] SumDigPow(long a, long b)
    {
        int[] nums = Enumerable.Range((int) a, (int)(b - a) + 1).ToArray();
        char[][] asd = nums.Select(x => x.ToString().ToCharArray()).ToArray();

        var result = new List<long>();

        for (int i = 0; i < asd.Count(); i++)
        {
            int curIndex = asd[i].Count();

            if (curIndex > 1)
            {
                var doubles = new List<double>();
                for (int j = 0; j < curIndex; j++)
                {
                    double temp = asd[i][j] - '0'; // char to int
                    double pow = Math.Pow(temp, j + 1);
                    doubles.Add(pow);
                }
                int curValue = Convert.ToInt32(string.Join("", asd[i]));

                if (doubles.Sum() == curValue)
                    result.Add((long)doubles.Sum());
            }
            else
            {
                long temp = asd[i][0] - '0'; // char to in
                result.Add(temp);
            }
        }

        return (long[]) result.ToArray();

    }

    // OTHER ANSWER ------------------

    public static long[] _SumDigPow(long a, long b)
    {
        List<long> values = new List<long>();
        for (long x = a; x <= b; x++)
        {
            if (x.ToString().Select((c, i) => Math.Pow(Char.GetNumericValue(c), i + 1)).Sum() == x)
                values.Add(x);
        }
        return values.ToArray();
    }

}

// COMPLETED

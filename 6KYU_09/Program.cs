namespace _6KYU_09;

//Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

//For example(Input --> Output):

//39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit, there are 3 multiplications)
//999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2, there are 4 multiplications)
//4 --> 0 (because 4 is already a one-digit number, there is no multiplication

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Persistence(999));

        Console.ReadLine();
    }

    // SOLUTION
    public static int Persistence(long n)
    {
        int[] nums = n.ToString().ToCharArray().Select(x => x - '0').ToArray();

        int times = 0;
        while (nums.Length >= 2)
        {
            times++;
            int ini = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                ini *= nums[i];
            }
            nums = ini.ToString().ToCharArray().Select(x => x - '0').ToArray();
        }

        return times;
    }

    // OTHER ASNWERS -----------------------

    public static int _Persistence(long n)
    {
        int count = 0;
        while (n > 9)
        {
            count++;
            n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
        }
        return count;
    }

    public static int __Persistence(long n)
    {
        long nF = n.ToString().Aggregate(1, (a, b) => a * (b - '0'));
        return n < 9 ? 0 : 1 + Persistence(nF);
    }

}

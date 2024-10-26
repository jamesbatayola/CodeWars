namespace _8KYU_14;

//Complete the square sum function so that it squares each number passed into it and then sums the results together.

internal class Program
{
    static void Main(string[] args)
    {
        

        Console.ReadLine();
    }

    // SOLUTION
    public static int SquareSum(int[] numbers)
    {
        return numbers.Select(x => x * x).Sum();
    }

}

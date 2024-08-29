namespace _8KYU_01;

// This kata is about multiplying a given number by eight  if it is an even number and by nine otherwise.
internal class Program
{
    static void Main(string[] args)
    {
        Multiply(10);
        Multiply(9);
    }

    // SOLUTION
    public static int Multiply(int x)
    {
        // your code........
        return x % 2 == 0 ? x * 8 : x * 9;
    }

}

// COMPLETED
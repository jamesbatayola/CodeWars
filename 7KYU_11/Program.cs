namespace _7KYU_11;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(NbYear(1500, 5, 100, 5000));
     
        Console.ReadLine();
    }


    // SOLUTION
    public static int NbYear(int p0, double percent, int aug, int p)
    {
        int res = 0;
        while (p0 < p)
        {
            double added = (p0 * (percent * 0.01) + aug) + p0;
            p0 = (int)added;
            res++;
        }
        return res;
    }

}
